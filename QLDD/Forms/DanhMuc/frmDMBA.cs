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
    public partial class frmDMBA : DevComponents.DotNetBar.Office2007Form
    {
        int SoBG = 0;

        public frmDMBA()
        {
            InitializeComponent();
        }

        private void frm_Load(object sender, EventArgs e)
        {
            grcKQ.DataSource = Connect.Loadgrc("Select * From tblbuaan order by TenBA");    
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
                cmd.CommandText = "Delete * From TenBA Where IDBA = " + grvKQ.GetFocusedRowCellValue(colIDBA).ToString();
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
            //try
            //{
                for (int i = 0; i < grvKQ.RowCount -1; i++)
                {
                    if (Connect.GetStr(grvKQ.GetRowCellValue(i,colTT)) == "1")
                    {
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = "Insert into tblbuaan (TenBA,Theodoi) values(@TenBA,@Theodoi)";
                        cmd.Parameters.Add("@TenBA", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colTenBA);
                        cmd.Parameters.Add("@Theodoi", OleDbType.Boolean).Value = grvKQ.GetRowCellValue(i, colTheodoi);
                        Connect.LuuDL(cmd);
                    }
                    if (Connect.GetStr(grvKQ.GetRowCellValue(i, colTT)) == "0" && Connect.GetStr(grvKQ.GetRowCellValue(i,colIDBA)) != "-1")
                    {
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = "Update tblbuaan set TenBA=@TenBA,Theodoi=@Theodoi Where IDBA = " + Convert.ToInt64(Connect.GetStr(grvKQ.GetRowCellValue(i, colIDBA)));
                        cmd.Parameters.Add("@TenBA", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colTenBA);
                        cmd.Parameters.Add("@Theodoi", OleDbType.Boolean).Value = grvKQ.GetRowCellValue(i, colTheodoi);
                        Connect.LuuDL(cmd);
                    }                          
                }
                MessageBox.Show("Bạn đã cập nhật thành công!", "Thông báo");
                grcKQ.DataSource = Connect.Loadgrc("Select * From tblbuaan");
                grvKQ.MoveBy(SoBG);
            //}
            //catch {
            //    MessageBox.Show("Có lỗi trong quá trình lưu. Bạn hãy kiểm tra lại chi tiết nhập!", "Thông báo");
            //}
        }       

        private void frmDMDT_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }

        private void grvKQ_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {           
            grvKQ.SetRowCellValue(e.RowHandle, colSTT, grvKQ.RowCount.ToString());
            grvKQ.SetRowCellValue(e.RowHandle, colTT, "1");
            grvKQ.SetRowCellValue(e.RowHandle, colIDBA, "-1");
            grvKQ.SetRowCellValue(e.RowHandle, colTheodoi, "True");
        }
    }
}