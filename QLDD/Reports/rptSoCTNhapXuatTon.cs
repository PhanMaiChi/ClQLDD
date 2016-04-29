using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using KPBT.Modules;

namespace KPBT.Reports
{
    public partial class rptSoCTNhapXuatTon : DevExpress.XtraReports.UI.XtraReport
    {
        //double dslTon, dttTon, slDu, ttDu;
        double slNhap, slXuat, ttNhap, ttXuat;
        public rptSoCTNhapXuatTon()
        {
            InitializeComponent();
        }

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {            
            slNhap = slXuat = ttNhap = ttXuat = 0;
            //dslTon = dttTon = 0;

            slNhap = dcts.GetDbl(GetCurrentColumnValue("sldunh"));
            slXuat = dcts.GetDbl(GetCurrentColumnValue("slduxu"));

            ttNhap = dcts.GetDbl(GetCurrentColumnValue("ttdunh"));
            ttXuat = dcts.GetDbl(GetCurrentColumnValue("ttduxu"));

            //slDu = slNhap - slXuat;
            //ttDu = ttNhap - ttXuat;
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            slNhap += dcts.GetDbl(GetCurrentColumnValue("slnh"));
            slXuat += dcts.GetDbl(GetCurrentColumnValue("slxu"));

            ttNhap += dcts.GetDbl(GetCurrentColumnValue("ttnh"));
            ttXuat += dcts.GetDbl(GetCurrentColumnValue("ttxu"));

            //dslTon += (slNhap - slXuat);
            //dttTon += (ttNhap - ttXuat);

            xrslTon.Text = (slNhap - slXuat).ToString("#,0.#");
            xrttTon.Text = (ttNhap - ttXuat).ToString("#,#");
        }

        private void GroupFooter1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //xrslNhapLK.Text = slNhap.ToString("#,0.#");
            xrttNhapLK.Text = ttNhap.ToString("#,#");

            //xrslXuatLK.Text = slXuat.ToString("#,0.#");
            xrttXuatLK.Text = ttXuat.ToString("#,#");

            //xrslTonCK.Text = (slNhap - slXuat).ToString("#,0.#");
            xrttTonCK.Text = (ttNhap - ttXuat).ToString("#,#");
        }

    }
}
