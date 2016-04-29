using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Data.OleDb;

namespace KPBT.Reports
{
    public partial class SoTKPASubtt : DevExpress.XtraReports.UI.XtraReport
    {
        public SoTKPASubtt()
        {
            InitializeComponent();
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           
        }

    }
}
