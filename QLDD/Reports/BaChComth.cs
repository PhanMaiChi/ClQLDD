using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace KPBT.Reports
{
    public partial class BaChComth : DevExpress.XtraReports.UI.XtraReport
    {
        public BaChComth()
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

    }
}
