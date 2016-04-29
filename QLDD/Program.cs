using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KPBT
{
    static class Program
    {
        public static string openfrm = "";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Settings1.Default.dc.ToString() != "Dc")
            {
                Form frm = new Forms.DanhMuc.frmTaoNamMoicd();
                frm.ShowDialog();
            }
            else
            {
                Application.Run(new Forms.frmmain());
            }
        }
    }
}
