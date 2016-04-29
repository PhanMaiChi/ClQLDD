using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Office;
using DevComponents.DotNetBar;
using KPBT.Modules;

namespace KPBT.Forms.ThoaiKX
{
    public partial class frmThoaiBcTDSKHS : Office2007Form
    {
        public frmThoaiBcTDSKHS()
        {
            InitializeComponent();
        }

        private void frmThoaiLuuMTAn_Load(object sender, EventArgs e)
        {
            MtbNgayTD.Text = thongtinketxuat.Default.NTD.ToString();
            MtbNgayTT.Text = thongtinketxuat.Default.NTT.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Reports.BcTDSKHS rpt = new Reports.BcTDSKHS();
            frmHienThi frm = new frmHienThi();
            DataTable dtTT = Connect.TruyVandt("SELECT hocsinh.tenhs, hocsinh.gths, hocsinh.ntns, hocsinh.tenphong,"+
                " theodoisk.sothangtuoi, theodoisk.cannang, theodoisk.chieucao, theodoisk.ngaydanhgia, theodoisk.danhgia"+
                " FROM hocsinh INNER JOIN theodoisk ON hocsinh.mshs = theodoisk.mahocsinh"+
                " Where theodoisk.ngaydanhgia between #" + DC1.ngaythang(MtbNgayTT.Text) + "# and #" + DC1.ngaythang(MtbNgayTD.Text) + "#");
            Dataset.dsTblDC dts = new Dataset.dsTblDC();
            foreach (DataRow item in dtTT.Rows)
            {
                dts.TblDC.Rows.Add(null, item["ngaydanhgia"], item["ntns"], item["tenhs"], item["gths"], "", item["tenphong"], item["danhgia"], "", "", "", "" +
                    "", "", "", "", "", "", "", "", "", "", "", "", item["sothangtuoi"], item["cannang"], item["chieucao"]);
            }
            rpt.NTT.Value = "Từ ngày " + MtbNgayTT.Text + " đến ngày " + MtbNgayTD.Text;
            //rpt.TenDV.Value = thongtinketxuat.Default.tendv.ToString();
            rpt.DataSource = dts;
            frm.printControl1.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
            frm.ShowDialog();
            this.Close();
        }

        private void MktNgayTT_Leave(object sender, EventArgs e)
        {
            try
            {
                MtbNgayTT.Text = DC1.ngaythang(MtbNgayTT.Text);
            }
            catch
            {
                MtbNgayTT.Text = string.Format("{0:dd/MM/yyyy}", DateTime.Today);
            }
        }

        private void MtbNgayTD_Leave(object sender, EventArgs e)
        {
            try
            {
                MtbNgayTD.Text = DC1.ngaythang(MtbNgayTD.Text);
            }
            catch
            {
                MtbNgayTD.Text = string.Format("{0:dd/MM/yyyy}", DateTime.Today);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThoaiLuuMTAn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }
        
    }
}
