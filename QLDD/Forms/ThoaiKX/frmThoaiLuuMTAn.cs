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
    public partial class frmThoaiLuuMTAn : Office2007Form
    {
        public frmThoaiLuuMTAn()
        {
            InitializeComponent();
        }

        private void frmThoaiLuuMTAn_Load(object sender, EventArgs e)
        {
            MtbNgayTD.Text = thongtinketxuat.Default.NTT.ToString();
            MtbNgayTT.Text = thongtinketxuat.Default.NTD.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string sql = "select * From luumta where ngayluu between #" + classdc.dungchung.thaydoi(MtbNgayTT.Text) + "# and #" + classdc.dungchung.thaydoi(MtbNgayTD.Text) + "#";
            DataSet dts = new DataSet();
            Connect.Loadds(dts, sql, "luumta");
            Forms.frmHienThi frm = new Forms.frmHienThi();
            Reports.LuuMTAn rpt = new KPBT.Reports.LuuMTAn();
            rpt.TenDV.Value = thongtinketxuat.Default.tendv.ToString();
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
