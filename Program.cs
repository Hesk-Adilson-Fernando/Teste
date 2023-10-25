using DMZ.UI.UI;
using System;
using System.Windows.Forms;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using Microsoft.Win32;

namespace DMZ.UI
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
            SetDateTimeFormat();
            //Security.UnprotectConnectionString();
            Application.Run(new Login());
        }

        private static void SetDateTimeFormat()
        {
            var rk = Registry.CurrentUser.OpenSubKey(@"Control Panel\International", true);
            if (rk != null)
                rk.SetValue("sTimeFormat", "HH:mm:ss"); // HH for 24hrs, hh for 12 hrs
            var rk2 = Registry.CurrentUser.OpenSubKey(@"Control Panel\International", true);
            if (rk2 != null)
                rk2.SetValue("sDateFormat", "dd/MM/yyyy");
        }
    }
}
