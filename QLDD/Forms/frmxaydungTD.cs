using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using DevComponents.DotNetBar;
using KPBT.Modules;
using System.Threading;

namespace KPBT.Forms
{
    public partial class frmxaydungTD : Office2007Form
    {
        int sg = 0;
        public string decimalChar = "";
        public DataRow nrow;
        public DataTable dtlv = new DataTable();
        public DataTable dtkq = new DataTable();
        public frmxaydungTD()
        {
            InitializeComponent();
        }

        private void tbtThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmnhapnxtpmn_Load(object sender, EventArgs e)
        {            
            decimalChar = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            if (decimalChar == ".")
                decimalChar = ",";
            dtkq = Connect.TruyVandt("SELECT tblmonan.MaMA, tblmonan.TenMA, Sum(tblchitietmonan.nangluong) AS nangluong,"+
                " Sum(tblchitietmonan.protein) AS protein, Sum(tblchitietmonan.chatbeo) AS chatbeo,"+
                " Sum(tblchitietmonan.carbohydrat) AS carbohydrat"+
                " FROM tblchitietmonan INNER JOIN tblmonan ON tblchitietmonan.MaMA = tblmonan.MaMA" +
                " GROUP BY tblmonan.MaMA, tblmonan.TenMA");
            dtkq.Columns.Add("Chon", Type.GetType("System.Boolean"));
            grcTP.DataSource = dtkq;
            grcMA.DataSource = Connect.Loadgrc("Select distinct MaTD,TenTD From tblthucdon");                       
        }
      
        private void LoadTPCT()
        {            
            for (int i = 0; i < grvKQ.RowCount; i++)
            {
                for (int j = 0; j < grvTPCT.RowCount; j++)
                {
                    if (Connect.GetStr(grvKQ.GetRowCellValue(i, colMaMA)) == Connect.GetStr(grvTPCT.GetRowCellValue(j, colMaMA1)))
                    {
                        grvTPCT.SetRowCellValue(j, colChon, "True");
                    }                    
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            LoadTPCT();
        }

        private void txtntnx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                if ((e.KeyChar < 48) || (e.KeyChar > 57))
                    e.Handled = true;
                else
                    e.Handled = false;
            }
        }
        
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (txtidnxct.Text != "")
            //    {
            //        updatenxct();
            //    }
            //    else
            //    {
            //        insertnxct();
            //        string sql = "Select * From nxct order by idnxct";
            //        DataTable dt = Connect.TruyVandt(sql);
            //        txtidnxct.Text = dt.Rows[dt.Rows.Count - 1]["idnxct"].ToString();
            //    }
            //    capnhatct();
            //    MessageBox.Show("Bạn đã lưu dữ liệu thành công!","Thông báo");
            //}
            //catch (Exception loi)
            //{
            //    MessageBox.Show(" Lỗi " + loi + " Bạn hãy kiểm tra lại dữ liệu nhập", "Thông báo");
            //}
        }      
        private void frmnhapnxtpmn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }      
        private void uncheck(object mama)
        {
            for (int i = 0; i < grvTPCT.RowCount; i++)
            {
                if (Connect.GetStr(grvTPCT.GetRowCellValue(i, colMaMA1)) == Connect.GetStr(mama))
                {
                    grvTPCT.SetRowCellValue(i, colChon, "False");
                }
            }
        }

        private void uncheckall()
        {
            for (int i = 0; i < grvTPCT.RowCount; i++)
            {
                grvTPCT.SetRowCellValue(i, colChon, "False");
            }
        }

        private string kttp(string mama)
        {
            string kq = "K";
            for (int i = 0; i < grvKQ.RowCount; i++)
            {
                if (Connect.GetStr(grvKQ.GetRowCellValue(i, colMaMA)) == mama)
                    kq = "C";
            }
            return kq;
        }

        private string tentd()
        {
            string tentd = "TĐ: ";
            for (int i = 0; i < grvTPCT.RowCount; i++)
            {
                if (Connect.GetStr(grvTPCT.GetRowCellValue(i, colChon)) == "True")
                {
                    if (tentd != "TĐ: ")
                        tentd += " - " + Connect.GetStr(grvTPCT.GetRowCellValue(i, colTenMA1));
                    else
                        tentd += Connect.GetStr(grvTPCT.GetRowCellValue(i, colTenMA1));
                }
            }
            return tentd;
        }

        private string taoMA()
        {
            string ma = "";
            if (grcKQ.DataSource == null)
            {
                Connect.Reconnect();
                ma = Connect.TaoMa("TD", Connect.TruyVandt("Select MaTD from tblthucdon"), "MaTD");
            }
            else
            {
                ma = Connect.GetStr(grvMA.GetFocusedRowCellValue(colMaTD));
            }
            return ma;
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Bạn có muốn tạo món ăn này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string ma = taoMA();
                    for (int i = 0; i < grvTPCT.RowCount; i++)
                    {
                        if (Connect.GetStr(grvTPCT.GetRowCellValue(i, colChon)) == "True" && kttp(Connect.GetStr(grvTPCT.GetRowCellValue(i, colMaMA1))) == "K")
                        {
                            OleDbCommand cmd = new OleDbCommand();
                            cmd.CommandText = "Insert into tblthucdon (MaTD,TenTD,MaMA)" +
                                " values (@MaTD,@TenTD,@MaMA)";
                            cmd.Parameters.Add("@MaTD", OleDbType.VarChar).Value = ma;
                            cmd.Parameters.Add("@TenTD", OleDbType.VarChar).Value = tentd();
                            cmd.Parameters.Add("@MaMA", OleDbType.VarChar).Value = grvTPCT.GetRowCellValue(i, colMaMA1);
                            Connect.LuuDL(cmd);
                        }
                        if (Connect.GetStr(grvTPCT.GetRowCellValue(i, colChon)) == "True" && kttp(Connect.GetStr(grvTPCT.GetRowCellValue(i, colMaMA1))) == "C")
                        {
                            OleDbCommand cmd = new OleDbCommand();
                            cmd.CommandText = "update tblthucdon set TenTD=@TenTD where MaTD = '" + Connect.GetStr(grvMA.GetFocusedRowCellValue(colMaTD)) + "'";
                            cmd.Parameters.Add("@TenTD", OleDbType.VarChar).Value = tentd();
                            Connect.LuuDL(cmd);
                        }
                    }
                    grcMA.DataSource = Connect.Loadgrc("Select distinct MaTD,TenTD From tblthucdon");
                    grvMA.MoveLast();
                    grcKQ.DataSource = Connect.Loadgrc("Select * From qrThucdon where MaTD = '" + Connect.GetStr(grvMA.GetFocusedRowCellValue(colMaTD)) + "'");
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình tạo món ăn. Bạn hãy kiểm tra lại dữ liệu nhập!", "Thông báo");
            }
        }

        private void grvMA_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            grvMA.SetRowCellValue(e.RowHandle, colSTT1, grvMA.RowCount);
            grvMA.SetRowCellValue(e.RowHandle, colTT1, "1");
            grvMA.SetRowCellValue(e.RowHandle, colIDTD, "-1");
        }

        private void btnXoa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thực phẩm này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Connect.ThaoTac("Delete * from tblthucdon where IDTD = " + Convert.ToInt64(Connect.GetStr(grvKQ.GetFocusedRowCellValue(colIDTD))));
                uncheck(grvKQ.GetFocusedRowCellValue(colMaMA));
                grvKQ.DeleteSelectedRows();
                for (int i = 0; i < grvKQ.RowCount; i++)
                {
                    grvKQ.SetRowCellValue(i, colSTT, i + 1);
                }
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "update tblthucdon set TenTD=@TenTD where MaTD = '" + Connect.GetStr(grvMA.GetRowCellValue(sg, colMaTD)) + "'";
                cmd.Parameters.Add("@TenTD", OleDbType.VarChar).Value = tentd();
                Connect.LuuDL(cmd);
                grcMA.DataSource = Connect.Loadgrc("Select distinct MaTD,TenTD From tblthucdon");
                grvMA.MoveBy(sg);
            }
        }

        private void btnXoa1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thực phẩm này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Connect.ThaoTac("Delete * from tblthucdon where MaTD = '" + Connect.GetStr(grvMA.GetFocusedRowCellValue(colMaTD)) + "'");
                //uncheck(grvKQ.GetFocusedRowCellValue(colmatp));
                grcKQ.DataSource = null;
                grvMA.DeleteSelectedRows();
                for (int i = 0; i < grvKQ.RowCount; i++)
                {
                    grvMA.SetRowCellValue(i, colSTT, i + 1);
                }
            }
        }

        private void grvMA_GotFocus(object sender, EventArgs e)
        {
            try
            {
                string sql = "Select * From qrThucdon where MaTD = '" + Connect.GetStr(grvMA.GetFocusedRowCellValue(colMaTD)) + "'";
                grcKQ.DataSource = Connect.Loadgrc("Select * From qrThucdon where MaTD = '" + Connect.GetStr(grvMA.GetFocusedRowCellValue(colMaTD)) + "'");
                uncheckall();
                LoadTPCT();
            }
            catch { }
        }

        private void grvMA_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            
        }

        private void grvMA_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                grcKQ.DataSource = Connect.Loadgrc("Select * From qrThucdon where MaTD = '" + Connect.GetStr(grvMA.GetFocusedRowCellValue(colMaTD)) + "'");
                uncheckall();
                LoadTPCT();
            }
            catch { }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            uncheckall();
            grcKQ.DataSource = null;
        }

        private void grvMA_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            sg = e.RowHandle;
        }
    }
}
