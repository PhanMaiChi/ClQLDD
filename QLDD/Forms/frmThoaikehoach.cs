using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using KPBT.Modules;
using System.Data.OleDb;

namespace KPBT.Forms
{
    public partial class frmThoaikehoach : Office2007Form
    {
        public DataTable dtkh = new DataTable();
        public DataTable dt = new DataTable();
        public frmThoaikehoach()
        {
            InitializeComponent();
        }

        private void frmThoaikehoach_Load(object sender, EventArgs e)
        {
            dcts.taoTG(false, dtkh, "MaTD", "TenMA", "MaMA", "IDKH");
            dcts.taoTG(false,dt,"MaTD","TenMA","MaMA");
            dt.Columns.Add("Chon", Type.GetType("System.Boolean"));
            //Connect.LoadDL(LuNhomtuoi, "MaNT", "TenNT", "Select * From tblnhomtuoi");
            txtngaythang.Text = DC1.ngay;
            cboNhomTuoi.EditValue = DC1.nhomtuoi;
            //Connect.LoadDL(LuBuaan, "TenBA", "TenBA", "Select TenBA from tblbuaan where Theodoi = True");
            foreach (DataRow item in Connect.TruyVandt("Select distinct MaTD,TenTD from tblthucdon").Rows)
            {
                dt.Rows.Add(item["MaTD"], item["TenTD"], "");
            }
            foreach (DataRow item in Connect.TruyVandt("Select MaMA,TenMA from tblmonan").Rows)
            {
                dt.Rows.Add("", item["TenMA"], item["MaMA"]);
            }
            grcTP.DataSource = dt;
        }

        private string kttp(string mama, string matd)
        {
            string kq = "K";
            for (int i = 0; i < grvKH.RowCount; i++)
            {
                if (Connect.GetStr(grvKH.GetRowCellValue(i, colMaMA)) == mama && mama != "")
                    kq = "C";
                if (Connect.GetStr(grvKH.GetRowCellValue(i, colMaTD)) == matd && matd != "")
                    kq = "C";                 
            }
            return kq;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (cboBuaan.EditValue == null)
            {
                MessageBox.Show("Bạn hãy chọn bữa ăn muốn tạo!", "Thông báo");
            }
            else
            {
                for (int i = 0; i < grvTPCT.RowCount; i++)
                {
                    if (Connect.GetStr(grvTPCT.GetRowCellValue(i, colChon)) == "True" && kttp(Connect.GetStr(grvTPCT.GetRowCellValue(i, colMaMA1)), Connect.GetStr(grvTPCT.GetRowCellValue(i, colMaTD1))) == "K")
                    {
                        DataRow row = dtkh.NewRow();
                        row["MaTD"] = grvTPCT.GetRowCellValue(i, colMaTD1);
                        row["TenMA"] = grvTPCT.GetRowCellValue(i, colTenMA1);
                        row["MaMA"] = grvTPCT.GetRowCellValue(i, colMaMA1);
                        row["IDKH"] = "0";
                        dtkh.Rows.Add(row);
                    }
                }
                grcKH.DataSource = null;
                grcKH.DataSource = dtkh;
            }
        }

        private void LoadTPCT()
        {
            for (int i = 0; i < grvKH.RowCount; i++)
            {
                for (int j = 0; j < grvTPCT.RowCount; j++)
                {
                    if (Connect.GetStr(grvKH.GetRowCellValue(i, colMaMA)) == Connect.GetStr(grvTPCT.GetRowCellValue(j, colMaMA1)) && Connect.GetStr(grvKH.GetRowCellValue(i, colMaMA)) != "")
                    {
                        grvTPCT.SetRowCellValue(j, colChon, "True");
                    }
                    if (Connect.GetStr(grvKH.GetRowCellValue(i, colMaTD)) == Connect.GetStr(grvTPCT.GetRowCellValue(j, colMaTD1)) && Connect.GetStr(grvKH.GetRowCellValue(i, colMaTD)) != "")
                    {
                        grvTPCT.SetRowCellValue(j, colChon, "True");
                    }
                }
            }
        }

        private void uncheck(object mama, object matd)
        {
            for (int i = 0; i < grvTPCT.RowCount; i++)
            {
                if (Connect.GetStr(grvTPCT.GetRowCellValue(i, colMaMA1)) == Connect.GetStr(mama) && Connect.GetStr(mama) != "")
                {
                    grvTPCT.SetRowCellValue(i, colChon, "False");
                }
                if (Connect.GetStr(grvTPCT.GetRowCellValue(i, colMaTD1)) == Connect.GetStr(matd) && Connect.GetStr(matd) != "")
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn loại thực đơn, món ăn này ra khỏi thực đơn của bữa này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Connect.GetStr(grvKH.GetFocusedRowCellValue(colIDKH)) != "")
                    Connect.ThaoTac("Delete * from tblkehoach where IDKH = " + Convert.ToInt64(Connect.GetStr(grvKH.GetFocusedRowCellValue(colIDKH))));
                uncheck(grvKH.GetFocusedRowCellValue(colMaMA), grvKH.GetFocusedRowCellValue(colMaTD));
                grvKH.DeleteSelectedRows();                
            }
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn loại toàn bộ thực đơn, món ăn này ra khỏi thực đơn của bữa này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < grvKH.RowCount; i++)
                {
                    if (Connect.GetStr(grvKH.GetRowCellValue(i, colIDKH)) != "")
                        Connect.ThaoTac("Delete * from tblkehoach where IDKH = " + Convert.ToInt64(Connect.GetStr(grvKH.GetRowCellValue(i, colIDKH))));
                }
                uncheckall();
                grcKH.DataSource = null;
                dtkh.Clear();
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < grvKH.RowCount; i++)
                {
                    if (Connect.GetStr(grvKH.GetRowCellValue(i, colIDKH)) == "0")
                    {
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = "Insert into tblkehoach (MaNT,Tuan,Ngaythang,MaTD,MaMA,TenBA,Tenbua) values (@MaNT,@Tuan,@Ngaythang,@MaTD,@MaMA,@TenBA,@Tenbua)";
                        cmd.Parameters.Add("@MaNT", OleDbType.VarChar).Value = cboNhomTuoi.EditValue;
                        cmd.Parameters.Add("@Tuan", OleDbType.VarChar).Value = DC1.tuanthu(txtngaythang.Text);
                        cmd.Parameters.Add("@Ngaythang", OleDbType.VarChar).Value = txtngaythang.Text;
                        cmd.Parameters.Add("@MaTD", OleDbType.VarChar).Value = grvKH.GetRowCellValue(i, colMaTD);
                        cmd.Parameters.Add("@MaMA", OleDbType.VarChar).Value = grvKH.GetRowCellValue(i, colMaMA);
                        cmd.Parameters.Add("@TenBA", OleDbType.VarChar).Value = cboBuaan.EditValue;
                        cmd.Parameters.Add("@Tenbua", OleDbType.VarChar).Value = grvKH.GetRowCellValue(i, colTenMA);
                        Connect.LuuDL(cmd);
                    }
                    if (Connect.GetDou(grvKH.GetRowCellValue(i, colIDKH)) > 0)
                    {
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = "Update tblkehoach set MaNT=@MaNT,Tuan=@Tuan,Ngaythang=@Ngaythang,MaTD=@MaTD,MaMA=@MaMA,TenBA=@TenBA,Tenbua=@Tenbua where IDKH = " + Convert.ToInt64(Connect.GetStr(grvKH.GetRowCellValue(i, colIDKH)));
                        cmd.Parameters.Add("@MaNT", OleDbType.VarChar).Value = cboNhomTuoi.EditValue;
                        cmd.Parameters.Add("@Tuan", OleDbType.VarChar).Value = DC1.tuanthu(txtngaythang.Text);
                        cmd.Parameters.Add("@Ngaythang", OleDbType.VarChar).Value = txtngaythang.Text;
                        cmd.Parameters.Add("@MaTD", OleDbType.VarChar).Value = grvKH.GetRowCellValue(i, colMaTD);
                        cmd.Parameters.Add("@MaMA", OleDbType.VarChar).Value = grvKH.GetRowCellValue(i, colMaMA);
                        cmd.Parameters.Add("@TenBA", OleDbType.VarChar).Value = cboBuaan.EditValue;
                        cmd.Parameters.Add("@Tenbua", OleDbType.VarChar).Value = grvKH.GetRowCellValue(i, colTenMA);
                        Connect.LuuDL(cmd);
                    }
                }                
                Connect.Reconnect();
                LuBuaan_EditValueChanged(sender, e);
                MessageBox.Show("Bạn đã lưu thành công!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình lưu dữ liệu. Bạn hãy kiểm tra lại!", "Thông báo");
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            buttonX1_Click(sender, e);
            this.Close();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string TenMA(string mama, string matd)
        {
            string kq = "";
            if (mama != "")
                kq = Connect.LayGT("Select distinct TenMA From tblmonan where MaMA = '" + mama + "'", "TenMA");
            if (matd != "")
                kq = Connect.LayGT("Select distinct TenTD From tblthucdon where MaTD = '" + matd + "'", "TenTD");
            return kq;
        }
 
        private void LuBuaan_EditValueChanged(object sender, EventArgs e)
        {
            dtkh.Clear();
            uncheckall();
            foreach (DataRow item in Connect.TruyVandt("Select * from tblkehoach" +
                " where MaNT = '" + Connect.GetStr(cboNhomTuoi.EditValue) + "' and Ngaythang = #" + classdc.dungchung.thaydoi(txtngaythang.Text) + "# " +
                " and TenBA = '" + Connect.GetStr(cboBuaan.EditValue) + "' ").Rows)
            {
                dtkh.Rows.Add(item["MaTD"], TenMA(item["MaMA"].ToString(), item["MaTD"].ToString()), item["MaMA"], item["IDKH"]);
            }
            grcKH.DataSource = null;
            grcKH.DataSource = dtkh;
            LoadTPCT();
        }        
    }
}
