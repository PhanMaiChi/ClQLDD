using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace KPBT.Reports
{
    public partial class rptdshs : DevExpress.XtraReports.UI.XtraReport
    {
        public rptdshs()
        {
            InitializeComponent();
        }

        private void Detail_AfterPrint(object sender, EventArgs e)
        {
            this.PageHeader.Visible = false;
        }

        private void PageFooter_AfterPrint(object sender, EventArgs e)
        {
            this.PageHeader.Visible = true;
        }

        private void xrTable6_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.PageHeader.Visible = false;
        }

    }
}
