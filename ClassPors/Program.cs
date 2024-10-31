using System;
using System.Windows.Forms;

namespace ClassPors
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

            //Set button text from resources
            MessageBoxManager.OK = "باشه";
            MessageBoxManager.Cancel = "انصراف";
            MessageBoxManager.Retry = "سعی مجدد";
            MessageBoxManager.Ignore = "نادیده بگیر";
            MessageBoxManager.Abort = "لغو";
            MessageBoxManager.Yes = "بلی";
            MessageBoxManager.No = "خیر";

            //Register manager
            MessageBoxManager.Register();

            //Application.Run(new frmInput());
            Application.Run(new frmMain());
        }

    }
}
