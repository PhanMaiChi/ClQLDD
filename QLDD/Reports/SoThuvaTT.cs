using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using KPBT.Modules;

namespace KPBT.Reports
{
    public partial class SoThuvaTT : DevExpress.XtraReports.UI.XtraReport
    {
        //double dslTon, dttTon, slDu, ttDu;
        double rec = 0;
        double kt1, kt2, kt3, kt4, kt5, kt6, tongcong,tong;
        public SoThuvaTT()
        {
            InitializeComponent();
        }

        private void Detail_AfterPrint(object sender, EventArgs e)
        {
            rec = 1;
            this.PageHeader.Visible = false;
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                kt1 = dcts.GetDbl(GetCurrentColumnValue("SL3"));
            }
            catch { }
            try
            {
                kt2 = dcts.GetDbl(GetCurrentColumnValue("SL4"));
            }
            catch { }
            try
            {
                kt3 = dcts.GetDbl(GetCurrentColumnValue("SL5"));
            }
            catch { }
            try
            {
                kt4 = dcts.GetDbl(GetCurrentColumnValue("SL6"));
            }
            catch { }
            try
            {
                kt5 = dcts.GetDbl(GetCurrentColumnValue("SL7"));
            }
            catch { }
            try
            {
                kt6 = dcts.GetDbl(GetCurrentColumnValue("SL8"));
            }
            catch { }
            tongcong = kt1 + kt2 + kt3 + kt4 + kt5 + kt6;
            tong += tongcong;
            xrtTongCong.Text = tongcong.ToString("#,#");
            tongcong = kt1 = kt2 = kt3 = kt4 = kt5 = kt6 = 0;
        }        

        private void NT_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (GetPreviousColumnValue("ngaythu").ToString() == GetCurrentColumnValue("ngaythu").ToString() && rec != 0)
            {
                NT.Text = "";
            }
        }

        private void PageFooter_AfterPrint(object sender, EventArgs e)
        {
            this.PageHeader.Visible = true;
        }

        private void GroupFooter1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrtTong.Text = tong.ToString("#,#");
        }

        private void GroupFooter1_AfterPrint(object sender, EventArgs e)
        {
            tong = 0;
        }        
    }
}
