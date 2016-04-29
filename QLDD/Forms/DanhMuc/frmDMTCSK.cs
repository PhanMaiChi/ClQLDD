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
    public partial class frmDMTCSK : DevComponents.DotNetBar.Office2007Form
    {
        int SoBG = 0;

        public frmDMTCSK()
        {
            InitializeComponent();
        }

        private void frm_Load(object sender, EventArgs e)
        {
            //Connect.LoadCBB(cbplgt, "tenphong", "Select tenphong From phong Order by tenphong");
            grcKQ.DataSource = Connect.Loadgrc("Select * From dmtcsk order by iddmtcsk");    
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
                cmd.CommandText = "Delete * From dmtcsk Where iddmtcsk = " + grvKQ.GetFocusedRowCellValue(coliddmtcsk).ToString();
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
                for (int i = 0; i < grvKQ.RowCount - 1; i++)
                {
                    if (Connect.GetStr(grvKQ.GetRowCellValue(i,colTT)) == "1")
                    {
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = "Insert into dmtcsk (plgt, thangtuoi, cannangsdd, cannangnguycosddtu,cannangnguycosddden," +
                            " cannangbinhthuongtu,cannangbinhthuongden,cannangnguycobptu,cannangnguycobpden,cannangbeophi)" +
                        " values(@plgt, @thangtuoi, @cannangsdd, @cannangnguycosddtu,@cannangnguycosddden,@cannangbinhthuongtu," +
                        " @cannangbinhthuongden,@cannangnguycobptu,@cannangnguycobpden,@cannangbeophi)";
                        cmd.Parameters.Add("@plgt", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colplgt);
                        cmd.Parameters.Add("@thangtuoi", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colthangtuoi);
                        cmd.Parameters.Add("@cannangsdd", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colcannangsdd);
                        cmd.Parameters.Add("@cannangnguycosddtu", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colcannangnguycosddtu);
                        cmd.Parameters.Add("@cannangnguycosddden", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colcannangnguycosddden);
                        cmd.Parameters.Add("@cannangbinhthuongtu", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colcannangbinhthuongtu);
                        cmd.Parameters.Add("@cannangbinhthuongden", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colcannangbinhthuongden);
                        cmd.Parameters.Add("@cannangnguycobptu", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colcannangnguycobptu);
                        cmd.Parameters.Add("@cannangnguycobpden", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colcannangnguycobpden);
                        cmd.Parameters.Add("@cannangbeophi", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colcannangbeophi);
                        Connect.LuuDL(cmd);
                    }
                    if (Connect.GetStr(grvKQ.GetRowCellValue(i, colTT)) == "0" && Connect.GetStr(grvKQ.GetRowCellValue(i, coliddmtcsk)) != "-1")
                    {
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = "Update dmtcsk set plgt=@plgt, thangtuoi=@thangtuoi, cannangsdd=@cannangsdd," +
                        " cannangnguycosddtu=@cannangnguycosddtu,cannangnguycosddden=@cannangnguycosddden,cannangbinhthuongtu=@cannangbinhthuongtu," +
                        " cannangbinhthuongden=@cannangbinhthuongden,cannangnguycobptu=@cannangnguycobptu,cannangnguycobpden=@cannangnguycobpden," +
                        " cannangbeophi=@cannangbeophi" +
                        " Where iddmtcsk = " + Convert.ToInt64(Connect.GetStr(grvKQ.GetRowCellValue(i, coliddmtcsk)));
                        cmd.Parameters.Add("@plgt", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colplgt);
                        cmd.Parameters.Add("@thangtuoi", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colthangtuoi);
                        cmd.Parameters.Add("@cannangsdd", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colcannangsdd);
                        cmd.Parameters.Add("@cannangnguycosddtu", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colcannangnguycosddtu);
                        cmd.Parameters.Add("@cannangnguycosddden", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colcannangnguycosddden);
                        cmd.Parameters.Add("@cannangbinhthuongtu", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colcannangbinhthuongtu);
                        cmd.Parameters.Add("@cannangbinhthuongden", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colcannangbinhthuongden);
                        cmd.Parameters.Add("@cannangnguycobptu", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colcannangnguycobptu);
                        cmd.Parameters.Add("@cannangnguycobpden", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colcannangnguycobpden);
                        cmd.Parameters.Add("@cannangbeophi", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colcannangbeophi);
                        Connect.LuuDL(cmd);
                    }
                }
                grcKQ.DataSource = Connect.Loadgrc("Select * From dmtcsk order by iddmtcsk");
                MessageBox.Show("Bạn đã cập nhật thành công!", "Thông báo");
            }
            catch {
                MessageBox.Show("Có lỗi trong quá trình lưu dữ liệu. Bạn hãy kiểm tra lại chi tiết nhập", "Thông báo");
            }
        }       
        private void frmDMCanBo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }

        private void grvKQ_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            grvKQ.SetRowCellValue(e.RowHandle, colSTT, grvKQ.RowCount);
            grvKQ.SetRowCellValue(e.RowHandle, coliddmtcsk, "-1");
            grvKQ.SetRowCellValue(e.RowHandle, colTT, "1");
        }
    }
}