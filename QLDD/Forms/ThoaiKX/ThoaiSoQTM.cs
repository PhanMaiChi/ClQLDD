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
    public partial class ThoaiSoQTM : Office2007Form
    {
        public ThoaiSoQTM()
        {
            InitializeComponent();
        }  
        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ThoaiSoQTM_Load(object sender, EventArgs e)
        {

            dtpNTTu.EditValue = thongtinketxuat.Default.NTT.ToString();
            dtpNTDen.EditValue = thongtinketxuat.Default.NTD.ToString();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            Reports.rptSoQTM rpt = new Reports.rptSoQTM();
            frmHienThi frm = new frmHienThi();
            DataTable dtSD = Connect.TruyVandt("Select * From qrSoQuyTM Where ngaygs < #" + DC1.ngaythang(dtpNTTu.Text) + "#");

            Dataset.dsChungTu ds = new Dataset.dsChungTu();
            foreach (DataRow row in Connect.TruyVandt("Select * From qrSoQuyTM Where ploai='Thu' and ngaygs Between #" + DC1.ngaythang(dtpNTTu.Text) + "# and #"
                                                            + DC1.ngaythang(dtpNTDen.Text) + "#").Rows)
                ds.qrSoQuyTM.Rows.Add(row["ngaygs"], "", row["sohieu"], row["noidung"], 0, row["SoTien"], "", 0, row["thang"]);
            foreach (DataRow row in Connect.TruyVandt("Select * From qrSoQuyTM Where ploai='Chi' and ngaygs Between #" + DC1.ngaythang(dtpNTTu.Text) + "# and #"
                                                           + DC1.ngaythang(dtpNTDen.Text) + "#").Rows)
                ds.qrSoQuyTM.Rows.Add(row["ngaygs"], "", "", row["noidung"], row["SoTien"], 0, row["sohieu"], 0, row["thang"]);

            foreach (DataRow row in ds.qrSoQuyTM.Rows)
                row["sodu"] = dcts.TinhToan(dtSD.Select("ploai='Thu'"), "sotien") - dcts.TinhToan(dtSD.Select("ploai='Chi'"), "sotien");
            rpt.Huyen.Value = thongtinketxuat.Default.tendv.ToString();
            rpt.NTNSo.Value = thongtinketxuat.Default.diadanh.ToString() + ", ngày ... tháng ... năm ......";
            rpt.HTNGSo.Value = thongtinketxuat.Default.thuquy.ToString();
            rpt.HTKeTT.Value = thongtinketxuat.Default.ptkt.ToString();
            rpt.HTNK.Value = thongtinketxuat.Default.ttdv.ToString();
            frm.printControl1.PrintingSystem = rpt.PrintingSystem;
            rpt.DataSource = ds;
            rpt.CreateDocument();
            frm.ShowDialog();
            this.Close();
        }

        private void ThoaiSoQTM_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }
    }
}
