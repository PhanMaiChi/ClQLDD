using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.OleDb;
using DevExpress.XtraReports.Parameters;
using KPBT.Modules;


namespace KPBT.Forms.ThoaiKX
{
    public partial class ThoaiSoCTNhapXuatTon : Office2007Form
    {
        public DataTable dtKQ;
        public ThoaiSoCTNhapXuatTon()
        {
            InitializeComponent();
            //Connect.DelDC();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThoaiSoQTM_Load(object sender, EventArgs e)
        {
            Connect.LoadDL(lumatp, "matp", "tentp", "Select distinct matp, tentp From nhxu Order by tentp");
            dtpNTTu.EditValue = thongtinketxuat.Default.NTT.ToString();
            dtpNTDen.EditValue = thongtinketxuat.Default.NTD.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            KPBT.Reports.rptSoCTNhapXuatTon rpt = new KPBT.Reports.rptSoCTNhapXuatTon();
            frmHienThi frm = new frmHienThi();
            Dataset.dsSoCTNhapXuatTon ds = new Dataset.dsSoCTNhapXuatTon();
            DataTable dtSD = Connect.TruyVandt("Select * From qrSoCTNhapXuatTon Where ntnx < #" + classdc.dungchung.thaydoi(dtpNTTu.Text) + "# and matp Like '" + dcts.GetStr(lumatp.EditValue) + "%'");
            DataTable dtTK = Connect.TruyVandt("Select * From qrSoCTNhapXuatTon Where ntnx Between #" + classdc.dungchung.thaydoi(dtpNTTu.Text) + "# and #"
                                                            + classdc.dungchung.thaydoi(dtpNTDen.Text) + "# and matp Like '" + dcts.GetStr(lumatp.EditValue) + "%'");
            foreach (DataRow row in Connect.TruyVandt("Select * From qrSoCTNhapXuatTon Where ntnx Between #" + classdc.dungchung.thaydoi(dtpNTTu.Text) + "# and #"
                                                            + classdc.dungchung.thaydoi(dtpNTDen.Text) + "# and matp Like '" + dcts.GetStr(lumatp.EditValue) + "%'").Rows)
                ds.qrSoCTNhapXuatTon.ImportRow(row);

            if (ds.qrSoCTNhapXuatTon.Rows.Count > 0)
                foreach (DataRow row in ds.qrSoCTNhapXuatTon.Rows)
                {
                    row["sldunh"] = dcts.TinhToan(dtSD.Select("matp='" + row["matp"] + "'"), "slnh");
                    row["slduxu"] = dcts.TinhToan(dtSD.Select("matp='" + row["matp"] + "'"), "slxu");
                    row["ttdunh"] = dcts.TinhToan(dtSD.Select("matp='" + row["matp"] + "'"), "ttnh");
                    row["ttduxu"] = dcts.TinhToan(dtSD.Select("matp='" + row["matp"] + "'"), "ttxu");
                }
            foreach (DataRow row in dtSD.Rows)
            {
                if (ds.qrSoCTNhapXuatTon.Select("matp='" + row["matp"] + "'").Length == 0)
                {
                    double sldunh = dcts.TinhToan(dtSD.Select("matp='" + row["matp"] + "'"), "slnh");
                    double slduxu = dcts.TinhToan(dtSD.Select("matp='" + row["matp"] + "'"), "slxu");
                    double ttdunh = dcts.TinhToan(dtSD.Select("matp='" + row["matp"] + "'"), "ttnh");
                    double ttduxu = dcts.TinhToan(dtSD.Select("matp='" + row["matp"] + "'"), "ttxu");
                    ds.qrSoCTNhapXuatTon.Rows.Add(DBNull.Value, "", row["matp"], row["tentp"], 0, 0, 0, 0, 0, 0, slduxu, ttduxu, sldunh, ttdunh);
                }
            }
            rpt.tendv.Value = thongtinketxuat.Default.tendv.ToString();
            rpt.tuan.Value = "Tuần: ..... ( Từ ngày " + dtpNTTu.Text + " đến ngày " + dtpNTDen.Text + " )";
            rpt.ntkx.Value = thongtinketxuat.Default.diadanh.ToString() + ", ngày ... tháng ... năm .....";
            rpt.thukho.Value = thongtinketxuat.Default.nlb.ToString();
            rpt.ktoan.Value = thongtinketxuat.Default.ptkt.ToString();
            rpt.ttdv.Value = thongtinketxuat.Default.ttdv.ToString();
            rpt.DataSource = ds;
            frm.printControl1.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
            frm.ShowDialog();
            this.Close();
        }

        private void lumatp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back && (sender as DevExpress.XtraEditors.LookUpEdit).Text.Length == 0)
                SendKeys.Send("^{DEL}");
        }

        private void ThoaiSoCTNhapXuatTon_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }
    }
}
