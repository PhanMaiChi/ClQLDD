using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using KPBT.Modules;

namespace KPBT.Reports
{
    public partial class rptSoQTM : DevExpress.XtraReports.UI.XtraReport
    {
        //Double Ton =0, TonHT=0;
        Double Thu = 0;//,ThuTC=0;
        Double Chi = 0;//, ChiTC = 0;
        public rptSoQTM()
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
            xrTon.Text = (dcts.GetDbl(GetCurrentColumnValue("sodu")) + Thu - Chi
                + dcts.GetDbl(GetCurrentColumnValue("sotienthu")) - dcts.GetDbl(GetCurrentColumnValue("sotienchi"))).ToString("#,#");          
        }

        private void ReportFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrTonCK.Text = (dcts.GetDbl(GetCurrentColumnValue("sodu")) + Thu - Chi).ToString("#,#");
        }
       
    }
}
