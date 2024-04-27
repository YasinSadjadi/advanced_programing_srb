using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ap_proj.forms_for_loging_in;

namespace dev_express_test
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //using (var db = new advanced_programing_projrct.DatabaseContext())
            //{
            //    db.Database.EnsureDeleted();
            //}
            Application.Run(new registerForm());
        }
    }
}
