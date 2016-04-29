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

namespace KPBT.Forms
{
    public partial class frmTDSKHS : Office2007Form
    {
        public DataTable dt;
        public DataTable dtdk;
        public string sql = "";        
        public frmTDSKHS()
        {
            InitializeComponent();
        }

        private void frmTDSKHS_Load(object sender, EventArgs e)
        {
            phong();
            dt = new DataTable();
            KPBT.Modules.dcts.taoTG(false, dt, "STT", "TEN1", "TEN2", "TEN3", "TEN4", "NTCT", "TEN6", "SL1", "SL2", "TEN7", "TEN8");
            grcKQ.DataSource = dt;            
        }
        private void phong()
        {
            sql = "Select * From phong";
            DataTable dt = KPBT.Modules.Connect.TruyVandt(sql);
            cbtenphongb.Items.Clear();
            cbtenphongb.DataSource = dt;
            cbtenphongb.DisplayMember = "tenphong";
            cbtenphongb.ValueMember = "tenphong";
        }
        private void tbtThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string kt(string ngaydanhgia, string lop)
        {
            string kq = "";
            string sql = "Select theodoisk.ngaydanhgia,hocsinh.tenphong" +
                " From theodoisk inner join hocsinh on theodoisk.mahocsinh = hocsinh.mshs" +
                " where theodoisk.ngaydanhgia = #" + classdc.dungchung.thaydoi(ngaydanhgia) + "# and hocsinh.tenphong = '" + lop + "'";
            System.Data.OleDb.OleDbDataReader dr = KPBT.Modules.Connect.TruyVandr(sql);
            while (dr.Read())
            {
                kq = "C";
            }
            dr.Close();
            return kq;
        }
        private void MtbNTDG_Leave(object sender, EventArgs e)
        {
            try
            {
                MtbNTDG.Text = DC1.ngaythang(MtbNTDG.Text);
            }
            catch
            {
                MtbNTDG.Text = DC1.ngaythang(DateTime.Now.ToString());
            }
            cbtenphongb_SelectedIndexChanged(sender, e);
        }

        private void frmTDSKHS_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }

        private void cbtenphongb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbtenphongb.Text != "" && MtbNTDG.Text != "  /  /" && ckbHS.Checked == false)
            {
                if (kt(MtbNTDG.Text, cbtenphongb.Text) == "")
                {
                    sql = "SELECT mshs as TEN1,tenphong as TEN2, tenhs as TEN3, gths as TEN4, ntns as NTCT," +
                    " CInt((CDate(Format('" + MtbNTDG.Text + "','dd/mm/yyyy'))-CDate(Format([ntns],'dd/mm/yyyy')))/30) AS TEN6" +
                    " FROM hocsinh where tenphong = '" + cbtenphongb.Text + "'";
                    System.Data.OleDb.OleDbDataReader dr = KPBT.Modules.Connect.TruyVandr(sql);
                    DataTable dtdk = new DataTable();
                    dtdk.Load(dr);
                    dt.Rows.Clear();
                    foreach (DataRow item in dtdk.Rows)
                    {
                        dt.ImportRow(item);
                    }
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dt.Rows[i]["STT"] = i + 1;
                        }
                    }
                    grcKQ.DataSource = dt;
                }
                else
                {
                    sql = "Select theodoisk.mahocsinh as TEN1, hocsinh.tenphong as TEN2, hocsinh.tenhs as TEN3, hocsinh.gths as TEN4," +
                        " hocsinh.ntns as NTCT, theodoisk.sothangtuoi as TEN6, theodoisk.cannang as SL2, theodoisk.chieucao as SL1," +
                        " theodoisk.danhgia as TEN7, theodoisk.idtheodoisk as TEN8" +
                        " From theodoisk inner join hocsinh on theodoisk.mahocsinh = hocsinh.mshs" +
                        " where theodoisk.ngaydanhgia = #" + classdc.dungchung.thaydoi(MtbNTDG.Text) + "# and theodoisk.mahocsinh in (Select mshs From hocsinh where tenphong = '" + cbtenphongb.Text + "' )";
                    System.Data.OleDb.OleDbDataReader dr = KPBT.Modules.Connect.TruyVandr(sql);
                    DataTable dtdk = new DataTable();
                    dtdk.Load(dr);
                    dt.Rows.Clear();
                    foreach (DataRow item in dtdk.Rows)
                    {
                        dt.ImportRow(item);
                    }
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dt.Rows[i]["STT"] = i + 1;
                        }
                    }
                    grcKQ.DataSource = dt;
                }
            }
        }
        private double BMI(string cannang, string chieucao)
        {
            double kq = 0;
            kq = (classdc.dungchung.kieudouble(cannang) * 10000) / (classdc.dungchung.kieudouble(chieucao) * classdc.dungchung.kieudouble(chieucao));
            return kq;
        }
        private string laydanhgia(string cannang, string gioitinh, string thangtuoi, string chieucao)
        {
            string kq = "";
            System.Data.OleDb.OleDbDataReader dr = KPBT.Modules.Connect.TruyVandr("Select * From tblBMI ");
            while (dr.Read())
            {
                if (gioitinh == dr["gioitinh"].ToString())
                {
                    if (double.Parse(thangtuoi) == double.Parse(dr["thang"].ToString()))
                    {
                        if (BMI(cannang, chieucao) <= double.Parse(dr["SD3duoi"].ToString()))                            
                            kq = "Rất gầy";
                        if (BMI(cannang, chieucao) <= double.Parse(dr["SD2duoi"].ToString()) && BMI(cannang, chieucao) > double.Parse(dr["SD3duoi"].ToString()))
                            kq = "Gầy";
                        if (BMI(cannang, chieucao) < double.Parse(dr["SD1tren"].ToString()) && BMI(cannang, chieucao) > double.Parse(dr["SD2duoi"].ToString()))
                            kq = "Bình thường";
                        if (BMI(cannang, chieucao) < double.Parse(dr["SD2tren"].ToString()) && BMI(cannang, chieucao) >= double.Parse(dr["SD1tren"].ToString()))
                            kq = "Thừa cân";
                        if (BMI(cannang, chieucao) >= double.Parse(dr["SD2tren"].ToString()))
                            kq = "Béo phì";
                    }
                }
            }
            dr.Close();
            return kq;
        }
        private void grvKQ_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
           
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (grvKQ.RowCount > 0)
                {
                    if (kt(MtbNTDG.Text, cbtenphongb.Text) == "")
                    {
                        for (int i = 0; i < grvKQ.RowCount; i++)
                        {
                            sql = "insert into theodoisk (ngaydanhgia,mahocsinh,sothangtuoi,cannang,chieucao,danhgia) values (@ngaydanhgia,@mahocsinh,@sothangtuoi,@cannang,@chieucao,@danhgia)";
                            System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
                            cmd.CommandText = sql;
                            cmd.Parameters.Add("@ngaydanhgia", System.Data.OleDb.OleDbType.Date).Value = Convert.ToDateTime(MtbNTDG.Text);
                            cmd.Parameters.Add("@mahocsinh", System.Data.OleDb.OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colmshs);
                            cmd.Parameters.Add("@sothangtuoi", System.Data.OleDb.OleDbType.Double).Value = Connect.GetDou(grvKQ.GetRowCellValue(i, colsothangtuoi));
                            cmd.Parameters.Add("@cannang", System.Data.OleDb.OleDbType.Double).Value = Connect.GetDou(grvKQ.GetRowCellValue(i, colcannang).ToString());
                            cmd.Parameters.Add("@chieucao", System.Data.OleDb.OleDbType.Double).Value = Connect.GetDou(grvKQ.GetRowCellValue(i, colchieucao).ToString());
                            cmd.Parameters.Add("@danhgia", System.Data.OleDb.OleDbType.VarChar).Value = Connect.GetStr(grvKQ.GetRowCellValue(i, coldanhgia));
                            KPBT.Modules.Connect.LuuDL(cmd);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < grvKQ.RowCount; i++)
                        {
                            sql = "update theodoisk set ngaydanhgia=@ngaydanhgia,mahocsinh=@mahocsinh,sothangtuoi=@sothangtuoi,cannang=@cannang,chieucao=@chieucao,danhgia=@danhgia" +
                                " where idtheodoisk =" + Convert.ToInt64(grvKQ.GetRowCellValue(i, colid).ToString());
                            System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
                            cmd.CommandText = sql;
                            cmd.Parameters.Add("@ngaydanhgia", System.Data.OleDb.OleDbType.Date).Value = Convert.ToDateTime(MtbNTDG.Text);
                            cmd.Parameters.Add("@mahocsinh", System.Data.OleDb.OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colmshs);
                            cmd.Parameters.Add("@sothangtuoi", System.Data.OleDb.OleDbType.Double).Value = Connect.GetDou(grvKQ.GetRowCellValue(i, colsothangtuoi));
                            cmd.Parameters.Add("@cannang", System.Data.OleDb.OleDbType.Double).Value = Connect.GetDou(grvKQ.GetRowCellValue(i, colcannang).ToString());
                            cmd.Parameters.Add("@chieucao", System.Data.OleDb.OleDbType.Double).Value = Connect.GetDou(grvKQ.GetRowCellValue(i, colchieucao).ToString());
                            cmd.Parameters.Add("@danhgia", System.Data.OleDb.OleDbType.VarChar).Value = Connect.GetStr(grvKQ.GetRowCellValue(i, coldanhgia));
                            KPBT.Modules.Connect.LuuDL(cmd);
                        }
                    }
                }
                MessageBox.Show("Bạn đã lưu dữ liệu thành công!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình lưu. Bạn hãy kiểm tra lại!", "Thông báo!");
            }
        }

        private void grvKQ_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "SL2" || e.Column.FieldName == "SL1")
                if (grvKQ.GetFocusedRowCellValue(colcannang).ToString() != "" && grvKQ.GetFocusedRowCellValue(colchieucao).ToString() != "")
                {
                    grvKQ.SetFocusedRowCellValue(coldanhgia, laydanhgia(Connect.GetStr(grvKQ.GetFocusedRowCellValue(colcannang)), Connect.GetStr(grvKQ.GetFocusedRowCellValue(colgths)), Connect.GetStr(grvKQ.GetFocusedRowCellValue(colsothangtuoi)),Connect.GetStr(grvKQ.GetFocusedRowCellValue(colchieucao))));
                }
            }
            catch { }
        }

        private void tbtIn_ButtonClick(object sender, EventArgs e)
        {

        }

        private void tbtXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa đánh giá này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < grvKQ.RowCount; i++)
                {
                    Connect.ThaoTac("Delete * From theodoisk where ngaydanhgia = #" + classdc.dungchung.thaydoi(MtbNTDG.Text) + "# and mahocsinh = '" + Connect.GetStr(grvKQ.GetRowCellValue(i, colmshs)) + "'");
                }
                cbtenphongb_SelectedIndexChanged(sender, e);
            }
        }        
    }
}
