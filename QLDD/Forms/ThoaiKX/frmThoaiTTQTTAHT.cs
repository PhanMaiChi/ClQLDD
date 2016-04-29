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
    public partial class frmThoaiTTQTTAHT : Office2007Form
    {
        public string decimalChar = "";
        public string sang = "";
        public string trua = "";
        public string toi = "";
        public string tongtien = "";
        public frmThoaiTTQTTAHT()
        {
            InitializeComponent();
        }
        private void frmThoaiLuuMTAn_Load(object sender, EventArgs e)
        {
            decimalChar = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            if (decimalChar == ".")
                decimalChar = ",";
            phong();
            cboPhong.Text = "";
        }
        private void phong()
        {
            DataTable dt = Connect.TruyVandt("select tenphong From phong");
            cboPhong.DataSource = dt;
            cboPhong.DisplayMember = "tenphong";
        }
        private void chitiettien()
        {
            OleDbDataReader dr = Connect.TruyVandr("Select Distinct MA,MASANG,MATOI,MUCHT From baoan where Month(ntan) = '" + cboThang.Text + "' and Year(ntan) = '" + cboNam.Text + "'");
            while (dr.Read())
            {
                sang = string.Format("{0:#" + decimalChar + "#}", classdc.dungchung.kieudouble(dr["MASANG"].ToString()));
                trua = string.Format("{0:#" + decimalChar + "#}", classdc.dungchung.kieudouble(dr["MA"].ToString()));
                toi = string.Format("{0:#" + decimalChar + "#}", classdc.dungchung.kieudouble(dr["MATOI"].ToString()));
                tongtien = string.Format("{0:#" + decimalChar + "#}", classdc.dungchung.kieudouble(dr["MUCHT"].ToString()));
            }
            dr.Close();
        }
        private double tienanthang(string thang, string hs)
        {            
            double kq = 0;
            string sql = "Select [BS]*[MASANG] as An, MUCHT" +
                " From baoan where Month(ntan) = '" + cboThang.Text + "' and Year(ntan) = '" + cboNam.Text + "' and mshs = '" + hs + "'";
            OleDbDataReader dr = Connect.TruyVandr(sql);
            while (dr.Read())
            {
                kq = kq + classdc.dungchung.kieudouble(dr["An"].ToString());
            }
            dr.Close();
            return kq;
        }
        private double tienandu(string hs)
         {
             //MessageBox.Show(hs);
             double kq1 = 0;
             double kq2 = 0;
             double kq = 0;
             string sql = "Select [BS]*[MASANG]  as An" +
                 " From baoan where (month(ntan)+ (cint(year(ntan)-cint(" + cboNam.Text + ")))*12) < " + Convert.ToInt32(cboThang.Text) + " and  mshs = '" + hs + "'";
             OleDbDataReader dr = Connect.TruyVandr(sql);
             while (dr.Read())
             {
                 kq1 = kq1 + classdc.dungchung.kieudouble(dr["An"].ToString());
             }
             dr.Close();
             string sql1 = "Select MUCHT,month(ntan) as thang,year(ntan) as nam" +
                 " From baoan where (month(ntan)+ (cint(year(ntan)-cint(" + cboNam.Text + ")))*12) < " + Convert.ToInt32(cboThang.Text) + " and  mshs = '" + hs + "'" +
                 " Group by MUCHT,month(ntan),year(ntan)";
             OleDbDataReader dr1 = Connect.TruyVandr(sql1);
             while (dr1.Read())
             {
                 kq2 = kq2 + classdc.dungchung.kieudouble(dr1["MUCHT"].ToString());
             }
             dr1.Close();
             return kq = kq2 - kq1;
         }
        private double songayan(string hs)
         {
             double kq = 0;
             string sql = "Select ntan From baoan Where Month(ntan) = '" + cboThang.Text + "' and Year(ntan) = '" + cboNam.Text + "' and  mshs = '" + hs + "'";
             OleDbDataReader dr = Connect.TruyVandr(sql);
             while (dr.Read())
             {
                 kq = kq + 1;
             }
             dr.Close();
             return kq;
         }
        private double tienan(string mshs)
        {
            double kq = 0;
            string sql = "Select sotienthu From thutien inner join dmthu on thutien.makhthu = dmthu.makhthu where thang = " + classdc.dungchung.kieudouble(cboThang.Text) + " and thutien.mshs = '" + mshs + "' and dmthu.tenkhoanthu = 'Tiền ăn'";
            OleDbDataReader dr = Connect.TruyVandr(sql);
            while (dr.Read())
            {
                kq += classdc.dungchung.kieudouble(dr["sotienthu"].ToString());
            }
            dr.Close();
            return kq;
        }
        private void appDC()
         {
             string sql = "insert into TblDC (TEN1,TEN2,TEN3) " +
                 " Select tenphong,tenhs,mshs From baoan" +
                 " Where Month(ntan) = '" + cboThang.Text + "' and Year(ntan) = '" + cboNam.Text + "' " +
                 " Group by tenphong,tenhs,mshs" +
                 " Having  " + (cboPhong.Text != "" ? "tenphong = '" + cboPhong.Text + "'" : "tenphong like '%'");
             Connect.ThaoTac(sql);
         }
        private double chamcom( string tuan,string hs)
        {
            double kq = 0;
            string sql = "Select Sum([BC]) + sum([BT]) + sum([BS]) as An From baoan where Month(ntan) = '" + cboThang.Text + "' and Year(ntan) = '" + cboNam.Text + "' and mshs = '" + hs + "' and tuanthu = " + Convert.ToInt32(tuan);
            OleDbDataReader dr = Connect.TruyVandr(sql);
            while (dr.Read())
            {
                kq = kq + classdc.dungchung.kieudouble(dr["An"].ToString());
            }
            dr.Close();
            return kq;
        }
        private void upDC()
        {            
            OleDbDataReader dr = Connect.TruyVandr("select * From TblDC");
            while (dr.Read())
            {
                string sqlup = "Update TblDC set SL1= @SL1,SL3=@SL3,SL4=@SL4,SL2=@SL2 where TEN3 = '" + dr["TEN3"].ToString() + "'";
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = sqlup;
                cmd.Parameters.Add("@SL1", OleDbType.Double).Value = tienandu(dr["TEN3"].ToString());
                cmd.Parameters.Add("@SL3", OleDbType.Double).Value = tienanthang(cboThang.Text, dr["TEN3"].ToString());
                cmd.Parameters.Add("@SL4", OleDbType.Double).Value = songayan(dr["TEN3"].ToString());
                cmd.Parameters.Add("@SL2", OleDbType.Double).Value = tienan(dr["TEN3"].ToString()); 
                Connect.LuuDL(cmd);                
            }
            dr.Close();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cboThang.Text != "" && cboNam.Text != "")
            {
                Connect.ThaoTac("Delete * From TblDC");
                chitiettien();
                appDC();
                upDC();
                DataSet dts = new DataSet();
                Connect.Loadds(dts, "Select * From TblDC", "TblDC");
                Forms.frmHienThi frm = new Forms.frmHienThi();
                Reports.TTQTTAHT rpt = new KPBT.Reports.TTQTTAHT();
                rpt.TenDV.Value = thongtinketxuat.Default.tendv.ToString();
                rpt.DiaDanh.Value = thongtinketxuat.Default.diadanh.ToString();
                rpt.HTHT.Value = thongtinketxuat.Default.ttdv.ToString();                
                rpt.THANG.Value = "Tháng " + cboThang.Text + " Năm " + cboNam.Text;
                rpt.Sang.Value = sang;
                rpt.Trua.Value = trua;
                rpt.Toi.Value = toi;
                rpt.TongTien.Value = tongtien;
                rpt.Phong.Value = cboPhong.Text;
                rpt.DataSource = dts;
                frm.printControl1.PrintingSystem = rpt.PrintingSystem;
                rpt.CreateDocument();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn hãy chọn tháng và năm muốn kết xuất!", "Thông báo");
            }
        }        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmThoaiTTQTTAHT_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }        
    }
}
