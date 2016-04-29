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
    public partial class frmxaydungMA : Office2007Form
    {
        public string ma = "";
        public string decimalChar = "";
        public DataRow nrow;
        public DataTable dtlv = new DataTable();
        public DataTable dtkq = new DataTable();
        public frmxaydungMA()
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
            dtkq = Connect.TruyVandt("Select * From dmtp ");
            dtkq.Columns.Add("Chon", Type.GetType("System.Boolean"));
            grcTP.DataSource = dtkq;
            grcMA.DataSource = Connect.Loadgrc("Select * From tblmonan");
            //dtlv = Connect.Loadgrc("Select * From tblchitietmonan");
            //dtlv.Rows.Clear();
            //loaddtlv();            
        }
        private void loaddtlv()
        {
            if (dtlv.Rows.Count > 0)
                dtlv.Rows.Clear();
            for (int i = 0; i < grvKQ.RowCount; i++)
            {
                nrow = dtlv.NewRow();
                nrow["IDCTMA"] = grvKQ.GetRowCellValue(i, colIDCTMA);
                nrow["MaMA"] = grvKQ.GetRowCellValue(i, colMaMA1);
                nrow["matp"] = grvKQ.GetRowCellValue(i, colmatp);
                nrow["tentp"] = grvKQ.GetRowCellValue(i, coltentp);
                //nrow["sogam"] = "";
                nrow["nangluong"] = Connect.GetDou(grvKQ.GetRowCellValue(i, colnangluong));
                nrow["protein"] = Connect.GetDou(grvKQ.GetRowCellValue(i, colprotein));
                nrow["chatbeo"] = Connect.GetDou(grvKQ.GetRowCellValue(i, colchatbeo));
                nrow["carbohydrat"] = Connect.GetDou(grvKQ.GetRowCellValue(i, colcarbohydrat));               
                nrow["STT"] = grvKQ.GetRowCellValue(i, colSTT);
                dtlv.Rows.Add(nrow);
            }
        }

        private void LoadTPCT()
        {
            dtlv = Connect.Loadgrc("Select * From tblchitietmonan where MaMA = '" + Connect.GetStr(grvMA.GetFocusedRowCellValue(colMaMA)) + "'");
            for (int i = 0; i < grvKQ.RowCount; i++)
            {
                for (int j = 0; j < grvTPCT.RowCount; j++)
                {
                    if (Connect.GetStr(grvKQ.GetRowCellValue(i, colmatp)) == Connect.GetStr(grvTPCT.GetRowCellValue(j, colmatp1)))
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
        private void uncheck(object matp)
        {
            for (int i = 0; i < grvTPCT.RowCount; i++)
            {
                if (Connect.GetStr(grvTPCT.GetRowCellValue(i, colmatp1)) == Connect.GetStr(matp))
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

        private string kttp(string matp)
        {
            string kq = "K";
            for (int i = 0; i < grvKQ.RowCount; i++)
            {
                if (Connect.GetStr(grvKQ.GetRowCellValue(i, colmatp)) == matp)
                    kq = "C";
            }
            return kq;
        }

        private void taoMA()
        {
            for (int i = 0; i < grvMA.RowCount - 1; i++)
            {
                if (Connect.GetStr(grvMA.GetRowCellValue(i, colTT1)) == "1")
                {
                    Connect.Reconnect();
                    ma = Connect.TaoMa("MA", Connect.TruyVandt("Select MaMA from tblmonan"), "MaMA");
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "Insert into tblmonan (MaMA,TenMA) values (@MaMA,@TenMA)";
                    cmd.Parameters.Add("@MaMA", OleDbType.VarChar).Value = ma;
                    cmd.Parameters.Add("@TenMA", OleDbType.VarChar).Value = grvMA.GetRowCellValue(i, colTenMA);
                    Connect.LuuDL(cmd);
                }
                if (Connect.GetStr(grvMA.GetRowCellValue(i, colTT1)) == "0" && Connect.GetStr(grvMA.GetRowCellValue(i, colIDMA)) != "-1")
                {
                    ma = Connect.GetStr(grvMA.GetFocusedRowCellValue(colMaMA));
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "update tblmonan set TenMA=@TenMA where IDMA = " + Convert.ToInt64(Connect.GetStr(grvMA.GetRowCellValue(i, colIDMA)));
                    //cmd.Parameters.Add("@MaMA", OleDbType.VarChar).Value = grvMA.GetRowCellValue(i, colMaMA);
                    cmd.Parameters.Add("@TenMA", OleDbType.VarChar).Value = grvMA.GetRowCellValue(i, colTenMA);
                    Connect.LuuDL(cmd);
                }
            }            
        }
       
        private void btnChuyen_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (Connect.GetStr(grvMA.GetFocusedRowCellValue(colTenMA)) == "")
                {
                    MessageBox.Show("Bạn hãy chọn món ăn cần tạo!", "Thông báo");
                }
                else
                {
                    if (MessageBox.Show("Bạn có muốn tạo món ăn này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        taoMA();
                        for (int i = 0; i < grvTPCT.RowCount; i++)
                        {
                            if (Connect.GetStr(grvTPCT.GetRowCellValue(i, colChon)) == "True" && kttp(Connect.GetStr(grvTPCT.GetRowCellValue(i, colmatp1))) == "K")
                            {

                                OleDbCommand cmd = new OleDbCommand();
                                cmd.CommandText = "Insert into tblchitietmonan (MaMA,matp,tentp,nangluong,protein,chatbeo,carbohydrat)" +
                                    " values (@MaMA,@matp,@tentp,@nangluong,@protein,@chatbeo,@carbohydrat)";
                                cmd.Parameters.Add("@MaMA", OleDbType.VarChar).Value = ma;
                                cmd.Parameters.Add("@matp", OleDbType.VarChar).Value = grvTPCT.GetRowCellValue(i, colmatp1);
                                cmd.Parameters.Add("@tentp", OleDbType.VarChar).Value = grvTPCT.GetRowCellValue(i, coltentp1);
                                cmd.Parameters.Add("@nangluong", OleDbType.VarChar).Value = grvTPCT.GetRowCellValue(i, colnangluong1);
                                cmd.Parameters.Add("@protein", OleDbType.VarChar).Value = grvTPCT.GetRowCellValue(i, colprotein1);
                                cmd.Parameters.Add("@chatbeo", OleDbType.VarChar).Value = grvTPCT.GetRowCellValue(i, colchatbeo1);
                                cmd.Parameters.Add("@carbohydrat", OleDbType.VarChar).Value = grvTPCT.GetRowCellValue(i, colcarbohydrat1);
                                Connect.LuuDL(cmd);
                            }
                        }
                        grcMA.DataSource = Connect.Loadgrc("Select * From tblmonan");
                        grvMA.MoveLast();
                        grcKQ.DataSource = Connect.Loadgrc("Select * From tblchitietmonan where MaMA = '" + Connect.GetStr(grvMA.GetFocusedRowCellValue(colMaMA)) + "'");
                    }
                }                     
            //}
            //catch
            //{
            //    MessageBox.Show("Có lỗi trong quá trình tạo món ăn. Bạn hãy kiểm tra lại dữ liệu nhập!", "Thông báo");
            //}
        }

        private void grvMA_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            grvMA.SetRowCellValue(e.RowHandle, colSTT1, grvMA.RowCount);
            grvMA.SetRowCellValue(e.RowHandle, colTT1, "1");
            grvMA.SetRowCellValue(e.RowHandle, colIDMA, "-1");
        }

        private void btnXoa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thực phẩm này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Connect.ThaoTac("Delete * from tblchitietmonan where IDCTMA = " + Convert.ToInt64(Connect.GetStr(grvKQ.GetFocusedRowCellValue(colIDCTMA))));
                uncheck(grvKQ.GetFocusedRowCellValue(colmatp));
                grvKQ.DeleteSelectedRows();
                for (int i = 0; i < grvKQ.RowCount; i++)
                {
                    grvKQ.SetRowCellValue(i, colSTT, i + 1);
                }
            }
        }

        private void btnXoa1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thực phẩm này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Connect.ThaoTac("Delete * from tblmonan where IDMA = " + Convert.ToInt64(Connect.GetStr(grvMA.GetFocusedRowCellValue(colIDMA))));
                Connect.ThaoTac("Delete * from tblchitietmonan where MaMA = '" + Connect.GetStr(grvMA.GetFocusedRowCellValue(colMaMA)) + "'");
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
                grcKQ.DataSource = Connect.Loadgrc("Select * From tblchitietmonan where MaMA = '" + Connect.GetStr(grvMA.GetFocusedRowCellValue(colMaMA)) + "'");
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
                grcKQ.DataSource = Connect.Loadgrc("Select * From tblchitietmonan where MaMA = '" + Connect.GetStr(grvMA.GetFocusedRowCellValue(colMaMA)) + "'");
                uncheckall();
                LoadTPCT();
            }
            catch { }
        }
    }
}
