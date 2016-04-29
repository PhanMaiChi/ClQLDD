using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace KPBT.Reports
{
    public partial class SoTKPASubKK : DevExpress.XtraReports.UI.XtraReport
    {
        public SoTKPASubKK()
        {
            InitializeComponent();
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {                
                double kq1 = KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select nxct.*,nhxu.* From nxct INNER JOIN nhxu ON nxct.idnxct = nhxu.idnxct where nhxu.tentp = '" + GetCurrentColumnValue("TEN1") + "' and nxct.ntnx <= (SELECT Max(NTGS) AS MaxOfNTGS FROM TblDC)"), "slnh");
                double kq2 = KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select nhxu.slxu+nhxu.slxuccnt+nhxu.slxubpnt+nhxu.slxumg+nhxu.slxuccmg+nhxu.slxubpmg as slxu From nxct INNER JOIN nhxu ON nxct.idnxct = nhxu.idnxct where nhxu.tentp = '" + GetCurrentColumnValue("TEN1") + "' and nxct.ntnx <= (SELECT Max(NTGS) AS MaxOfNTGS FROM TblDC)"), "slxu");
                xrtSLTon.Text = (kq1 - kq2).ToString("#,#");
                xrtSLTon.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            }
            catch { }
        }

        private void ReportFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            double kq1 = KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select nxct.*,nhxu.* From nxct INNER JOIN nhxu ON nxct.idnxct = nhxu.idnxct where  nxct.ntnx <= (SELECT Max(NTGS) AS MaxOfNTGS FROM TblDC)"), "ttnh");
            double kq2 = KPBT.Modules.Connect.doubltt(KPBT.Modules.Connect.TruyVandr("Select nhxu.ttxu + nhxu.ttxumg as ttxu  From nxct INNER JOIN nhxu ON nxct.idnxct = nhxu.idnxct where  nxct.ntnx <= (SELECT Max(NTGS) AS MaxOfNTGS FROM TblDC)"), "ttxu");
            double kq = kq1 - kq2;
            xrtDocSoTien.Text = "Trị giá hàng tồn kho (Thành tiền): " + classdc.dungchung.So_chu(kq);
            xrtDocSoTien.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        }
    }
}
