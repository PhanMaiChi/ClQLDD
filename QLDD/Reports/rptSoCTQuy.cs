using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using KPBT.Modules;

namespace KPBT.Reports
{
    public partial class rptSoCTQuy : DevExpress.XtraReports.UI.XtraReport
    {       
        Double Thu = 0;//,Ton=0;
        Double Chi = 0;
        public rptSoCTQuy()
        {
            InitializeComponent();
        }


        private void Detail_AfterPrint(object sender, EventArgs e)
        {
            Thu += dcts.GetDbl(GetCurrentColumnValue("sotienthu"));
            Chi += dcts.GetDbl(GetCurrentColumnValue("sotienchi"));         
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //xrTon.Text = ((double)TonDK.Value + ThuTC - ChiTC +
            //   double.Parse(GetCurrentColumnValue("SL1") != null ? GetCurrentColumnValue("SL1").ToString() : "0")
            //   - double.Parse(GetCurrentColumnValue("SL2") != null ? GetCurrentColumnValue("SL2").ToString() : "0")).ToString("#,#");
            
        }

       
        private void ReportFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrSD.Text = (Thu - Chi + dcts.GetDbl(GetCurrentColumnValue("sodu"))).ToString("#,#");
        }
        
    }
}
