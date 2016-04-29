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

namespace KPBT.Forms.DanhMuc
{
    public partial class frmChuyenHS : Office2007Form
    {
        public frmChuyenHS()
        {
            InitializeComponent();
        }       

        private void frmChuyenHS_Load(object sender, EventArgs e)
        {
            Connect.LoadCBB(cboLopTu, "tenphong", "select * From phong");
            Connect.LoadCBB(cboLopden, "tenphong", "select * From phong");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string sqldk = "Select * From hocsinh where tenphong = '" + cboLopTu.EditValue + "'";
            OleDbDataReader dr = Connect.TruyVandr(sqldk);
            while (dr.Read())
            {
                string sql = "Update hocsinh set tenphong = @tenphong where idhs = " + Convert.ToInt64(dr["idhs"].ToString());
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@tenphong", OleDbType.VarChar).Value = cboLopden.EditValue;
                Connect.LuuDL(cmd);
            }
            dr.Close();
            chuyenbaoan();
            chuyencanbo();
        }

        private void chuyenbaoan()
        {
            string sqldk = "Select * From baoan where tenphong = '" + cboLopTu.EditValue + "'";
            OleDbDataReader dr = Connect.TruyVandr(sqldk);
            while (dr.Read())
            {
                string sql = "Update baoan set tenphong = @tenphong where idbaoan = " + Convert.ToInt64(dr["idbaoan"].ToString());
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@tenphong", OleDbType.VarChar).Value = cboLopden.EditValue;
                Connect.LuuDL(cmd);
            }
            dr.Close();
        }
        private void chuyencanbo()
        {
            string sqldk = "Select * From canbo where phongban = '" + cboLopTu.EditValue + "'";
            OleDbDataReader dr = Connect.TruyVandr(sqldk);
            while (dr.Read())
            {
                string sql = "Update canbo set phongban = @phongban where idcanbo = " + Convert.ToInt64(dr["idcanbo"].ToString());
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@tenphong", OleDbType.VarChar).Value = cboLopden.EditValue;
                Connect.LuuDL(cmd);
            }
            dr.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
