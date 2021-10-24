using System;
using System.Windows.Forms;

namespace BTL_LTTQ_QLKhoVLXD
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MessageBoxManager.Register();

            Application.Run(new fLogin());
        }
    }
}
