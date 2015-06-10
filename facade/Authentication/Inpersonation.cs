using System;
using System.ComponentModel;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Principal;
using Microsoft.Win32.SafeHandles;

namespace Microsoft.Wap.Facade.Authentication
{
    class Inpersonation
    {
        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern bool LogonUser(
            string username,
            string domain,
            string password,
            LogonType logonType,
            LogonProvider logonProvider,
            out SafeTokenHandle token);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        [SuppressUnmanagedCodeSecurity]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseHandle(IntPtr handle);

        public sealed class SafeTokenHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            private SafeTokenHandle()
                : base(true)
            {
            }

            protected override bool ReleaseHandle()
            {
                return CloseHandle(handle);
            }
        }

        public static void Impersonate(string domain, string username, string password, Action handler)
        {
            SafeTokenHandle safeHandle;
            var result = LogonUser(
                username,
                domain == null ? "." : domain,
                password,
                LogonType.LOGON32_LOGON_NEW_CREDENTIALS,
                LogonProvider.LOGON32_PROVIDER_WINNT50,
                out safeHandle);

            if (!result)
            {
                int ret = Marshal.GetLastWin32Error();
                throw new Win32Exception(ret);
            }

            using (safeHandle)
            using (WindowsImpersonationContext impersonatedUser = WindowsIdentity.Impersonate(safeHandle.DangerousGetHandle()))
            {
                handler();
            }
        }
    }
}
