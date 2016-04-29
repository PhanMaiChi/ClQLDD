using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace KPBT.Reports
{
    public partial class BaChCom : DevExpress.XtraReports.UI.XtraReport
    {
        public BaChCom()
        {
            InitializeComponent();
        }

        private void PageFooter_AfterPrint(object sender, EventArgs e)
        {
            this.PageHeader.Visible = true;
        }

        private void xrTable2_AfterPrint(object sender, EventArgs e)
        {
            
        }

        private void ReportFooter_AfterPrint(object sender, EventArgs e)
        {
            
        }

        private void Detail_AfterPrint(object sender, EventArgs e)
        {
            this.PageHeader.Visible = false;
        }

        private void xrTable5_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (GetCurrentColumnValue("SL22").ToString() == "0")
                xrTable5.Visible = false;
        }

    }
}
