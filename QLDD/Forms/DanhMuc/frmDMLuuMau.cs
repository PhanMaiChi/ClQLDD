using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using KPBT.Modules;
using System.Data.OleDb;

namespace KPBT.Forms.DanhMuc
{
    public partial class frmDMLuuMau : DevComponents.DotNetBar.Office2007Form
    {
        int SoBG = 0;

        public frmDMLuuMau()
        {
            InitializeComponent();
        }

        private void frm_Load(object sender, EventArgs e)
        {
            Connect.LoadCBB(cbnguoiluu, "tencb", "Select tencb From canbo Order by tencb");
            Connect.LoadCBB(cbnguoihuy, "tencb", "Select tencb From canbo Order by tencb");
            grcKQ.DataSource = Connect.Loadgrc("Select * From luumta");    
        }              

        private void tbtThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }       

        private void frm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                ThemMoi();
            }
            if (e.KeyCode == Keys.Escape && grBDMPB.Visible==true)
            {
                grBDMPB.Visible = false;
                grcKQ.Enabled = true;
            }
        }

        private void ThemMoi()
        {
            SoBG = grvKQ.FocusedRowHandle;
            grcKQ.Enabled = false;
            grBDMPB.Visible = true;           
            txtidluumta.EditValue = "";
            txttenmau.EditValue = "";
            cbnguoiluu.EditValue = "";
            txtngayluu.Text = "";
            txtgioluu.EditValue = "";
            cbnguoihuy.EditValue = "";
            txtngayhuy.Text = "";
            txtgiohuy.EditValue = ""; 
           
            txttenmau.Focus();
        }        

        private void tbtXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "Delete * From luumta Where idluumta = " + grvKQ.GetFocusedRowCellValue(colidluumta).ToString();
                Connect.LuuDL(cmd);

                int So = grvKQ.FocusedRowHandle;
                if (So == (grvKQ.RowCount - 1))
                    grvKQ.MovePrev();
                grvKQ.DeleteRow(So);
                if (grvKQ.RowCount > 0)
                    for (int i = 0; i < grvKQ.RowCount; i++)
                        grvKQ.SetRowCellValue(i, colSTT, i + 1);
            }
        }       

        private void btThem_Click(object sender, EventArgs e)
        {
            ThemMoi();
        }        

        private void button2_Click(object sender, EventArgs e)
        {
            grBDMPB.Visible = false;
            grcKQ.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtidluumta.Text.Length == 0)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "Insert into luumta (tenmau, nguoiluu, ngayluu, gioluu, nguoihuy, ngayhuy, giohuy)"
                                        + " values(@tenmau, @nguoiluu, @ngayluu, @gioluu, @nguoihuy, @ngayhuy, @giohuy)";
                cmd.Parameters.Add("@tenmau", OleDbType.VarChar).Value = txttenmau.Text;
                cmd.Parameters.Add("@nguoiluu", OleDbType.VarChar).Value = cbnguoiluu.Text;
                cmd.Parameters.Add("@ngayluu", OleDbType.Date).Value = (txtngayluu.Text.Length > 6 ? (object)txtngayluu.Text : DBNull.Value);
                cmd.Parameters.Add("@gioluu", OleDbType.VarChar).Value = txtgioluu.Text;
                cmd.Parameters.Add("@nguoihuy", OleDbType.VarChar).Value = cbnguoihuy.Text;
                cmd.Parameters.Add("@ngayhuy", OleDbType.Date).Value = (txtngayhuy.Text.Length > 6 ? (object)txtngayhuy.Text : DBNull.Value);
                cmd.Parameters.Add("@giohuy", OleDbType.VarChar).Value = txtgiohuy.Text;
                Connect.LuuDL(cmd);
            }
            else
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "Update luumta set tenmau=@tenmau, nguoiluu=@nguoiluu, ngayluu=@ngayluu, gioluu=@gioluu,"
                                            + " nguoihuy=@nguoihuy, ngayhuy=@ngayhuy, giohuy=@giohuy Where idluumta = " + txtidluumta.Text;
                cmd.Parameters.Add("@tenmau", OleDbType.VarChar).Value = txttenmau.Text;
                cmd.Parameters.Add("@nguoiluu", OleDbType.VarChar).Value = cbnguoiluu.Text;
                cmd.Parameters.Add("@ngayluu", OleDbType.Date).Value = (txtngayluu.Text.Length > 6 ? (object)txtngayluu.Text : DBNull.Value);
                cmd.Parameters.Add("@gioluu", OleDbType.VarChar).Value = txtgioluu.Text;
                cmd.Parameters.Add("@nguoihuy", OleDbType.VarChar).Value = cbnguoihuy.Text;
                cmd.Parameters.Add("@ngayhuy", OleDbType.Date).Value = (txtngayhuy.Text.Length > 6 ? (object)txtngayhuy.Text : DBNull.Value);
                cmd.Parameters.Add("@giohuy", OleDbType.VarChar).Value = txtgiohuy.Text;
                Connect.LuuDL(cmd);
            }
            grBDMPB.Visible = false;
            grcKQ.Enabled = true;
            grcKQ.DataSource = Connect.Loadgrc("Select * From luumta");
            grvKQ.MoveBy(SoBG);
        }

        private void grvKQ_DoubleClick(object sender, EventArgs e)
        {
            SoBG = grvKQ.FocusedRowHandle;
            grcKQ.Enabled = false;
            grBDMPB.Visible = true;
            txtidluumta.EditValue = grvKQ.GetFocusedRowCellValue(colidluumta);
            txtgioluu.EditValue = grvKQ.GetFocusedRowCellValue(colgioluu);
            txttenmau.EditValue = grvKQ.GetFocusedRowCellValue(coltenmau);
            txtngayluu.Text = grvKQ.GetFocusedRowCellValue(colngayluu).ToString();
            cbnguoiluu.EditValue = grvKQ.GetFocusedRowCellValue(colnguoiluu);

            txtgiohuy.EditValue = grvKQ.GetFocusedRowCellValue(colgiohuy);
            txtngayhuy.Text = grvKQ.GetFocusedRowCellValue(colngayhuy).ToString();
            cbnguoihuy.EditValue = grvKQ.GetFocusedRowCellValue(colnguoihuy);
            txttenmau.Focus();
            
        }

        private void dtpngayluu_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpngayluu_Leave(object sender, EventArgs e)
        {
            try
            {
                txtngayluu.Text = clsbqkpbt.banquyen.dtngaysinh(txtngayluu.Text);
            }
            catch (Exception)
            {
                txtngayluu.Text = "";
            }
               
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                txtngayluu.Text = clsbqkpbt.banquyen.dtngaysinh(txtngayluu.Text);
            }
            catch
            {
                txtngayluu.Text = "";
            }
        }

        private void txtngayhuy_Leave(object sender, EventArgs e)
        {
            try
            {
                txtngayhuy.Text = clsbqkpbt.banquyen.dtngaysinh(txtngayluu.Text);
            }
            catch (Exception)
            {
                txtngayhuy.Text = "";
            }
        }

        private void frmDMLuuMau_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }

    }
}