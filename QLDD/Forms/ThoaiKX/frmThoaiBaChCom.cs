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

namespace KPBT.Forms.ThoaiKX
{
    public partial class frmThoaiBaChCom : Office2007Form
    {
        public frmThoaiBaChCom()
        {
            InitializeComponent();
        }

        private void frmThoaiLuuMTAn_Load(object sender, EventArgs e)
        {
            phong();
            cboPhong.Text = "";
            cboThang.Text = "";
            cboTuan.Text = "";
            cboNam.Text = "";
        }
        private void phong()
        {
            DataTable dt = Connect.TruyVandt("select tenphong From phong");
            cboPhong.DataSource = dt;
            cboPhong.DisplayMember = "tenphong";            
        }
        private void appDC()
        {
            string sql = "insert into TblDC (TEN1,TEN2,TEN3) " +
                " Select tenphong, tenhs,mshs From baoan" +
                " Where Month(ntan) = '" + cboThang.Text + "' and Year(ntan) = '" + cboNam.Text + "' and tuanthu = " + Convert.ToInt32(cboTuan.Text) + "" +
                " Group by tenphong, tenhs,mshs" +
                " Having tenphong like '" + cboPhong.Text + "%'";
            Connect.ThaoTac(sql);            
        }
        private double chamcomS( string tuan,string hs,string thu)
        {
            double kq = 0;
            string sql = "Select Sum([BS]) as An From baoan where Month(ntan) = '" + cboThang.Text + "' and" +
            " mshs = '" + hs + "' and thu = '" + thu + "' and year(ntan) = '" + cboNam.Text + "' and tuanthu = " + Convert.ToInt32(tuan);
            OleDbDataReader dr = Connect.TruyVandr(sql);
            while (dr.Read())
            {
                kq = kq + classdc.dungchung.kieudouble(dr["An"].ToString());
            }
            dr.Close();
            return kq;
        }
        private double chamcomT(string tuan, string hs, string thu)
        {
            double kq = 0;
            string sql = "Select Sum([BT]) as An From baoan where Month(ntan) = '" + cboThang.Text + "' and" +
            " mshs = '" + hs + "' and thu = '" + thu + "' and year(ntan) = '" + cboNam.Text + "' and tuanthu = " + Convert.ToInt32(tuan);
            OleDbDataReader dr = Connect.TruyVandr(sql);
            while (dr.Read())
            {
                kq = kq + classdc.dungchung.kieudouble(dr["An"].ToString());
            }
            dr.Close();
            return kq;
        }
        private double chamcomC(string tuan, string hs, string thu)
        {
            double kq = 0;
            string sql = "Select Sum([BC]) as An From baoan where Month(ntan) = '" + cboThang.Text + "' and" +
            " mshs = '" + hs + "' and thu = '" + thu + "' and year(ntan) = '" + cboNam.Text + "' and tuanthu = " + Convert.ToInt32(tuan);
            OleDbDataReader dr = Connect.TruyVandr(sql);
            while (dr.Read())
            {
                kq = kq + classdc.dungchung.kieudouble(dr["An"].ToString());
            }
            dr.Close();
            return kq;
        }
        private string ngaythu(string tuan, string hs, string thu)
        {
            string kq = "";
            string sql = "Select ntan From baoan where Month(ntan) = '" + cboThang.Text + "' and" +
            " mshs = '" + hs + "' and thu = '" + thu + "' and year(ntan) = '" + cboNam.Text + "' and tuanthu = " + Convert.ToInt32(tuan);
            OleDbDataReader dr = Connect.TruyVandr(sql);
            while (dr.Read())
            {
                if (dr["ntan"].ToString() != "")
                    kq = string.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(dr["ntan"].ToString()));
                else                    
                    kq = "";
            }
            dr.Close();
            return kq;
        }
        private string tungaydenngay(string tuan)
        {
            string kq = "";
            string sql = "Select ntan From baoan where Month(ntan) = '" + cboThang.Text + "' and" +
            " year(ntan) = '" + cboNam.Text + "' and tuanthu = " + Convert.ToInt32(tuan) + " group by ntan order by ntan";
            DataTable dt = Connect.TruyVandt(sql);
            kq = " (Từ ngày " + (dt.Rows.Count > 0 ? string.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(dt.Rows[0]["ntan"].ToString())) : "") + " đến ngày " + (dt.Rows.Count > 0 ? string.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(dt.Rows[dt.Rows.Count - 1]["ntan"].ToString())) : "") + ")";
            return kq;
        }
        private void upDC()
        {            
            double t1 = 0, t2 = 0, t3 = 0, t4 = 0, t5 = 0;
            OleDbDataReader dr = Connect.TruyVandr("select * From TblDC");
            while (dr.Read())
            {
                string sqlup = "Update TblDC set SL1 = @SL1,SL2= @Sl2,SL3=@SL3,SL4=@SL4,SL5=@SL5,"+
                    " SL6=@SL6,SL7=@SL7,SL8=@SL8,SL9=@SL9,SL10=@SL10,SL11=@SL11,SL12=@SL12,SL13=@SL13,SL14=@SL14,SL15=@SL15,"+
                    " SL16=@SL16,SL17=@Sl17,SL18=@SL18,SL19=@SL19,SL20=@SL20,SL21=@SL21,TEN4=@TEN4,TEN5=@TEN5,TEN6=@TEN6,"+
                    " TEN7=@TEN7,TEN8=@TEN8,TEN9=@TEN9,TEN10=@TEN10,SL22=@SL22 where TEN3 = '" + dr["TEN3"].ToString() + "'";
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = sqlup;
                cmd.Parameters.Add("@SL1", OleDbType.Double).Value = chamcomS(cboTuan.Text, dr["TEN3"].ToString(), "Thứ 2");
                cmd.Parameters.Add("@SL2", OleDbType.Double).Value = chamcomT(cboTuan.Text, dr["TEN3"].ToString(), "Thứ 2");
                cmd.Parameters.Add("@SL3", OleDbType.Double).Value = chamcomC(cboTuan.Text, dr["TEN3"].ToString(), "Thứ 2");
                cmd.Parameters.Add("@SL4", OleDbType.Double).Value = chamcomS(cboTuan.Text, dr["TEN3"].ToString(), "Thứ 3");
                cmd.Parameters.Add("@SL5", OleDbType.Double).Value = chamcomT(cboTuan.Text, dr["TEN3"].ToString(), "Thứ 3");
                cmd.Parameters.Add("@SL6", OleDbType.Double).Value = chamcomC(cboTuan.Text, dr["TEN3"].ToString(), "Thứ 3");
                cmd.Parameters.Add("@SL7", OleDbType.Double).Value = chamcomS(cboTuan.Text, dr["TEN3"].ToString(), "Thứ 4");
                cmd.Parameters.Add("@SL8", OleDbType.Double).Value = chamcomT(cboTuan.Text, dr["TEN3"].ToString(), "Thứ 4");
                cmd.Parameters.Add("@SL9", OleDbType.Double).Value = chamcomC(cboTuan.Text, dr["TEN3"].ToString(), "Thứ 4");
                cmd.Parameters.Add("@SL10", OleDbType.Double).Value = chamcomS(cboTuan.Text, dr["TEN3"].ToString(), "Thứ 5");
                cmd.Parameters.Add("@SL11", OleDbType.Double).Value = chamcomT(cboTuan.Text, dr["TEN3"].ToString(), "Thứ 5");
                cmd.Parameters.Add("@SL12", OleDbType.Double).Value = chamcomC(cboTuan.Text, dr["TEN3"].ToString(), "Thứ 5");
                cmd.Parameters.Add("@SL13", OleDbType.Double).Value = chamcomS(cboTuan.Text, dr["TEN3"].ToString(), "Thứ 6");
                cmd.Parameters.Add("@SL14", OleDbType.Double).Value = chamcomT(cboTuan.Text, dr["TEN3"].ToString(), "Thứ 6");
                cmd.Parameters.Add("@SL15", OleDbType.Double).Value = chamcomC(cboTuan.Text, dr["TEN3"].ToString(), "Thứ 6");
                cmd.Parameters.Add("@SL16", OleDbType.Double).Value = chamcomS(cboTuan.Text, dr["TEN3"].ToString(), "Thứ 7");
                cmd.Parameters.Add("@SL17", OleDbType.Double).Value = chamcomT(cboTuan.Text, dr["TEN3"].ToString(), "Thứ 7");
                cmd.Parameters.Add("@SL18", OleDbType.Double).Value = chamcomC(cboTuan.Text, dr["TEN3"].ToString(), "Thứ 7");
                cmd.Parameters.Add("@SL19", OleDbType.Double).Value = chamcomS(cboTuan.Text, dr["TEN3"].ToString(), "Chủ nhật");
                cmd.Parameters.Add("@SL20", OleDbType.Double).Value = chamcomT(cboTuan.Text, dr["TEN3"].ToString(), "Chủ nhật");
                cmd.Parameters.Add("@SL21", OleDbType.Double).Value = chamcomC(cboTuan.Text, dr["TEN3"].ToString(), "Chủ nhật");
                cmd.Parameters.Add("@TEN4", OleDbType.VarChar).Value = ngaythu(cboTuan.Text, dr["TEN3"].ToString(), "Thứ 2");
                cmd.Parameters.Add("@TEN5", OleDbType.VarChar).Value = ngaythu(cboTuan.Text, dr["TEN3"].ToString(), "Thứ 3");
                cmd.Parameters.Add("@TEN6", OleDbType.VarChar).Value = ngaythu(cboTuan.Text, dr["TEN3"].ToString(), "Thứ 4");
                cmd.Parameters.Add("@TEN7", OleDbType.VarChar).Value = ngaythu(cboTuan.Text, dr["TEN3"].ToString(), "Thứ 5");
                cmd.Parameters.Add("@TEN8", OleDbType.VarChar).Value = ngaythu(cboTuan.Text, dr["TEN3"].ToString(), "Thứ 6");
                cmd.Parameters.Add("@TEN9", OleDbType.VarChar).Value = ngaythu(cboTuan.Text, dr["TEN3"].ToString(), "Thứ 7");
                cmd.Parameters.Add("@TEN10", OleDbType.VarChar).Value = ngaythu(cboTuan.Text, dr["TEN3"].ToString(), "Chủ nhật");
                if (Connect.TruyVandt("Select TEN1 from TblDC group by TEN1").Rows.Count > 1)
                    cmd.Parameters.Add("@SL22", OleDbType.Double).Value = 1;
                else
                    cmd.Parameters.Add("@SL22", OleDbType.Double).Value = 0;
                Connect.LuuDL(cmd);
                t1 = t2 = t3 = t4 = t5 = 0;
            }
            dr.Close();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboThang.Text != "" && cboNam.Text != "" && cboTuan.Text != "")
                {
                    Connect.ThaoTac("Delete * From TblDC");
                    appDC();
                    upDC();
                    DataSet dts = new DataSet();
                    Connect.Loadds(dts, "Select * From TblDC", "TblDC");
                    Forms.frmHienThi frm = new Forms.frmHienThi();
                    Reports.BaChCom rpt = new KPBT.Reports.BaChCom();
                    rpt.TenDV.Value = thongtinketxuat.Default.tendv.ToString();
                    rpt.TGCham.Value = "Tuần: " + cboTuan.Text + tungaydenngay(cboTuan.Text);
                    rpt.HTHT.Value = thongtinketxuat.Default.ttdv.ToString();
                    rpt.HTGVND.Value = thongtinketxuat.Default.nlb.ToString();
                    rpt.DataSource = dts;
                    frm.printControl1.PrintingSystem = rpt.PrintingSystem;
                    rpt.CreateDocument();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bạn hãy chọn tuần, tháng, năm muốn kết xuất!", "Thông báo");
                }
            }
            catch (Exception loi) {
                MessageBox.Show("Lỗi: " + loi + " Bạn hãy kiểm tra lại dữ liệu nhập!", "Thông báo");
            }
        }        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThoaiBaChCom_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }
        
    }
}
