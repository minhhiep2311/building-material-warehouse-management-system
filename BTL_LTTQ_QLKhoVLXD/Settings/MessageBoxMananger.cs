#pragma warning disable 0618

using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;

[assembly: SecurityPermission(SecurityAction.RequestMinimum, UnmanagedCode = true)]

namespace BTL_LTTQ_QLKhoVLXD.Settings
{
    public class MessageBoxManager
    {
        private delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);
        private delegate bool EnumChildProc(IntPtr hWnd, IntPtr lParam);

        private const int WH_CALLWNDPROCRET = 12;
        private const int WM_INITDIALOG = 0x0110;

        private const int MbOk = 1;
        private const int MbCancel = 2;
        private const int MbAbort = 3;
        private const int MbRetry = 4;
        private const int MbIgnore = 5;
        private const int MbYes = 6;
        private const int MbNo = 7;


        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hInstance, int threadId);

        [DllImport("user32.dll")]
        private static extern int UnhookWindowsHookEx(IntPtr idHook);

        [DllImport("user32.dll")]
        private static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", EntryPoint = "GetWindowTextLengthW", CharSet = CharSet.Unicode)]
        private static extern int GetWindowTextLength(IntPtr hWnd);


        [DllImport("user32.dll")]
        private static extern bool EnumChildWindows(IntPtr hWndParent, EnumChildProc lpEnumFunc, IntPtr lParam);

        [DllImport("user32.dll", EntryPoint = "GetClassNameW", CharSet = CharSet.Unicode)]
        private static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        [DllImport("user32.dll")]
        private static extern int GetDlgCtrlID(IntPtr hwndCtl);

        [DllImport("user32.dll")]
        private static extern IntPtr GetDlgItem(IntPtr hDlg, int nIdDlgItem);

        [DllImport("user32.dll", EntryPoint = "SetWindowTextW", CharSet = CharSet.Unicode)]
        private static extern bool SetWindowText(IntPtr hWnd, string lpString);


        [StructLayout(LayoutKind.Sequential)]
        public struct CwpretStruct
        {
            public IntPtr lResult;
            public IntPtr lParam;
            public IntPtr wParam;
            public uint message;
            public IntPtr hwnd;
        };

        private static readonly HookProc hookProc;
        private static readonly EnumChildProc EnumProc;
        [ThreadStatic]
        private static IntPtr _hHook;
        [ThreadStatic]
        private static int _nButton;

        /// <summary>
        /// OK text
        /// </summary>
        public static string Ok = "&OK";
        /// <summary>
        /// Cancel text
        /// </summary>
        public static string Cancel = "&Hủy";
        /// <summary>
        /// Abort text
        /// </summary>
        public static string Abort = "&Hủy bỏ";
        /// <summary>
        /// Retry text
        /// </summary>
        public static string Retry = "&Thử lại";
        /// <summary>
        /// Ignore text
        /// </summary>
        public static string Ignore = "&Bỏ qua";
        /// <summary>
        /// Yes text
        /// </summary>
        public static string Yes = "&Có";
        /// <summary>
        /// No text
        /// </summary>
        public static string No = "&Không";

        static MessageBoxManager()
        {
            hookProc = MessageBoxHookProc;
            EnumProc = MessageBoxEnumProc;
            _hHook = IntPtr.Zero;
        }

        /// <summary>
        /// Enables MessageBoxManager functionality
        /// </summary>
        /// <remarks>
        /// MessageBoxManager functionality is enabled on current thread only.
        /// Each thread that needs MessageBoxManager functionality has to call this method.
        /// </remarks>
        public static void Register()
        {
            if (_hHook != IntPtr.Zero)
                throw new NotSupportedException("One hook per thread allowed.");
            _hHook = SetWindowsHookEx(WH_CALLWNDPROCRET, hookProc, IntPtr.Zero, AppDomain.GetCurrentThreadId());
        }

        /// <summary>
        /// Disables MessageBoxManager functionality
        /// </summary>
        /// <remarks>
        /// Disables MessageBoxManager functionality on current thread only.
        /// </remarks>
        public static void Unregister()
        {
            if (_hHook == IntPtr.Zero) return;

            UnhookWindowsHookEx(_hHook);
            _hHook = IntPtr.Zero;
        }

        private static IntPtr MessageBoxHookProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode < 0)
                return CallNextHookEx(_hHook, nCode, wParam, lParam);

            var msg = (CwpretStruct)Marshal.PtrToStructure(lParam, typeof(CwpretStruct));
            var hook = _hHook;
            if (msg.message != WM_INITDIALOG)
                return CallNextHookEx(hook, nCode, wParam, lParam);

            GetWindowTextLength(msg.hwnd);
            var className = new StringBuilder(10);
            GetClassName(msg.hwnd, className, className.Capacity);
            if (className.ToString() != "#32770")
                return CallNextHookEx(hook, nCode, wParam, lParam);

            _nButton = 0;
            EnumChildWindows(msg.hwnd, EnumProc, IntPtr.Zero);
            if (_nButton != 1)
                return CallNextHookEx(hook, nCode, wParam, lParam);

            var hButton = GetDlgItem(msg.hwnd, MbCancel);
            if (hButton != IntPtr.Zero)
                SetWindowText(hButton, Ok);

            return CallNextHookEx(hook, nCode, wParam, lParam);
        }

        private static bool MessageBoxEnumProc(IntPtr hWnd, IntPtr lParam)
        {
            var className = new StringBuilder(10);
            GetClassName(hWnd, className, className.Capacity);
            if (className.ToString() != "Button")
                return true;

            var ctlId = GetDlgCtrlID(hWnd);
            switch (ctlId)
            {
                case MbOk:
                    SetWindowText(hWnd, Ok);
                    break;
                case MbCancel:
                    SetWindowText(hWnd, Cancel);
                    break;
                case MbAbort:
                    SetWindowText(hWnd, Abort);
                    break;
                case MbRetry:
                    SetWindowText(hWnd, Retry);
                    break;
                case MbIgnore:
                    SetWindowText(hWnd, Ignore);
                    break;
                case MbYes:
                    SetWindowText(hWnd, Yes);
                    break;
                case MbNo:
                    SetWindowText(hWnd, No);
                    break;

            }
            _nButton++;

            return true;
        }
    }
}