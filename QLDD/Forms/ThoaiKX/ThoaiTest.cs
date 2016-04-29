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
    public partial class ThoaiTest : Office2007Form
    {
        DataTable dt = new DataTable();
        Dataset.dstheodoisk ds = new Dataset.dstheodoisk();
        public ThoaiTest()
        {
            InitializeComponent();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ThoaiSoQTM_Load(object sender, EventArgs e)
        {
            Connect.LoadDL(Luhocsinh, "mshs", "tenhs", "Select * From hocsinh");
            dtpNTTu.EditValue = DC1.ngaythang(thongtinketxuat.Default.NTT.ToString());
            dtpNTDen.EditValue = DC1.ngaythang(thongtinketxuat.Default.NTD.ToString());
            if (DC1.tenhs != "")
                Luhocsinh.EditValue = DC1.tenhs;
        }
        private void inserttbl()
        {
            foreach (DataRow row in Connect.TruyVandt("Select theodoisk.*, hocsinh.gths From theodoisk inner join hocsinh on theodoisk.mahocsinh = hocsinh.mshs" +
                " Where mahocsinh = '" + Connect.GetStr(Luhocsinh.EditValue) + "' and ngaydanhgia Between #" + DC1.ngaythang(dtpNTTu.Text) + "# and #"
                                                            + DC1.ngaythang(dtpNTDen.Text) + "#").Rows)
                ds.theodoisk.Rows.Add(row["ngaydanhgia"], row["mahocsinh"], row["sothangtuoi"], row["cannang"], row["chieucao"], row["danhgia"], row["gths"]);
        }
        private void updatetbl()
        {
            foreach (DataRow item in ds.theodoisk.Rows)
            {
                item["chieucaochuan"] = dcts.LayGT(Connect.TruyVandt("Select chieucaochuan From tblchiso where thang = " + classdc.dungchung.kieudouble(item["sothangtuoi"].ToString()) + " and gioitinh = '" + item["gioitinh"].ToString() + "'").Select(), "chieucaochuan");
                item["cannangchuan"] = dcts.LayGT(Connect.TruyVandt("Select cannangchuan From tblchiso where thang = " + classdc.dungchung.kieudouble(item["sothangtuoi"].ToString()) + " and gioitinh = '" + item["gioitinh"].ToString() + "'").Select(), "chieucaochuan");
            }
        }
        private string danhgia()
        {
            string kq="";
            string sql = "Select * From theodoisk where ngaydanhgia <= #" + DC1.ngaythang(dtpNTDen.Text) + "# and mahocsinh = '" + Connect.GetStr(Luhocsinh.EditValue) + "' and sothangtuoi = (Select Max(sothangtuoi) from theodoisk where ngaydanhgia <= #" + DC1.ngaythang(dtpNTDen.Text) + "# and mahocsinh = '" + Connect.GetStr(Luhocsinh.EditValue) + "')";
            OleDbDataReader dr = Connect.TruyVandr("Select * From theodoisk where ngaydanhgia <= #" + DC1.ngaythang(dtpNTDen.Text) + "# and mahocsinh = '" + Connect.GetStr(Luhocsinh.EditValue) + "' and sothangtuoi = (Select Max(sothangtuoi) from theodoisk where ngaydanhgia <= #" + DC1.ngaythang(dtpNTDen.Text) + "# and mahocsinh = '" + Connect.GetStr(Luhocsinh.EditValue) + "')");
            while (dr.Read())
            {
                if (dr["danhgia"].ToString() == "Rất gầy")
                    kq = "Bé nhà bạn đang ở tình trạng rất gầy. Bạn phải cải thiện chế độ ăn uống, dinh dưỡng cho bé.";
                if (dr["danhgia"].ToString() == "Gầy")
                    kq = "Bé nhà bạn đang ở tình trạng gầy. Bạn phải cải thiện chế độ ăn uống, dinh dưỡng cho bé.";
                if (dr["danhgia"].ToString() == "Bình thường")
                    kq = "Bé nhà bạn đang ở tình trạng bình thường. Bạn phải hãy giữ chế độ ăn uống, dinh dưỡng cho bé.";
                if (dr["danhgia"].ToString() == "Thừa cân")
                    kq = "Bé nhà bạn đang ở tình trạng thừa cân. Bạn phải điều chỉnh lại chế độ ăn uống, dinh dưỡng cho bé.";
                if (dr["danhgia"].ToString() == "Béo phì")
                    kq = "Bé nhà bạn đang ở tình trạng béo phì. Bạn phải điều chỉnh lại chế dộ ăn uống, dinh dưỡng cho bé.";
            }
            dr.Close();
            return kq;
        }
        private void button16_Click(object sender, EventArgs e)
        {
            try
            {                
                if (Connect.GetStr(Luhocsinh.EditValue) == "")
                {
                    MessageBox.Show("Bạn cần phải chọn học sinh cần tạo!", "Thông báo");
                }
                else
                {
                    foreach (DataRow row in Connect.TruyVandt("Select theodoisk.*, hocsinh.gths From theodoisk inner join hocsinh on theodoisk.mahocsinh = hocsinh.mshs" +
                        " Where mahocsinh = '" + Connect.GetStr(Luhocsinh.EditValue) + "' and ngaydanhgia Between #" + DC1.ngaythang(dtpNTTu.Text) + "# and #"
                                                                    + DC1.ngaythang(dtpNTDen.Text) + "#").Rows)
                        ds.theodoisk.Rows.Add(row["ngaydanhgia"], row["mahocsinh"], row["sothangtuoi"], row["cannang"], row["chieucao"], row["danhgia"], row["gths"]);
                    foreach (DataRow item in ds.theodoisk.Rows)
                    {
                        item["chieucaochuan"] = dcts.LayGT(Connect.TruyVandt("Select chieucaochuan From tblchiso where thang = " + classdc.dungchung.kieudouble(item["sothangtuoi"].ToString()) + " and gioitinh = '" + item["gioitinh"].ToString() + "'").Select(), "chieucaochuan");
                        item["cannangchuan"] = dcts.LayGT(Connect.TruyVandt("Select cannangchuan From tblchiso where thang = " + classdc.dungchung.kieudouble(item["sothangtuoi"].ToString()) + " and gioitinh = '" + item["gioitinh"].ToString() + "'").Select(), "cannangchuan");
                    }
                    //Connect.Loadds(dts, "Select * From theodoisk where mahocsinh = '" + Luhocsinh.EditValue.ToString() + "'", "theodoisk");
                    Reports.Testchart rpt = new Reports.Testchart();
                    frmHienThi frm = new frmHienThi();
                    rpt.TenDV.Value = thongtinketxuat.Default.tendv.ToString();
                    rpt.TenHS.Value = Luhocsinh.Text;
                    rpt.Lop.Value = Connect.LayGT("Select tenphong from hocsinh where mshs = '" + Connect.GetStr(Luhocsinh.EditValue) + "'", "tenphong");
                    rpt.NgaySinh.Value = Convert.ToDateTime(Connect.LayGT("Select ntns from hocsinh where mshs = '" + Connect.GetStr(Luhocsinh.EditValue) + "'", "ntns"));
                    rpt.TungayDenngay.Value = "Ngày đánh giá từ ngày " + dtpNTTu.Text + " đến ngày " + dtpNTDen.Text;
                    rpt.Ketluan.Value = danhgia();
                    frm.printControl1.PrintingSystem = rpt.PrintingSystem;
                    rpt.DataSource = ds;
                    rpt.CreateDocument();
                    frm.ShowDialog();
                    this.Close();
                }
            }
            catch {
                MessageBox.Show("Có lỗi trong quá trình tạo báo cáo. Bạn hãy kiểm tra lại!", "Thông báo");
            }
        }

        private void ThoaiSoQTM_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }
    }
}
