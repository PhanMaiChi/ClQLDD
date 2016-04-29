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
    public partial class frmDMKho : DevComponents.DotNetBar.Office2007Form
    {
        int SoBG = 0;

        public frmDMKho()
        {
            InitializeComponent();
        }

        private void frm_Load(object sender, EventArgs e)
        {
            grcKQ.DataSource = Connect.Loadgrc("Select * From kho");    
        }              

        private void tbtThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }         
        private void tbtXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "Delete * From kho Where idsophong = " + grvKQ.GetFocusedRowCellValue(colidkho).ToString() ;
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
            grvKQ.CloseEditor();
            grvKQ.MoveFirst();
            Luu();
        }
        private void Luu()
        {
            try
            {
                for (int i = 0; i < grvKQ.RowCount -1; i++)
                {
                    if (Connect.GetStr(grvKQ.GetRowCellValue(i, colTT)) == "1")
                    {
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = "Insert into kho (tenkho, dd) values(@tenkho, @dd)";
                        cmd.Parameters.Add("@tenkho", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, coltenkho);
                        cmd.Parameters.Add("@dd", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, coldd);
                        Connect.LuuDL(cmd);
                    }
                    if (Connect.GetStr(grvKQ.GetRowCellValue(i, colTT)) == "0" && Connect.GetStr(grvKQ.GetRowCellValue(i, colidkho)) != "-1")
                    {
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = "Update kho set tenkho=@tenkho, dd=@dd" +
                                              " Where idkho = " + Convert.ToInt64(Connect.GetStr(grvKQ.GetRowCellValue(i, colidkho)));
                        cmd.Parameters.Add("@tenkho", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, coltenkho);
                        cmd.Parameters.Add("@dd", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, coldd);
                        Connect.LuuDL(cmd);
                    }                   
                }                
                grcKQ.DataSource = Connect.Loadgrc("Select * From kho");
                MessageBox.Show("Bạn đã cập nhật thành công!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình lưu dữ liệu. Bạn hãy kiểm tra lại!", "Thông báo");
            }
        }      
        private void frmDMKho_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }

        private void grvKQ_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            grvKQ.SetRowCellValue(e.RowHandle, colSTT, grvKQ.RowCount);
            grvKQ.SetRowCellValue(e.RowHandle, colTT, "1");
            grvKQ.SetRowCellValue(e.RowHandle, colidkho, "-1");
        }
    }
}