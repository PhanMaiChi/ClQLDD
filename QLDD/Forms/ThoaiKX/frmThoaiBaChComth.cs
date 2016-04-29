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
    public partial class frmThoaiBaChComth : Office2007Form
    {
        public frmThoaiBaChComth()
        {
            InitializeComponent();
        }

        private void frmThoaiLuuMTAn_Load(object sender, EventArgs e)
        {
            phong();
            cboPhong.Text = "";
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
                " Where Month(ntan) = '" + cboThang.Text + "' and Year(ntan) = '" + cboNam.Text + "'" +
                " Group by tenphong, tenhs,mshs" +
                " Having  " + (cboPhong.Text == ""? "tenphong like '%'": "tenphong = '" + cboPhong.Text + "'");
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
            double t1 = 0, t2 = 0, t3 = 0, t4 = 0, t5 = 0, t6 = 0;
            OleDbDataReader dr = Connect.TruyVandr("select * From TblDC");
            while (dr.Read())
            {
                t1 = t1 + chamcom("1", dr["TEN3"].ToString());
                t2 = t2 + chamcom("2", dr["TEN3"].ToString());
                t3 = t3 + chamcom("3", dr["TEN3"].ToString());
                t4 = t4 + chamcom("4", dr["TEN3"].ToString());
                t5 = t5 + chamcom("5", dr["TEN3"].ToString());
                t6 = t6 + chamcom("6", dr["TEN3"].ToString());
                string sqlup = "Update TblDC set SL1 = @SL1,SL2= @Sl2,SL3=@SL3,SL4=@SL4,SL5=@SL5,SL6=@SL6 where TEN3 = '" + dr["TEN3"].ToString() + "'";
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = sqlup;
                cmd.Parameters.Add("@SL1", OleDbType.Double).Value = t1;
                cmd.Parameters.Add("@SL2", OleDbType.Double).Value = t2;
                cmd.Parameters.Add("@SL3", OleDbType.Double).Value = t3;
                cmd.Parameters.Add("@SL4", OleDbType.Double).Value = t4;
                cmd.Parameters.Add("@SL5", OleDbType.Double).Value = t5;
                cmd.Parameters.Add("@SL6", OleDbType.Double).Value = t6;
                Connect.LuuDL(cmd);
                t1 = t2 = t3 = t4 = t5 = t6 = 0;
            }
            dr.Close();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cboThang.Text != "" && cboNam.Text != "")
            {
                Connect.ThaoTac("Delete * From TblDC");
                appDC();
                upDC();
                DataSet dts = new DataSet();
                Connect.Loadds(dts, "Select * From TblDC", "TblDC");
                Forms.frmHienThi frm = new Forms.frmHienThi();
                Reports.BaChComth rpt = new KPBT.Reports.BaChComth();
                rpt.TenDV.Value = thongtinketxuat.Default.tendv.ToString();
                rpt.THANG.Value = "Tháng " + cboThang.Text;
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

        private void frmThoaiBaChComth_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }
        
    }
}
