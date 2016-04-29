using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Data.OleDb;

namespace KPBT.Reports
{
    public partial class SoTKPASub1tt : DevExpress.XtraReports.UI.XtraReport
    {
        public SoTKPASub1tt()
        {
            InitializeComponent();
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            string sql = "Select sum(SL13) as SumofSL13, Sum(SL14) as SumofSL14, Sum(SL15) as SumofSL15," +
               " Sum(SL16) as SumofSL16, Sum(SL17) as SumofSL17, Sum(SL20) as SumofSL20, Sum(SL21) as SumofSL21," +
               " Sum(SL22) as SumofSL22, Sum(SL23) as SumofSL23, Sum(SL24) as SumofSL24" +
               " From TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#";
            OleDbDataReader dr = KPBT.Modules.Connect.TruyVandr(sql);
            while (dr.Read())
            {
                SL13.Text = classdc.dungchung.kieudouble(dr["SumofSL13"].ToString()).ToString("#,#");
                SL14.Text = classdc.dungchung.kieudouble(dr["SumofSL14"].ToString()).ToString("#,#");
                SL15.Text = classdc.dungchung.kieudouble(dr["SumofSL15"].ToString()).ToString("#,#");
                SL16.Text = classdc.dungchung.kieudouble(dr["SumofSL16"].ToString()).ToString("#,#");
                SL17.Text = classdc.dungchung.kieudouble(dr["SumofSL17"].ToString()).ToString("#,#");
                SL20.Text = classdc.dungchung.kieudouble(dr["SumofSL20"].ToString()).ToString("#,#");
                SL21.Text = classdc.dungchung.kieudouble(dr["SumofSL21"].ToString()).ToString("#,#");
                SL22.Text = classdc.dungchung.kieudouble(dr["SumofSL22"].ToString()).ToString("#,#");
                SL23.Text = classdc.dungchung.kieudouble(dr["SumofSL23"].ToString()).ToString("#,#");
                SL24.Text = classdc.dungchung.kieudouble(dr["SumofSL24"].ToString()).ToString("#,#");
            } dr.Close();
        }

    }
}
