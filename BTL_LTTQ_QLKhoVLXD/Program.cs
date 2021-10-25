using System;
using System.Windows.Forms;
using BTL_LTTQ_QLKhoVLXD.Forms.Login;

namespace BTL_LTTQ_QLKhoVLXD
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MessageBoxManager.Register();

            Application.Run(new fLogin());
        }
    }
}
