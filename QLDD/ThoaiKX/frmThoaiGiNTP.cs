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
using System.Data.OleDb;
using System.Threading;

namespace KPBT.ThoaiKX
{
    public partial class frmThoaiGiNTP : Office2007Form
    {
        public string decimalChar = "";
        public frmThoaiGiNTP()
        {
            InitializeComponent();
        }

        private void frmThoaiLuuMTAn_Load(object sender, EventArgs e)
        {
            decimalChar = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            if (decimalChar == ".")
                decimalChar = ",";
            MtbNgayTT.Text = "";
        }
        private void appdc()
        {
            string sql = "insert into TblDC (TEN1,TEN2,TEN3,SL1,SL2,SL3) " +
                "Select nhxu.tentp,nhxu.chatluong,nhxu.donvitinh,nhxu.slnh,nhxu.dongia,nhxu.ttnh" +
                " From nhxu inner join nxct on nhxu.idnxct = nxct.idnxct" +
                " where nxct.ntnx = #" + classdc.dungchung.thaydoi(MtbNgayTT.Text) + "#";
            Connect.ThaoTac(sql);      
        }        
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            string[] st = MtbNgayTT.Text.Split('/');
            Connect.ThaoTac("Delete * From TblDC");
            appdc();            
            DataSet dts = new DataSet();
            Connect.Loadds(dts, "Select * From TblDC", "TblDC");
            Forms.frmHienThi frm = new Forms.frmHienThi();
            Reports.GiNTP rpt = new Reports.GiNTP();
            rpt.NTN.Value = "Ngày " + st[0] + " tháng " + st[1] + " năm " + st[2];
            rpt.TenDV.Value = Thongtinketxuat.Default.TenDV.ToString();            
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
