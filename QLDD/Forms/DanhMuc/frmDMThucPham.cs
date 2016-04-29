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
    public partial class frmDMThucPham : DevComponents.DotNetBar.Office2007Form
    {
        int SoBG = 0;

        public frmDMThucPham()
        {
            InitializeComponent();
        }

        private void frm_Load(object sender, EventArgs e)
        {
            grcKQ.DataSource = Connect.Loadgrc("Select * From dmtp");    
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
            txtiddmtp.EditValue = "";
            txtmatp.EditValue = Connect.TaoMa("TP", "Select Max(matp) as matp From dmtp", "matp");
            txttentp.EditValue = "";
            txtdonvitinh.EditValue = "";
            txtdongia.EditValue = 0;
            txtsogam.EditValue = 0;
            txtchokho.EditValue = "Kho";
            txttentp.Focus();
        }        

        private void tbtXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "Delete * From dmtp Where iddmtp = " + grvKQ.GetFocusedRowCellValue(coliddmtp).ToString();
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
        private string kt(string tentp)
        {
            string kq = "";
            OleDbDataReader dr = Connect.TruyVandr("Select * From dmtp");
            while (dr.Read())
            {
                if (DC1.Func(dr["tentp"].ToString()) == DC1.Func(tentp))
                {
                    kq = "C";                    
                }
            }
            dr.Close();
            return kq;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtiddmtp.Text.Length == 0)
            {
                if (kt(txttentp.Text) == "")
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "Insert into dmtp (matp, tentp, donvitinh, dongia, sogam, chokho,tilethai,nangluong," +
                    " protein,chatbeo,carbohydrat,chatxo,choleterol,canxi,phospho,sat,natri,kali,vitamina,vitaminb,vitaminc)"
                                            + " values(@matp, @tentp, @donvitinh, @dongia, @sogam, @chokho,@tilethai,@nangluong," +
                    "@protein,@chatbeo,@carbohydrat,@chatxo,@choleterol,@canxi,@phospho,@sat,@natri,@kali,@vitamina,@vitaminb,@vitaminc)";
                    cmd.Parameters.Add("@matp", OleDbType.VarChar).Value = txtmatp.Text;
                    cmd.Parameters.Add("@tentp", OleDbType.VarChar).Value = txttentp.Text;
                    cmd.Parameters.Add("@donvitinh", OleDbType.VarChar).Value = txtdonvitinh.Text;
                    cmd.Parameters.Add("@dongia", OleDbType.Double).Value = dcts.GetDbl(txtdongia.EditValue);
                    cmd.Parameters.Add("@sogam", OleDbType.Double).Value = dcts.GetDbl(txtsogam.EditValue);
                    cmd.Parameters.Add("@chokho", OleDbType.VarChar).Value = txtchokho.Text;
                    cmd.Parameters.Add("@tilethai", OleDbType.Double).Value = dcts.GetDbl(txttilethai.EditValue);
                    cmd.Parameters.Add("@nangluong", OleDbType.Double).Value = dcts.GetDbl(txtnangluong.EditValue);
                    cmd.Parameters.Add("@protein", OleDbType.Double).Value = dcts.GetDbl(txtprotein.EditValue);
                    cmd.Parameters.Add("@chatbeo", OleDbType.Double).Value = dcts.GetDbl(txtchatbeo.EditValue);
                    cmd.Parameters.Add("@carbohydrat", OleDbType.Double).Value = dcts.GetDbl(txtcarbohydrat.EditValue);
                    cmd.Parameters.Add("@chatxo", OleDbType.Double).Value = dcts.GetDbl(txtchatxo.EditValue);
                    cmd.Parameters.Add("@choleterol", OleDbType.Double).Value = dcts.GetDbl(txtcholeterol.EditValue);
                    cmd.Parameters.Add("@canxi", OleDbType.Double).Value = dcts.GetDbl(txtcanxi.EditValue);
                    cmd.Parameters.Add("@phospho", OleDbType.Double).Value = dcts.GetDbl(txtphospho.EditValue);
                    cmd.Parameters.Add("@sat", OleDbType.Double).Value = dcts.GetDbl(txtsat.EditValue);
                    cmd.Parameters.Add("@natri", OleDbType.Double).Value = dcts.GetDbl(txtnatri.EditValue);
                    cmd.Parameters.Add("@kali", OleDbType.Double).Value = dcts.GetDbl(txtkali.EditValue);
                    cmd.Parameters.Add("@vitamina", OleDbType.Double).Value = dcts.GetDbl(txtvitamina.EditValue);
                    cmd.Parameters.Add("@vitaminb", OleDbType.Double).Value = dcts.GetDbl(txtvitaminb.EditValue);
                    cmd.Parameters.Add("@vitaminc", OleDbType.Double).Value = dcts.GetDbl(txtvitaminc.EditValue);
                    Connect.LuuDL(cmd);
                }
                else
                {
                    MessageBox.Show("Thực phẩm này đã tồn tại, hãy nhập lại!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "Update dmtp set matp=@matp, tentp=@tentp, donvitinh=@donvitinh, dongia=@dongia,"
                + " sogam=@sogam, chokho=@chokho,tilethai=@tilethai,nangluong=@nangluong,protein=@protein,chatbeo=@chatbeo " +
                " ,carbohydrat=@carbohydrat,chatxo=@chatxo,choleterol=@choleterol,canxi=@canxi,phospho=@phospho,sat=@sat" +
                " ,natri=@natri,kali=@kali,vitamina=@vitamina,vitaminb=@vitaminb,vitaminc=@vitaminc" +
                " Where iddmtp = " + txtiddmtp.Text;
                cmd.Parameters.Add("@matp", OleDbType.VarChar).Value = txtmatp.Text;
                cmd.Parameters.Add("@tentp", OleDbType.VarChar).Value = txttentp.Text;
                cmd.Parameters.Add("@donvitinh", OleDbType.VarChar).Value = txtdonvitinh.Text;
                cmd.Parameters.Add("@dongia", OleDbType.Double).Value = dcts.GetDbl(txtdongia.EditValue);
                cmd.Parameters.Add("@sogam", OleDbType.Double).Value = dcts.GetDbl(txtsogam.EditValue);
                cmd.Parameters.Add("@chokho", OleDbType.VarChar).Value = txtchokho.Text;
                cmd.Parameters.Add("@tilethai", OleDbType.Double).Value = dcts.GetDbl(txttilethai.EditValue);
                cmd.Parameters.Add("@nangluong", OleDbType.Double).Value = dcts.GetDbl(txtnangluong.EditValue);
                cmd.Parameters.Add("@protein", OleDbType.Double).Value = dcts.GetDbl(txtprotein.EditValue);
                cmd.Parameters.Add("@chatbeo", OleDbType.Double).Value = dcts.GetDbl(txtchatbeo.EditValue);
                cmd.Parameters.Add("@carbohydrat", OleDbType.Double).Value = dcts.GetDbl(txtcarbohydrat.EditValue);
                cmd.Parameters.Add("@chatxo", OleDbType.Double).Value = dcts.GetDbl(txtchatxo.EditValue);
                cmd.Parameters.Add("@choleterol", OleDbType.Double).Value = dcts.GetDbl(txtcholeterol.EditValue);
                cmd.Parameters.Add("@canxi", OleDbType.Double).Value = dcts.GetDbl(txtcanxi.EditValue);
                cmd.Parameters.Add("@phospho", OleDbType.Double).Value = dcts.GetDbl(txtphospho.EditValue);
                cmd.Parameters.Add("@sat", OleDbType.Double).Value = dcts.GetDbl(txtsat.EditValue);
                cmd.Parameters.Add("@natri", OleDbType.Double).Value = dcts.GetDbl(txtnatri.EditValue);
                cmd.Parameters.Add("@kali", OleDbType.Double).Value = dcts.GetDbl(txtkali.EditValue);
                cmd.Parameters.Add("@vitamina", OleDbType.Double).Value = dcts.GetDbl(txtvitamina.EditValue);
                cmd.Parameters.Add("@vitaminb", OleDbType.Double).Value = dcts.GetDbl(txtvitaminb.EditValue);
                cmd.Parameters.Add("@vitaminc", OleDbType.Double).Value = dcts.GetDbl(txtvitaminc.EditValue);
                Connect.LuuDL(cmd);
            }
            grBDMPB.Visible = false;
            grcKQ.Enabled = true;
            grcKQ.DataSource = Connect.Loadgrc("Select * From dmtp");
            grvKQ.MoveBy(SoBG);
        }

        private void grvKQ_DoubleClick(object sender, EventArgs e)
        {
            SoBG = grvKQ.FocusedRowHandle;
            grcKQ.Enabled = false;
            grBDMPB.Visible = true;
            txtiddmtp.EditValue = grvKQ.GetFocusedRowCellValue(coliddmtp);
            txtdongia.EditValue = grvKQ.GetFocusedRowCellValue(coldongia);
            txtmatp.EditValue = grvKQ.GetFocusedRowCellValue(colmatp);
            txtdonvitinh.EditValue = grvKQ.GetFocusedRowCellValue(coldonvitinh);
            txttentp.EditValue = grvKQ.GetFocusedRowCellValue(coltentp);
            txtchokho.EditValue = grvKQ.GetFocusedRowCellValue(colchokho);
            txtsogam.EditValue = grvKQ.GetFocusedRowCellValue(colsogam);
            txttilethai.EditValue = grvKQ.GetFocusedRowCellValue(coltilethai);
            txtnangluong.EditValue = grvKQ.GetFocusedRowCellValue(colnangluong);
            txtprotein.EditValue = grvKQ.GetFocusedRowCellValue(colprotein);
            txtchatbeo.EditValue = grvKQ.GetFocusedRowCellValue(colchatbeo);
            txtcarbohydrat.EditValue = grvKQ.GetFocusedRowCellValue(colcarbohydrat);
            txtchatxo.EditValue = grvKQ.GetFocusedRowCellValue(colchatxo);
            txtcholeterol.EditValue = grvKQ.GetFocusedRowCellValue(colcholeterol);
            txtcanxi.EditValue = grvKQ.GetFocusedRowCellValue(colcanxi);
            txtphospho.EditValue = grvKQ.GetFocusedRowCellValue(colphospho);
            txtsat.EditValue = grvKQ.GetFocusedRowCellValue(colsat);
            txtnatri.EditValue = grvKQ.GetFocusedRowCellValue(colnatri);
            txtkali.EditValue = grvKQ.GetFocusedRowCellValue(colkali);
            txtvitamina.EditValue = grvKQ.GetFocusedRowCellValue(colvitamina);
            txtvitaminb.EditValue = grvKQ.GetFocusedRowCellValue(colvitaminb);
            txtvitaminc.EditValue = grvKQ.GetFocusedRowCellValue(colvitaminc);
        }

        private void frmDMThucPham_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }
    }
}