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
    public partial class ThoaiDsbachitiet : Office2007Form
    {
        public ThoaiDsbachitiet()
        {
            InitializeComponent();
        }  
        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ThoaiSoQTM_Load(object sender, EventArgs e)
        {

            dtpNTTu.EditValue = "01/01/2014";
            dtpNTDen.EditValue = "31/12/2014";
        }
        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                Reports.Dsbachitietmn rpt = new Reports.Dsbachitietmn();
                frmHienThi frm = new frmHienThi();
                DataSet ds = new DataSet();
                Connect.Loadds(ds, "Select tenphong,Sum(BS) as BS,Sum(BC) as BC,Sum(BT) as BT, ntan From baoan group by tenphong,ntan", "baoan");
                rpt.tendv.Value = thongtinketxuat.Default.tendv.ToString();
                rpt.tenct.Value = thongtinketxuat.Default.tenct.ToString();
                rpt.diadanh.Value = thongtinketxuat.Default.diadanh.ToString() + ", ngay ... thang ... năm ......";
                rpt.nlb.Value = thongtinketxuat.Default.nlb.ToString();
                rpt.ptkt.Value = thongtinketxuat.Default.ptkt.ToString();
                rpt.ttdv.Value = thongtinketxuat.Default.ttdv.ToString();
                rpt.ntkx.Value = "Từ ngày: " + dtpNTTu.Text + "   đến ngày: " + dtpNTDen.Text;
                frm.printControl1.PrintingSystem = rpt.PrintingSystem;
                rpt.DataSource = ds;
                rpt.CreateDocument();
                frm.ShowDialog();
                this.Close();
            }
            catch (Exception loi)
            {
                MessageBox.Show("Lỗi: " + loi + " Bạn hãy kiểm tra lại!", "Thông báo");
            }
        }

        private void ThoaiSoQTM_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }
    }
}
