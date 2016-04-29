using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace KPBT.Reports
{
    public partial class TTQTTAHTcu : DevExpress.XtraReports.UI.XtraReport
    {
        public int a = 0;
        public TTQTTAHTcu()
        {
            InitializeComponent();
        }       
        private void ReportHeader_AfterPrint(object sender, EventArgs e)
        {
            GroupHeader1.PageBreak = PageBreak.None;
            a = 1;
        }       
        private void GroupFooter1_AfterPrint(object sender, EventArgs e)
        {
            if (a == 1)
                GroupHeader1.PageBreak = PageBreak.BeforeBand;
        }

        private void ReportFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            double kq = 0;
            System.Data.OleDb.OleDbDataReader dr = KPBT.Modules.Connect.TruyVandr("Select distinct TEN1 From TblDC");
            if(dr != null)
            {
                while (dr.Read())
                {
                    kq += 1;
                }
                dr.Close();
            }
            if (kq == 1)
            {
                xrTblTC.Visible = false;
            }
        }
    }
}
