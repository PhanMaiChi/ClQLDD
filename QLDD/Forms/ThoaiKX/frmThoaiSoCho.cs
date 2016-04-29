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

namespace KPBT.Forms.ThoaiKX
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
            string sql = "Select Sum([BS]) as An From baoan" +
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
        private double ton()
        {
            double sodc = 0, tienht = 0, tongchi = 0;
            string sql = "Select BS,MASANG From baoan where ntan < #" + classdc.dungchung.thaydoi(MtbNgayTT.Text) + "#";
            OleDbDataReader dr = Connect.TruyVandr(sql);
            while (dr.Read())
            {
                sodc = sodc + classdc.dungchung.kieudouble(dr["MASANG"].ToString()) * classdc.dungchung.kieudouble(dr["BS"].ToString());
            }
            dr.Close();
            OleDbDataReader drht = Connect.TruyVandr("Select thtro,ttnh From  nhxu inner join nxct on nhxu.idnxct = nxct.idnxct where nxct.ntnx < #" + classdc.dungchung.thaydoi(MtbNgayTT.Text) + "#");
            while (drht.Read())
            {
                tienht = classdc.dungchung.kieudouble(drht["thtro"].ToString());
                tongchi = tongchi + classdc.dungchung.kieudouble(drht["ttnh"].ToString());
            }
            drht.Close();
            return sodc + tienht - tongchi;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                string[] st = MtbNgayTT.Text.Split('/');
                Connect.ThaoTac("Delete * From TblDC");
                clsocho.appdc(MtbNgayTT.Text);
                clsocho.updc(MtbNgayTT.Text);
                DataSet dts = new DataSet();
                Connect.Loadds(dts, "Select * From TblDC order by TEN1", "TblDC");
                Forms.frmHienThi frm = new Forms.frmHienThi();
                Reports.SoCHOmn rpt = new KPBT.Reports.SoCHOmn();
                rpt.NTN.Value = "Ngày " + st[0] + " tháng " + st[1] + " năm " + st[2];
                rpt.TenDV.Value = thongtinketxuat.Default.tendv.ToString();
                rpt.HTNN.Value = "";
                rpt.HTNG.Value = "";
                double soxa = 0, mucan = 0, tienht = 0, tongchi = 0;
                string sql = "Select BS,MASANG From baoan where ntan = #" + classdc.dungchung.thaydoi(MtbNgayTT.Text) + "#";
                OleDbDataReader dr = Connect.TruyVandr(sql);
                while (dr.Read())
                {
                    soxa = soxa + classdc.dungchung.kieudouble(dr["BS"].ToString());
                    mucan = classdc.dungchung.kieudouble(dr["MASANG"].ToString());
                }
                dr.Close();
                OleDbDataReader drht = Connect.TruyVandr("Select thtro,ttnh From  nhxu inner join nxct on nhxu.idnxct = nxct.idnxct where nxct.ntnx = #" + classdc.dungchung.thaydoi(MtbNgayTT.Text) + "#");
                while (drht.Read())
                {
                    tienht = classdc.dungchung.kieudouble(drht["thtro"].ToString());
                    tongchi = tongchi + classdc.dungchung.kieudouble(drht["ttnh"].ToString());
                }
                drht.Close();
                rpt.soxa.Value = string.Format("{0:#" + decimalChar + "#}", soxa);
                rpt.mucan.Value = string.Format("{0:#" + decimalChar + "#}", mucan);
                rpt.sotienht.Value = string.Format("{0:#" + decimalChar + "#}", tienht);
                rpt.sotiendc.Value = string.Format("{0:#" + decimalChar + "#}", tienht + soxa * mucan);
                rpt.sochi.Value = string.Format("{0:#" + decimalChar + "#}", tongchi);
                rpt.tonht.Value = string.Format("{0:#" + decimalChar + "#}", ton());
                if (tienht + soxa * mucan + ton() - tongchi >= 0)
                {
                    rpt.sotienthua.Value = string.Format("{0:#" + decimalChar + "#}", tienht + soxa * mucan + ton() - tongchi);
                    rpt.sotienthieu.Value = "0";
                }
                else
                {
                    rpt.sotienthua.Value = "0";
                    rpt.sotienthieu.Value = string.Format("{0:#" + decimalChar + "#}", tienht + soxa * mucan + ton() - tongchi);
                }
                rpt.DataSource = dts;
                frm.printControl1.PrintingSystem = rpt.PrintingSystem;
                rpt.CreateDocument();
                frm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình tạo sổ. Bạn hãy kiểm tra lại", "Thông báo");
            }
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

        private void frmThoaiSoCho_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }
        
    }
}
