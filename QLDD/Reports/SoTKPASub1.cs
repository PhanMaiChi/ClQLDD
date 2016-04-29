using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Data.OleDb;

namespace KPBT.Reports
{
    public partial class SoTKPASub1 : DevExpress.XtraReports.UI.XtraReport
    {
        public SoTKPASub1()
        {
            InitializeComponent();
        }

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                DataTable dt = KPBT.Modules.Connect.TruyVandt("Select distinct NTGS,SL11,SL12,SL18,SL19 From TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#");
                dt.TableName = "TblDC";
                DataSet dts = new DataSet();
                dts.Tables.Add(dt);
                KPBT.Reports.SoTKPASub1tt rpt = (SoTKPASub1tt)xrsTT1.ReportSource;
                rpt.DataSource = dts;
            }
            catch { }
            try
            {
                double p1, p2, l1, l2, g1, g2, b1, b2;
                double sl1 = KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select distinct SL11 from TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "SL11");
                double sl2 = KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select distinct SL18 from TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "SL18");
                NTCongTien.Text = KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select distinct SL12 from TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"),"SL12").ToString("#,#");
                NTCongTien.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                NTCongP.Text = KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select distinct SL13 from TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "SL13").ToString("#,#");
                p1 = KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select distinct SL13 from TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "SL13");
                NTCongP.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                NTCongL.Text = KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select distinct SL14 from TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "SL14").ToString("#,#");
                l1 = KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select distinct SL14 from TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "SL14");
                NTCongL.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                NTCongG.Text = KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select distinct SL15 from TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "SL15").ToString("#,#");
                g1 = KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select distinct SL15 from TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "SL15");
                NTCongG.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                NTCongB1.Text = KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select distinct SL16 from TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "SL16").ToString("#,#");
                b1 = KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select distinct SL16 from TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "SL16");
                NTCongB1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                NTCongCal.Text = KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select distinct SL17 from TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "SL17").ToString("#,#");
                NTCongCal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;

                NTBQTien.Text = (KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select distinct SL12 from TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "SL12") / sl1).ToString("n2");
                NTBQTien.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                NTBQP.Text = (KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select distinct SL13 from TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "SL13") / sl1).ToString("n2");
                NTBQP.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                NTBQL.Text = (KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select distinct SL14 from TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "SL14") / sl1).ToString("n2");
                NTBQL.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                NTBQG.Text = (KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select distinct SL15 from TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "SL15") / sl1).ToString("n2");
                NTBQG.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                NTBQB1.Text = (KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select distinct SL16 from TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "SL16") / sl1).ToString("n2");
                NTBQB1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                NTBQCal.Text = (KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select distinct SL17 from TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "SL17") / sl1).ToString("n2");
                NTBQCal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;

                NTPTP.Text = (100*p1 / (p1 + l1 + g1 + b1)).ToString("n2");
                NTPTG.Text = (100 * g1 / (p1 + l1 + g1 + b1)).ToString("n2");
                NTPTL.Text = (100 * l1 / (p1 + l1 + g1 + b1)).ToString("n2");
                NTPTB1.Text = (100 * b1 / (p1 + l1 + g1 + b1)).ToString("n2");

                MGCongTien.Text = KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select distinct SL19 from TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "SL19").ToString("#,#");
                MGCongTien.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                MGCongP.Text = KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select distinct SL20 from TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "SL20").ToString("#,#");
                p2 = KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select distinct SL20 from TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "SL20");
                MGCongP.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                MGCongL.Text = KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select distinct SL21 from TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "SL21").ToString("#,#");
                l2 = KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select distinct SL21 from TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "SL21");
                MGCongL.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                MGCongG.Text = KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select distinct SL22 from TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "SL22").ToString("#,#");
                g2 = KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select distinct SL22 from TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "SL22");
                MGCongG.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                MGCongB1.Text = KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select distinct SL23 from TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "SL23").ToString("#,#");
                b2 = KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select distinct SL23 from TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "SL23");
                MGCongB1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                MGCongCal.Text = KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select distinct SL24 from TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "SL24").ToString("#,#");
                MGCongCal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;

                MGBQTien.Text = (KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select distinct SL19 from TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "SL19")/sl2).ToString("n2");
                MGBQTien.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                MGBQP.Text = (KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select distinct SL20 from TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "SL20") / sl2).ToString("n2");
                MGBQP.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                MGBQL.Text = (KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select distinct SL21 from TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "SL21") / sl2).ToString("n2");
                MGBQL.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                MGBQG.Text = (KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select distinct SL22 from TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "SL22") / sl2).ToString("n2");
                MGBQG.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                MGBQB1.Text = (KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select distinct SL23 from TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "SL23") / sl2).ToString("n2");
                MGBQB1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                MGBQCal.Text = (KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select distinct SL24 from TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "SL24") / sl2).ToString("n2");
                MGBQCal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;

                MGPTP.Text = (100 * p2 / (p2 + l2 + g2 + b2)).ToString("n2");
                MGPTG.Text = (100 * g2 / (p2 + l2 + g2 + b2)).ToString("n2");
                MGPTL.Text = (100 * l2 / (p2 + l2 + g2 + b2)).ToString("n2");
                MGPTB1.Text = (100 * b2 / (p2 + l2 + g2 + b2)).ToString("n2");
            }
            catch { }
        }

        private void GroupFooter1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            double sang1 = 0, chieu1 = 0, phu1 = 0, sang2 = 0, chieu2 = 0, phu2 = 0, st1 = 0, st2 = 0;
            OleDbDataReader dr = KPBT.Modules.Connect.TruyVandr("Select * From TblDC where NTGS = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#");           
            while (dr.Read())
            {
                sang1 += KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select slxu*nangluong as Cal" +
                        " From dmtp INNER JOIN (nxct INNER JOIN nhxu ON nxct.idnxct = nhxu.idnxct) ON dmtp.matp = nhxu.matp" +
                        " where nhxu.matp = '" + dr["TEN2"].ToString() + "' and nxct.ntnx = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "Cal");
                chieu1 += KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select slxuccnt*nangluong as Cal" +
                        " From dmtp INNER JOIN (nxct INNER JOIN nhxu ON nxct.idnxct = nhxu.idnxct) ON dmtp.matp = nhxu.matp" +
                        " where nhxu.matp = '" + dr["TEN2"].ToString() + "' and nxct.ntnx = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "Cal");
                phu1 += KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select slxubpnt*nangluong as Cal" +
                        " From dmtp INNER JOIN (nxct INNER JOIN nhxu ON nxct.idnxct = nhxu.idnxct) ON dmtp.matp = nhxu.matp" +
                        " where nhxu.matp = '" + dr["TEN2"].ToString() + "' and nxct.ntnx = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "Cal");

                sang2 += KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select slxumg*nangluong as Cal" +
                        " From dmtp INNER JOIN (nxct INNER JOIN nhxu ON nxct.idnxct = nhxu.idnxct) ON dmtp.matp = nhxu.matp" +
                        " where nhxu.matp = '" + dr["TEN2"].ToString() + "' and nxct.ntnx = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "Cal");
                chieu2 += KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select slxuccmg*nangluong as Cal" +
                        " From dmtp INNER JOIN (nxct INNER JOIN nhxu ON nxct.idnxct = nhxu.idnxct) ON dmtp.matp = nhxu.matp" +
                        " where nhxu.matp = '" + dr["TEN2"].ToString() + "' and nxct.ntnx = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "Cal");
                phu2 += KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select slxubpmg*nangluong as Cal" +
                        " From dmtp INNER JOIN (nxct INNER JOIN nhxu ON nxct.idnxct = nhxu.idnxct) ON dmtp.matp = nhxu.matp" +
                        " where nhxu.matp = '" + dr["TEN2"].ToString() + "' and nxct.ntnx = #" + classdc.dungchung.thaydoi(GetCurrentColumnValue("NTGS").ToString()) + "#"), "Cal");
            }
            dr.Close();
            st1 = sang1 + phu1 + chieu1;
            st2 = chieu2 + phu2 + phu2;
            NTBSCL.Text = sang1.ToString("#,#");
            NTBCCL.Text = chieu1.ToString("#,#");
            NTBPCL.Text = phu1.ToString("#,#");

            NTBSPT.Text = (100 * sang1 / (sang1 + phu1 + chieu1)).ToString("n2");
            NTBCPT.Text = (100 * chieu1 / (sang1 + phu1 + chieu1)).ToString("n2");
            NTBPPT.Text = (100 * phu1 / (sang1 + phu1 + chieu1)).ToString("n2");

            MGBSCL.Text = sang2.ToString("#,#");
            MGBCCL.Text = chieu2.ToString("#,#");
            MGBPCL.Text = phu2.ToString("#,#");

            MGBSPT.Text = (100 * sang2 / (sang2 + phu2 + chieu2)).ToString("n2");
            MGBCPT.Text = (100 * chieu2 / (sang2 + phu2 + chieu2)).ToString("n2");
            MGBPPT.Text = (100 * phu2 / (sang2 + phu2 + chieu2)).ToString("n2");
            
        }

        private void GroupFooter1_AfterPrint(object sender, EventArgs e)
        {

        }
    }
}
