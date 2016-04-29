using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Data.OleDb;

namespace KPBT.Reports
{
    public partial class SoTKPA : DevExpress.XtraReports.UI.XtraReport
    {
        double sba = 0, stmangsang = 0, tcduocchi = 0, stdachi = 0, stthuathieu = 0, sthotro = 0;
        public SoTKPA()
        {
            InitializeComponent();
        }

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
            //System.Windows.Forms.MessageBox.Show(GetCurrentColumnValue("NTGS").ToString());
            //string sql = "Select * From TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#";
                DataTable dt = KPBT.Modules.Connect.TruyVandt("Select * From TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#");
                dt.TableName = "TblDC";
                DataSet dts = new DataSet();
                dts.Tables.Add(dt);
                KPBT.Reports.SoTKPASubtt rpt = (SoTKPASubtt)xrsTT.ReportSource;
                rpt.DataSource = dts;
            }
            catch { }
            try
            {
                OleDbDataReader dr = KPBT.Modules.Connect.TruyVandr("Select distinct SL25 From TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#");
                while (dr.Read())
                {
                    xrtSoBuaAn.Text = dr["SL25"].ToString();
                    sba = classdc.dungchung.kieudouble(dr["SL25"].ToString());
                }
                dr.Close();
            }
            catch { }
        }

        private void GroupFooter1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {                
                DataTable dt = KPBT.Modules.Connect.TruyVandt("Select * From TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#");
                dt.TableName = "TblDC";
                DataSet dts = new DataSet();
                dts.Tables.Add(dt);
                KPBT.Reports.SoTKPASub1 rpt = (SoTKPASub1)xrsSub.ReportSource;
                rpt.DataSource = dts;
            }
            catch { }
            try
            {
                tcduocchi = KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select MA*BS as TienAn From baoan where ntan =#" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "TienAn");
                try
                {
                    OleDbDataReader dr = KPBT.Modules.Connect.TruyVandr("Select SL8 From TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#");
                    while (dr.Read())
                    {                        
                        stdachi += classdc.dungchung.kieudouble(dr["SL8"].ToString());
                    }
                    dr.Close();
                }
                catch { }
                try
                {
                    double kq1 = KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select MA*BS as TienAn From baoan where ntan <#" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "TienAn");
                    double kq2 = KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select nhxu.ttxu + nhxu.ttxumg as ttxu  From nxct INNER JOIN nhxu ON nxct.idnxct = nhxu.idnxct where nxct.ntnx < #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "ttxu");
                    stmangsang = kq1 - kq2;
                }
                catch { }
                try
                {
                    sthotro = KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select chibosung from nxct where ntnx = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "chibosung");
                }
                catch { }
                stthuathieu = stmangsang + tcduocchi  + sthotro - stdachi;
             }
            catch { }
            xrtMangSang.Text = stmangsang > 0 ? "(+) " + stmangsang.ToString("#,#") : stmangsang < 0 ? "(-) " + Math.Abs(stmangsang).ToString("#,#") : "";
            xrtTieuChuanChi.Text = tcduocchi.ToString("#,#");
            xrtDaChi.Text = stdachi.ToString("#,#");
            xrtTienHoTro.Text = sthotro.ToString("#,#");
            xrtThuaThieu.Text = (stthuathieu > 0 ? "(+) " + stthuathieu.ToString("#,#") : stthuathieu < 0 ? "(-) " + Math.Abs(stthuathieu).ToString("#,#") : "");
            sba = stmangsang = tcduocchi = stdachi = stthuathieu = 0;
        }

        private void ReportFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                DataTable dt = KPBT.Modules.Connect.TruyVandt("Select distinct TEN1,TEN2 From TblDC");
                dt.TableName = "TblDC";
                DataSet dts = new DataSet();
                dts.Tables.Add(dt);
                KPBT.Reports.SoTKPASubKK rpt = (SoTKPASubKK)xrsKK.ReportSource;
                rpt.DataSource = dts;
            }
            catch { }
        }
    }
}

