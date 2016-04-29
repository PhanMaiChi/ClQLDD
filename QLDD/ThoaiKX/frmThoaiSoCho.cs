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
    public partial class frmThoaiSoCho : Office2007Form
    {
        public string decimalChar = "";
        public frmThoaiSoCho()
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
                "Select nhxu.chokho,nhxu.tentp,nhxu.donvitinh,nhxu.slnh,nhxu.dongia,nhxu.dongia* nhxu.slnh as TT" +
                " From nhxu inner join nxct on nhxu.idnxct = nxct.idnxct" +
                " where nxct.ntnx = #" + classdc.dungchung.thaydoi(MtbNgayTT.Text) + "#";
            Connect.ThaoTac(sql);      
        }
        private void updc()
        {            
            OleDbDataReader dr = Connect.TruyVandr("select * From TblDC");
            while (dr.Read())
            {
                string sqlup = "Update TblDC set SL4=@SL4 where ID = " + Convert.ToInt64(dr["ID"].ToString());
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = sqlup;
                cmd.Parameters.Add("@SL4", OleDbType.Double).Value = tongtien(dr["TEN1"].ToString());
                Connect.LuuDL(cmd);
            }
            dr.Close();
        }
        private double xuatanS()
        {
            double kq = 0;
            string sql = "Select Sum([BC]) as An From baoan" +
            " where ntan = #" + classdc.dungchung.thaydoi(MtbNgayTT.Text) + "#";
            OleDbDataReader dr = Connect.TruyVandr(sql);
            while (dr.Read())
            {
                kq = kq + classdc.dungchung.kieudouble(dr["An"].ToString());
            }
            dr.Close();
            return kq;
        }
        private double xuatanT()
        {
            double kq = 0;
            string sql = "Select Sum([BT]) as An From baoan" +
            " where ntan = #" + classdc.dungchung.thaydoi(MtbNgayTT.Text) + "#";
            OleDbDataReader dr = Connect.TruyVandr(sql);
            while (dr.Read())
            {
                kq = kq + classdc.dungchung.kieudouble(dr["An"].ToString());
            }
            dr.Close();
            return kq;
        }
        private double xuatanC()
        {
            double kq = 0;
            string sql = "Select Sum([BC]) as An From baoan" +
            " where ntan = #" + classdc.dungchung.thaydoi(MtbNgayTT.Text) + "#";
            OleDbDataReader dr = Connect.TruyVandr(sql);
            while (dr.Read())
            {
                kq = kq + classdc.dungchung.kieudouble(dr["An"].ToString());
            }
            dr.Close();
            return kq;
        }
        private double mucan()
        {
            double kq = 0;
            string sql = "Select distinct MA From baoan" +
            " where ntan = #" + classdc.dungchung.thaydoi(MtbNgayTT.Text) + "#";
            OleDbDataReader dr = Connect.TruyVandr(sql);
            while (dr.Read())
            {
                kq = classdc.dungchung.kieudouble(dr["MA"].ToString());
            }
            dr.Close();
            return kq;
        }
        private double tienchi(string chokho)
        {
            double kq = 0;
            string sql = "Select ttxu From  nhxu inner join nxct on nhxu.idnxct = nxct.idnxct" +
            " where nxct.ntnx = #" + classdc.dungchung.thaydoi(MtbNgayTT.Text) + "#";
            OleDbDataReader dr = Connect.TruyVandr(sql);
            while (dr.Read())
            {
                kq = kq + classdc.dungchung.kieudouble(dr["ttxu"].ToString());
            }
            dr.Close();
            return kq;
        }
        private double tongtien(string chokho)
        {
            double kq = 0;
            string sql = "Select nhxu.dongia* nhxu.slnh as TT From  nhxu inner join nxct on nhxu.idnxct = nxct.idnxct" +
            " where nhxu.chokho = '" + chokho + "' and nxct.ntnx = #" + classdc.dungchung.thaydoi(MtbNgayTT.Text) + "#";
            OleDbDataReader dr = Connect.TruyVandr(sql);
            while (dr.Read())
            {
                kq = kq + classdc.dungchung.kieudouble(dr["TT"].ToString());
            }
            dr.Close();
            return kq;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            string[] st = MtbNgayTT.Text.Split('/');
            Connect.ThaoTac("Delete * From TblDC");
            appdc();
            updc();
            DataSet dts = new DataSet();
            Connect.Loadds(dts, "Select * From TblDC", "TblDC");
            Forms.frmHienThi frm = new Forms.frmHienThi();
            Reports.SoCHO rpt = new KPBT.Reports.SoCHO();
            rpt.NTN.Value = "Ngày " + st[0] + " tháng " + st[1] + " năm " + st[2];
            rpt.TenDV.Value = Thongtinketxuat.Default.TenDV.ToString();
            rpt.SoXAn.Value = "Số xuất ăn: " + string.Format("{0:#" + decimalChar + "#}", (xuatanS() + xuatanT() + xuatanC()));
            rpt.SoXuat.Value = xuatanS() + xuatanT() + xuatanC();
            rpt.SoDuDN.Value = "";
            rpt.MuAn.Value = mucan();
            rpt.SoDChi.Value = (xuatanS() + xuatanT() + xuatanC()) * mucan();
            rpt.TBSang.Value = string.Format("{0:#" + decimalChar + "#}",xuatanS() * mucan());
            rpt.TBTrua.Value = string.Format("{0:#" + decimalChar + "#}",xuatanT() * mucan());
            rpt.TBToi.Value = string.Format("{0:#" + decimalChar + "#}",xuatanC() * mucan());
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
