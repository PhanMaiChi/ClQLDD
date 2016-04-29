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
    public partial class frmnhapnxct : Office2007Form
    {
        public DataRow nrow;
        public string decimalChar = "";
        public DataTable dtlv = new DataTable();
        public frmnhapnxct()
        {
            InitializeComponent();
        }

        private void frmnhapnxct_Load(object sender, EventArgs e)
        {
            decimalChar = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            if (decimalChar == ".")
                decimalChar = ",";
            lvtp.Visible = false;
            loadlv();
            button1.Visible = false;
            txtidnxct.Text = "";
            txtthtro.Text = "";
            txtntnx.Text = DateTime.Today.ToString();
            nguoinhanhang();
            nguoigiao();
            tenkho();
        }
        private void tenkho()
        {
            string sql = "Select tenkho From kho";
            DataTable dt = new DataTable();
            dt = Connect.TruyVandt(sql);
            cbkhonhapxuat.Items.Clear();
            cbkhonhapxuat.DataSource = dt;
            cbkhonhapxuat.DisplayMember = "tenkho";
            cbkhonhapxuat.ValueMember = "tenkho";
        }
        private void nguoinhanhang()
        {
            string sql = "Select htnnhang From nxct";
            DataTable dt = new DataTable();
            dt = Connect.TruyVandt(sql);
            cbhtnnhang.Items.Clear();
            cbhtnnhang.DataSource = dt;
            cbhtnnhang.DisplayMember = "htnnhang";
            cbhtnnhang.ValueMember = "htnnhang";
        }
        private void nguoigiao()
        {
            string sql = "Select nguoigiao From nxct";
            DataTable dt = new DataTable();
            dt = Connect.TruyVandt(sql);
            //cbhtnnhang.Items.Clear();
            cbnguoidao.DataSource = dt;
            cbnguoidao.DisplayMember = "nguoigiao";
            cbnguoidao.ValueMember = "nguoigiao";
        }
        private void grpdshs_Enter(object sender, EventArgs e)
        {

        }

        private void tbtThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbtLuu_Click(object sender, EventArgs e)
        {
            txtntnx.Text = DateTime.Today.ToString();
            txtidnxct.Text = "";
            txtthtro.Text = "";
            txtldnhapxuat.Text = "";
            string sql1 = "Select htnnhang From nxct where htnnhang like '" + cbkhonhapxuat.Text + "%' group by htnnhang";
            DataTable dt1 = Connect.TruyVandt(sql1);
            txtdcngnnhang.Text = (dt1.Rows.Count > 0 ? dt1.Rows[0]["htnnhang"].ToString() : "");
            
            string sql = "Select dd From kho where tenkho like '" + cbkhonhapxuat.Text + "%'";
            DataTable dt = Connect.TruyVandt(sql);
            txtdd.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["dd"].ToString():"");
            grcKQ.DataSource = null;
        }

        private void frmnhapnxct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                txtntnx.Text = DateTime.Today.ToString();
                txtidnxct.Text = "";
                txtthtro.Text = "";
                txtldnhapxuat.Text = "";
                string sql1 = "Select htnnhang From nxct where htnnhang like '" + cbkhonhapxuat.Text + "%' group by htnnhang";
                DataTable dt1 = Connect.TruyVandt(sql1);
                txtdcngnnhang.Text = (dt1.Rows.Count > 0 ? dt1.Rows[0]["htnnhang"].ToString() : "");

                string sql = "Select dd From kho where tenkho like '" + cbkhonhapxuat.Text + "%'";
                DataTable dt = Connect.TruyVandt(sql);
                txtdd.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["dd"].ToString() : "");
                grcKQ.DataSource = null;
            }
        }

        private void cbkhonhapxuat_TextChanged(object sender, EventArgs e)
        {
            string sql = "Select dd From kho where tenkho like '" + cbkhonhapxuat.Text + "%'";
            DataTable dt = Connect.TruyVandt(sql);
            txtdd.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["dd"].ToString() : "");
        }

        private void txtntnx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "Select * From nxct Where ntnx = #" + classdc.dungchung.thaydoi(txtntnx.Text) + "#";
                DataTable dt = Connect.TruyVandt(sql);
                //txtntnx.Text = DateTime.Today.ToString();
                cbhtnnhang.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["htnnhang"].ToString() : "");
                txtldnhapxuat.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["ldnhapxuat"].ToString() : "");
                cbkhonhapxuat.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["khonhapxuat"].ToString() : "");               
                txtdd.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["dd"].ToString() : "");
                txtidnxct.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["idnxct"].ToString() : "");
                txtdcngnnhang.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["dcngnnhang"].ToString() : "");
                txtthtro.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["thtro"].ToString() : "");

                DataTable dtxu = Connect.TruyVandt("Select Sum(BS) as BS,Sum(BC) as BC, Sum(BT) as BT From baoan Where ntan = #" + classdc.dungchung.thaydoi(txtntnx.Text) + "#");
                lbsoxuat.Text = "Tổng số xuất ăn: " + ((dtxu.Rows.Count > 0 ? classdc.dungchung.kieudouble(dtxu.Rows[0]["BS"].ToString()) : 0) + (dtxu.Rows.Count > 0 ? classdc.dungchung.kieudouble(dtxu.Rows[0]["BC"].ToString()) : 0) + (dtxu.Rows.Count > 0 ? classdc.dungchung.kieudouble(dtxu.Rows[0]["BT"].ToString()) : 0)).ToString() + "  trong đó bữa sáng: " + (dtxu.Rows.Count > 0 ? dtxu.Rows[0]["BS"].ToString() : "0") + ", bữa trưa: " + (dtxu.Rows.Count > 0 ? dtxu.Rows[0]["BC"].ToString() : "0") + ", bữa tối: " + (dtxu.Rows.Count > 0 ? dtxu.Rows[0]["BT"].ToString() : "0");
                l1.Text = ((dtxu.Rows.Count > 0 ? classdc.dungchung.kieudouble(dtxu.Rows[0]["BS"].ToString()) : 0) + (dtxu.Rows.Count > 0 ? classdc.dungchung.kieudouble(dtxu.Rows[0]["BC"].ToString()) : 0) + (dtxu.Rows.Count > 0 ? classdc.dungchung.kieudouble(dtxu.Rows[0]["BT"].ToString()) : 0)).ToString();
                lbsodc.Text = "Mức ăn (Sáng/Trưa/Chiều) 1 xuất: " + string.Format("{0:#" + decimalChar + "#}", classdc.dungchung.kieudouble(Settings1.Default.mucansang.ToString())) + "/" + string.Format("{0:#" + decimalChar + "#}", classdc.dungchung.kieudouble(Settings1.Default.mucan.ToString())) + "/" + string.Format("{0:#" + decimalChar + "#}", classdc.dungchung.kieudouble(Settings1.Default.mucantoi.ToString())) + " => số tiền được chi: " + string.Format("{0:#" + decimalChar + "#}", (((dtxu.Rows.Count > 0 ? classdc.dungchung.kieudouble(dtxu.Rows[0]["BS"].ToString()) : 0) * classdc.dungchung.kieudouble(Settings1.Default.mucansang.ToString()) + (dtxu.Rows.Count > 0 ? classdc.dungchung.kieudouble(dtxu.Rows[0]["BC"].ToString()) : 0) * classdc.dungchung.kieudouble(Settings1.Default.mucan.ToString()) + (dtxu.Rows.Count > 0 ? classdc.dungchung.kieudouble(dtxu.Rows[0]["BT"].ToString()) : 0)*classdc.dungchung.kieudouble(Settings1.Default.mucantoi.ToString())))) + " đồng.";
                grcKQ.DataSource = Connect.Loadgrc("Select * From nhxu where idnxct = " + classdc.dungchung.kieudouble(txtidnxct.Text));
            }
            catch
            {
            }
        }

        private void txtntnx_Leave(object sender, EventArgs e)
        {
            try
            {
                txtntnx.Text = clsbqkpbt.banquyen.dtngaysinh(txtntnx.Text);
            }
            catch
            {
                txtntnx.Text = "";
            }
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
        private void loadlv()
        {
            string sql = "Select * From dmtp";
            OleDbDataReader dr = Connect.TruyVandr(sql);
            lvtp.Items.Clear();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem();
                lv.Checked = false;
                lv.SubItems.Add(dr["matp"].ToString());
                lv.SubItems.Add(dr["tentp"].ToString());
                lv.SubItems.Add(dr["donvitinh"].ToString());
                lv.SubItems.Add(dr["chokho"].ToString());
                lv.SubItems.Add(string.Format("{0:0" + decimalChar + "0}", classdc.dungchung.kieudouble(dr["dongia"].ToString())));
                lv.SubItems.Add(dr["sogam"].ToString());
                lv.SubItems.Add("");
                lvtp.Items.Add(lv);
            }
            dr.Close();
        }
        private void loaddtlv()
        {
            if (dtlv.Rows.Count > 0)
                dtlv.Rows.Clear();
            for (int i = 0; i < grvKQ.RowCount; i++)
            {                
                nrow = dtlv.NewRow();
                nrow["idnhxu"] = grvKQ.GetRowCellValue(i, colidnhxu);
                nrow["idnxct"] = grvKQ.GetRowCellValue(i, colidnxct);
                nrow["matp"] = grvKQ.GetRowCellValue(i, colmatp);
                nrow["tentp"] = grvKQ.GetRowCellValue(i, coltentp);
                nrow["donvitinh"] = grvKQ.GetRowCellValue(i, coldonvitinh);
                nrow["dongia"] = grvKQ.GetRowCellValue(i, coldongia);
                nrow["chokho"] = grvKQ.GetRowCellValue(i, colchokho);
                nrow["slnh"] = grvKQ.GetRowCellValue(i, colslnh);
                nrow["slxu"] = grvKQ.GetRowCellValue(i, colslxu);
                nrow["ttnh"] = grvKQ.GetRowCellValue(i, colttnh);
                nrow["ttxu"] = grvKQ.GetRowCellValue(i, colttxu);
                nrow["chatluong"] = grvKQ.GetRowCellValue(i, colchatluong);
                nrow["STT"] = grvKQ.GetRowCellValue(i, colSTT);
                dtlv.Rows.Add(nrow);                
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {            
            dtlv = Connect.Loadgrc("Select * From nhxu where idnxct = " + classdc.dungchung.kieudouble(txtidnxct.Text));
            loaddtlv();
            lvtp.Visible = true;
            button1.Visible = true;
            for (int i = 0; i < grvKQ.RowCount; i++)
            {
                for (int j = 0; j < lvtp.Items.Count; j++)
                {
                    if (grvKQ.GetRowCellValue(i, colmatp).ToString() == lvtp.Items[j].SubItems[1].Text)
                    {
                        lvtp.Items[j].Checked = true;
                        lvtp.Items[j].SubItems[7].Text = "Có";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvtp.Items.Count; i++)
            {
                if ((lvtp.Items[i].Checked == true) && (lvtp.Items[i].SubItems[7].Text == ""))
                {                    
                    nrow = dtlv.NewRow();
                    nrow["idnhxu"] = 0;
                    nrow["idnxct"] = 0;
                    nrow["matp"] = lvtp.Items[i].SubItems[1].Text;
                    nrow["tentp"] = lvtp.Items[i].SubItems[2].Text;
                    nrow["donvitinh"] = lvtp.Items[i].SubItems[3].Text;
                    nrow["dongia"] = classdc.dungchung.kieudouble(lvtp.Items[i].SubItems[5].Text);
                    nrow["chokho"] = lvtp.Items[i].SubItems[4].Text;
                    nrow["slnh"] = 0;
                    nrow["slxu"] = slxuat(lvtp.Items[i].SubItems[1].Text);
                    nrow["ttnh"] = 0;
                    nrow["ttxu"] = slxuat(lvtp.Items[i].SubItems[1].Text) * classdc.dungchung.kieudouble(lvtp.Items[i].SubItems[5].Text);
                    nrow["chatluong"] = "";
                    nrow["STT"] = dtlv.Rows.Count + 1;
                    dtlv.Rows.Add(nrow);   
                }
            }
            lvtp.Visible = false;
            button1.Visible = false;
            grcKQ.DataSource = dtlv;
            //MessageBox.Show(dtlv.Rows.Count.ToString());
        }
        private double slxuat(string matp)
        {
            double kq = 0;
            DataTable dt = Connect.TruyVandt("Select sogam From dmtp where matp = '" + matp + "' and sogam > 0");
            kq = (classdc.dungchung.kieudouble((dt.Rows.Count > 0 ? dt.Rows[0]["sogam"].ToString() : "0"))*classdc.dungchung.kieudouble(l1.Text))/1000;
            return kq;
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (txtidnxct.Text != "")
            {
                updatenxct();
            }
            else
            {
                insertnxct();
                string sql = "Select * From nxct order by idnxct";
                DataTable dt = Connect.TruyVandt(sql);
                txtidnxct.Text = dt.Rows[dt.Rows.Count - 1]["idnxct"].ToString();
                txtdcngnnhang.Text = dt.Rows[dt.Rows.Count - 1]["dcngnnhang"].ToString();
            }
            capnhatct();
        }
        private void insertnxct()
        {
            System.Globalization.CultureInfo cultuere = new System.Globalization.CultureInfo("vi-VN");
            cultuere.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            string sql = "Insert into nxct(ntnx,htnnhang,dcngnnhang,ldnhapxuat,khonhapxuat,dd,thtro,nguoigiao,theo) values(@ntnx,@htnnhang,@dcngnnhang,@ldnhapxuat,@khonhapxuat,@dd,@thtro,@nguoigiao,@theo)";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@ntnx", OleDbType.Date).Value = Convert.ToDateTime(txtntnx.Text);
            cmd.Parameters.Add("@htnnhang", OleDbType.VarChar).Value = cbhtnnhang.Text;
            cmd.Parameters.Add("@dcngnnhang", OleDbType.VarChar).Value = txtdcngnnhang.Text;
            cmd.Parameters.Add("@ldnhapxuat", OleDbType.VarChar).Value = txtldnhapxuat.Text;
            cmd.Parameters.Add("@khonhapxuat", OleDbType.VarChar).Value = cbkhonhapxuat.Text;
            cmd.Parameters.Add("@dd", OleDbType.VarChar).Value = txtdd.Text;
            cmd.Parameters.Add("@thtro", OleDbType.Double).Value = classdc.dungchung.kieudouble(txtthtro.Text);
            cmd.Parameters.Add("@nguoigiao", OleDbType.VarChar).Value = cbnguoidao.Text;
            cmd.Parameters.Add("@theo", OleDbType.VarChar).Value = txttheo.Text;
            Connect.LuuDL(cmd);
        }
        private void updatenxct()
        {
            System.Globalization.CultureInfo cultuere = new System.Globalization.CultureInfo("vi-VN");
            cultuere.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            string sql = "Update nxct set ntnx=@ntnx,htnnhang=@htnnhang,dcngnnhang=@dcngnnhang,ldnhapxuat=@ldnhapxuat,khonhapxuat=@khonhapxuat,dd=@dd,thtro=@thtro,nguoigiao=@nguoigiao,theo=@theo where idnxct = " + Convert.ToInt64(txtidnxct.Text);
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@ntnx", OleDbType.Date).Value = Convert.ToDateTime(txtntnx.Text);
            cmd.Parameters.Add("@htnnhang", OleDbType.VarChar).Value = cbhtnnhang.Text;
            cmd.Parameters.Add("@dcngnnhang", OleDbType.VarChar).Value = txtdcngnnhang.Text;
            cmd.Parameters.Add("@ldnhapxuat", OleDbType.VarChar).Value = txtldnhapxuat.Text;
            cmd.Parameters.Add("@khonhapxuat", OleDbType.VarChar).Value = cbkhonhapxuat.Text;
            cmd.Parameters.Add("@dd", OleDbType.VarChar).Value = txtdd.Text;
            cmd.Parameters.Add("@thtro", OleDbType.Double).Value = classdc.dungchung.kieudouble(txtthtro.Text);
            cmd.Parameters.Add("@nguoigiao", OleDbType.VarChar).Value = cbnguoidao.Text;
            cmd.Parameters.Add("@theo", OleDbType.VarChar).Value = txttheo.Text;
            Connect.LuuDL(cmd);
        }
        private void capnhatct()
        {
            for (int i = 0; i < grvKQ.RowCount; i++)
            {
                if (Convert.ToInt64(grvKQ.GetRowCellValue(i, colidnhxu).ToString()) > 0)
                {
                    string sqlup = "Update nhxu set dongia=@dongia,slnh=@slnh,slxu=@slxu,ttnh=@ttnh,ttxu=@ttxu,chatluong=@chatluong Where idnhxu = " + grvKQ.GetRowCellValue(i, colidnhxu);
                    OleDbCommand cmdup = new OleDbCommand();
                    cmdup.CommandText = sqlup;
                    cmdup.Parameters.Add("@dongia", OleDbType.Double).Value = grvKQ.GetRowCellValue(i, coldongia);
                    cmdup.Parameters.Add("@slnh", OleDbType.Double).Value = grvKQ.GetRowCellValue(i, colslnh);
                    cmdup.Parameters.Add("@slxu", OleDbType.Double).Value = grvKQ.GetRowCellValue(i, colslxu);
                    cmdup.Parameters.Add("@ttnh", OleDbType.Double).Value = grvKQ.GetRowCellValue(i, colttnh);
                    cmdup.Parameters.Add("@ttxu", OleDbType.Double).Value = grvKQ.GetRowCellValue(i, colttxu);
                    cmdup.Parameters.Add("@chatluong", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colchatluong);
                    Connect.LuuDL(cmdup);
                }
                else
                {
                    string sqlin = "Insert into nhxu(idnxct,matp,tentp,donvitinh,dongia,chokho,slnh,slxu,ttnh,ttxu,chatluong) values(@idnxct,@matp,@tentp,@donvitinh,@dongia,@chokho,@slnh,@slxu,@ttnh,@ttxu,@chatluong)";
                    OleDbCommand cmdin = new OleDbCommand();
                    cmdin.CommandText = sqlin;
                    cmdin.Parameters.Add("@idnxct", OleDbType.Double).Value = classdc.dungchung.kieudouble(txtidnxct.Text);
                    cmdin.Parameters.Add("@matp", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colmatp);
                    cmdin.Parameters.Add("@tentp", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, coltentp);
                    cmdin.Parameters.Add("@donvitinh", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, coldonvitinh);
                    cmdin.Parameters.Add("@dongia", OleDbType.Double).Value = grvKQ.GetRowCellValue(i, coldongia);
                    cmdin.Parameters.Add("@chokho", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colchokho);                    
                    cmdin.Parameters.Add("@slnh", OleDbType.Double).Value = grvKQ.GetRowCellValue(i, colslnh);
                    cmdin.Parameters.Add("@slxu", OleDbType.Double).Value = grvKQ.GetRowCellValue(i, colslxu);
                    cmdin.Parameters.Add("@ttnh", OleDbType.Double).Value = grvKQ.GetRowCellValue(i, colttnh);
                    cmdin.Parameters.Add("@ttxu", OleDbType.Double).Value = grvKQ.GetRowCellValue(i, colttxu);
                    cmdin.Parameters.Add("@chatluong", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colchatluong);
                    Connect.LuuDL(cmdin);
                }
            }
        }

        private void grvKQ_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "slnh")
                grvKQ.SetFocusedRowCellValue(colttnh, classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(coldongia).ToString()) * classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(colslnh).ToString()));
            if (e.Column.FieldName == "slxu")
                grvKQ.SetFocusedRowCellValue(colttxu, classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(coldongia).ToString()) * classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(colslxu).ToString()));
            if ((e.Column.FieldName == "slnh") && (grvKQ.GetFocusedRowCellValue(colchokho).ToString() == "Chợ"))
            {
                grvKQ.SetFocusedRowCellValue(colslxu, classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(colslnh).ToString()));
            }
        }

        private void tbtXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string sql = "Delete * From nhxu Where idnxct = " + classdc.dungchung.kieudouble(txtidnxct.Text);
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = sql;
                    Connect.LuuDL(cmd);
                    grcKQ.DataSource = null;
                    string sqlct = "Delete * From nxct Where idnxct = " + Convert.ToInt64(txtidnxct.Text);
                    OleDbCommand cmdct = new OleDbCommand();
                    cmdct.CommandText = sqlct;
                    Connect.LuuDL(cmdct);
                    txtntnx.Text = DateTime.Today.ToString();
                    txtidnxct.Text = "";
                    txtthtro.Text = "";
                    txtldnhapxuat.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi khi xóa, hãy kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string sql = "Delete * From nhxu Where idnhxu = " + Convert.ToInt64(grvKQ.GetFocusedRowCellValue(colidnhxu).ToString());
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = sql;
                    Connect.LuuDL(cmd);
                    grvKQ.DeleteSelectedRows();
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi khi xóa, hãy kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void sổChợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] st = txtntnx.Text.Split('/');
            Connect.ThaoTac("Delete * From TblDC");
            clsocho.appdc(txtntnx.Text);
            clsocho.updc(txtntnx.Text);
            DataSet dts = new DataSet();
            Connect.Loadds(dts, "Select * From TblDC order by TEN1", "TblDC");
            Forms.frmHienThi frm = new Forms.frmHienThi();
            Reports.SoCHO rpt = new KPBT.Reports.SoCHO();
            rpt.NTN.Value = "Ngày " + st[0] + " tháng " + st[1] + " năm " + st[2];
            rpt.TenDV.Value = thongtinketxuat.Default.tendv.ToString();
            rpt.SoXAn.Value = "Số xuất ăn: " + string.Format("{0:#" + decimalChar + "#}", (clsocho.xuatanS(txtntnx.Text) + clsocho.xuatanT(txtntnx.Text) + clsocho.xuatanC(txtntnx.Text)));
            rpt.SoXuat.Value = clsocho.xuatanS(txtntnx.Text) + clsocho.xuatanT(txtntnx.Text) + clsocho.xuatanC(txtntnx.Text);
            rpt.SoDuDN.Value = "";
            rpt.MuAn.Value = string.Format("{0:#" + decimalChar + "#}", clsocho.mucansang(txtntnx.Text)) + "/" + string.Format("{0:#" + decimalChar + "#}", clsocho.mucantrua(txtntnx.Text)) + "/" + string.Format("{0:#" + decimalChar + "#}", clsocho.mucantoi(txtntnx.Text));
            rpt.SoDChi.Value = clsocho.xuatanS(txtntnx.Text) * clsocho.mucansang(txtntnx.Text) + clsocho.xuatanT(txtntnx.Text) * clsocho.mucantrua(txtntnx.Text) + clsocho.xuatanC(txtntnx.Text) * clsocho.mucantoi(txtntnx.Text);
            rpt.TBSang.Value = string.Format("{0:#" + decimalChar + "#}", clsocho.xuatanS(txtntnx.Text) * clsocho.mucansang(txtntnx.Text));
            rpt.TBTrua.Value = string.Format("{0:#" + decimalChar + "#}", clsocho.xuatanT(txtntnx.Text) * clsocho.mucantrua(txtntnx.Text));
            rpt.TBToi.Value = string.Format("{0:#" + decimalChar + "#}", clsocho.xuatanC(txtntnx.Text) * clsocho.mucantoi(txtntnx.Text));
            rpt.DataSource = dts;
            frm.printControl1.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
            frm.ShowDialog();
        }

        private void phiếuXuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtidnxct.Text != "")
            {
                string[] str = txtntnx.Text.Split('/');
                DataSet dts = new DataSet();
                Connect.Loadds(dts, "Select * From nhxu where idnxct = " + classdc.dungchung.kieudouble(txtidnxct.Text), "nhxu");
                Forms.frmHienThi frm = new Forms.frmHienThi();
                Reports.PhXKho rpt = new KPBT.Reports.PhXKho();
                rpt.TenDV.Value = "Đơn vị:" + thongtinketxuat.Default.tendv.ToString().ToUpper();
                rpt.BP.Value = "Bộ phận: ";
                rpt.MaDV.Value = "Mã đơn vị SDNS: " + thongtinketxuat.Default.madvqhns.ToString();
                rpt.NTN.Value = "Ngày " + str[0] + " tháng " + str[1] + " năm " + str[2];
                rpt.Co.Value = "Có: ";
                rpt.No.Value = "Nợ: ";
                rpt.So.Value = "Số: " + txtidnxct.Text;
                rpt.nguoinhanhang.Value = cbhtnnhang.Text;
                rpt.daichi.Value = txtdcngnnhang.Text;
                rpt.ldxk.Value = txtldnhapxuat.Text;
                rpt.taikho.Value = cbkhonhapxuat.Text;
                rpt.dd.Value = txtdd.Text;
                rpt.TongTBC.Value = "Tổng số tiền (viết bằng chữ): " + classdc.dungchung.So_chu(classdc.dungchung.kieudouble(colttxu.SummaryItem.SummaryValue.ToString()));
                rpt.SoCTKT.Value = "Số chứng từ kèm theo: ";
                rpt.nlb.Value = thongtinketxuat.Default.nlb.ToString();
                rpt.thukho.Value = thongtinketxuat.Default.thukho.ToString();
                rpt.ptkt.Value = thongtinketxuat.Default.ptkt.ToString();
                rpt.ttdv.Value = thongtinketxuat.Default.ttdv.ToString();
                rpt.DataSource = dts;
                frm.printControl1.PrintingSystem = rpt.PrintingSystem;
                rpt.CreateDocument();
                frm.ShowDialog();
            }
        }

        private void phiếuNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] str = txtntnx.Text.Split('/');
            DataSet dts = new DataSet();
            Connect.Loadds(dts, "Select * From nhxu where idnxct = " + classdc.dungchung.kieudouble(txtidnxct.Text), "nhxu");
            Forms.frmHienThi frm = new Forms.frmHienThi();
            Reports.PhNKho rpt = new KPBT.Reports.PhNKho();
            rpt.TenDV.Value = "Đơn vị:" + thongtinketxuat.Default.tendv.ToString().ToUpper();
            rpt.BP.Value = "Bộ phận: ";
            //rpt.MaDV.Value = "Mã đơn vị SDNS: " + thongtinketxuat.Default.madvqhns.ToString();
            rpt.NTN.Value = "Ngày " + str[0] + " tháng " + str[1] + " năm " + str[2];
            rpt.Co.Value = "Có: ";
            rpt.No.Value = "Nợ: ";
            rpt.So.Value = "Số: " + txtidnxct.Text;
            rpt.nguoigiao.Value = cbnguoidao.Text;
            
            rpt.theo.Value = txttheo.Text;
            rpt.taikho.Value = cbkhonhapxuat.Text;
            rpt.dd.Value = txtdd.Text;
            rpt.TongTBC.Value = "Tổng số tiền (viết bằng chữ): " + classdc.dungchung.So_chu(classdc.dungchung.kieudouble(colttnh.SummaryItem.SummaryValue.ToString()));
            rpt.SoCTKT.Value = "Số chứng từ kèm theo: ";
            rpt.nlb.Value = thongtinketxuat.Default.nlb.ToString();
            rpt.thukho.Value = thongtinketxuat.Default.thukho.ToString();
            rpt.ptkt.Value = thongtinketxuat.Default.ptkt.ToString();
            
            rpt.DataSource = dts;
            frm.printControl1.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
            frm.ShowDialog();
        }

        private void txtthtro_TextChanged(object sender, EventArgs e)
        {
            txtthtro.Text = string.Format("{0:#" + decimalChar + "#}", classdc.dungchung.kieudouble(txtthtro.Text));
            SendKeys.Send("{End}");
        }

        private void frmnhapnxct_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }
    }
}
