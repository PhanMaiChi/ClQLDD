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
    public partial class frmnhapnxtpmn : Office2007Form
    {
       // public string chinhsang = "", chinhchieu = "", phu = "";
        public string decimalChar = "";
        public DataRow nrow;
        public DataTable dtlv = new DataTable();
        public DataTable dtkq = new DataTable();
        public frmnhapnxtpmn()
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
            dtlv = Connect.Loadgrc("Select * From nhxu where idnxct <> 0 and idnxct = " + classdc.dungchung.kieudouble(txtidnxct.Text));
            dtlv.Rows.Clear();
            loaddtlv();
            txtntnx.Text = DateTime.Today.ToString();
            Connect.LoadCBB(cbhtnnhang, "htnnhang", Connect.TruyVandt("Select htnnhang From nxct"));
            Connect.LoadCBB(cbnguoigiao, "nguoigiao", Connect.TruyVandt("Select nguoigiao From nxct"));
            Connect.LoadCBB(cbkhonhapxuat, "khonhapxuat", Connect.TruyVandt("Select khonhapxuat From nxct"));
            Connect.LoadCBB(cbhtnxhang, "htnxhang", Connect.TruyVandt("Select htnxhang From nxct"));
            txtntnx.Focus();
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
                nrow["STT"] = grvKQ.GetRowCellValue(i, colSTT);
                dtlv.Rows.Add(nrow);
            }
        }
        private void LoadTPCT()
        {
            dtlv = Connect.Loadgrc("Select * From nhxu where idnxct <> 0 and idnxct = " + classdc.dungchung.kieudouble(txtidnxct.Text));
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
        private void txtntnx_Leave(object sender, EventArgs e)
        {
            try
            {
                txtntnx.Text = clsbqkpbt.banquyen.dtngaysinh(txtntnx.Text);
            }
            catch
            {
                txtntnx.Text = string.Format("{0:dd/MM/yyyy}", DateTime.Today);
            }
            try
            {
                string sql = "Select * From nxct Where idnxct <> 0 and  ntnx = #" + classdc.dungchung.thaydoi(txtntnx.Text) + "#";
                DataTable dt = Connect.TruyVandt(sql);
                //txtntnx.Text = DateTime.Today.ToString();
                cbhtnnhang.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["htnnhang"].ToString() : "");
                cbnguoigiao.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["nguoigiao"].ToString() : "");
                txtldnhapxuat.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["ldnhapxuat"].ToString() : "");
                cbkhonhapxuat.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["khonhapxuat"].ToString() : "");
                txtdd.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["dd"].ToString() : "");
                txttheo.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["theo"].ToString() : "");
                cbhtnxhang.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["htnxhang"].ToString() : "");
                txtldnhapxuatx.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["ldnhapxuatx"].ToString() : "");
                txtthtro.Text = string.Format("{0:#" + decimalChar + "#}", classdc.dungchung.kieudouble((dt.Rows.Count > 0 ? dt.Rows[0]["thtro"].ToString() : "")));
                txtidnxct.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["idnxct"].ToString() : "");
                txtchibosung.Text = string.Format("{0:#" + decimalChar + "#}", classdc.dungchung.kieudouble((dt.Rows.Count > 0 ? dt.Rows[0]["chibosung"].ToString() : "")));
                // Bữa ăn
                cbtenbcsnt.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["tenbcsnt"].ToString() : "");
                cbtenbccnt.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["tenbccnt"].ToString() : "");
                cbtenbpnt.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["tenbpnt"].ToString() : "");
                cbtenbcsmg.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["tenbcsmg"].ToString() : "");
                cbtenbccmg.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["tenbccmg"].ToString() : "");
                cbtenbpmg.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["tenbpmg"].ToString() : "");

                DataTable dtxu = Connect.TruyVandt("Select BS,nhatre,MASANG From baoanhangngay Where ntan = #" + classdc.dungchung.thaydoi(txtntnx.Text) + "#");
                double tongxa = 0, nt = 0, mg = 0, mucan = 0;
                if (dtxu.Rows.Count > 0)
                {
                    for (int i = 0; i < dtxu.Rows.Count; i++)
                    {
                        mucan = classdc.dungchung.kieudouble(dtxu.Rows[0]["MASANG"].ToString());
                        tongxa = tongxa + classdc.dungchung.kieudouble(dtxu.Rows[i]["BS"].ToString());
                        if (dtxu.Rows[i]["nhatre"].ToString() == "Nhà trẻ")
                            nt = nt + classdc.dungchung.kieudouble(dtxu.Rows[i]["BS"].ToString());
                        if (dtxu.Rows[i]["nhatre"].ToString() == "Mẫu giáo")
                            mg = mg + classdc.dungchung.kieudouble(dtxu.Rows[i]["BS"].ToString());
                    }
                }
                dtlv = Connect.Loadgrc("Select * From nhxu where idnxct <> 0 and idnxct = " + classdc.dungchung.kieudouble(txtidnxct.Text));
                lbsoxuat.Text = "Tổng số xuất ăn: " + tongxa.ToString() + " (NT: " + nt.ToString() + ", MG: " + mg.ToString() + ")";
                if (txtidnxct.Text == "")
                {
                    dsmonan();
                    // Bữa ăn
                    cbtenbcsnt.Text = tenba("Chính sáng", "Nhà trẻ");
                    cbtenbccnt.Text = tenba("Chính chiều", "Nhà trẻ");
                    cbtenbpnt.Text = tenba("Phụ", "Nhà trẻ");
                    cbtenbcsmg.Text = tenba("Chính sáng", "Mẫu giáo");
                    cbtenbccmg.Text = tenba("Chính chiều", "Mẫu giáo");
                    cbtenbpmg.Text = tenba("Phụ", "Mẫu giáo");

                }
                grcKQ.DataSource = dtlv;
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
                //lbsodc.Text = "Số được chi: " + string.Format("{0:#" + decimalChar + "#}", tongxa * mucan);
                //dtlv = Connect.Loadgrc("Select * From nhxu where idnxct = " + classdc.dungchung.kieudouble(txtidnxct.Text));
                //grcKQ.DataSource = Connect.Loadgrc("Select * From nhxu where idnxct = " + classdc.dungchung.kieudouble(txtidnxct.Text));
            }
            catch
            {
            }
        }       
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //try
            //{
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
                }
                capnhatct();
                MessageBox.Show("Bạn đã lưu dữ liệu thành công!","Thông báo");
            //}
            //catch (Exception loi)
            //{
            //    MessageBox.Show(" Lỗi " + loi + " Bạn hãy kiểm tra lại dữ liệu nhập", "Thông báo");
            //}
        }
        private void insertnxct()
        {
            System.Globalization.CultureInfo cultuere = new System.Globalization.CultureInfo("vi-VN");
            cultuere.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            string sql = "Insert into nxct(ntnx,htnnhang,nguoigiao,ldnhapxuat,khonhapxuat,dd,theo,htnxhang,ldnhapxuatx"
                + ",thtro,tenbcsnt,tenbccnt,tenbpnt,tenbcsmg,tenbccmg,tenbpmg,chibosung)"
            + " values(@ntnx,@htnnhang,@nguoigiao,@ldnhapxuat,@khonhapxuat,@dd,@theo,@htnxhang,@ldnhapxuatx"
            + ",@thtro,@tenbcsnt,@tenbccnt,@tenbpnt,@tenbcsmg,@tenbccmg,@tenbpmg,@chibosung)";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@ntnx", OleDbType.Date).Value = Convert.ToDateTime(txtntnx.Text);
            cmd.Parameters.Add("@htnnhang", OleDbType.VarChar).Value = cbhtnnhang.Text;
            cmd.Parameters.Add("@nguoigiao", OleDbType.VarChar).Value = cbnguoigiao.Text;
            cmd.Parameters.Add("@ldnhapxuat", OleDbType.VarChar).Value = txtldnhapxuat.Text;
            cmd.Parameters.Add("@khonhapxuat", OleDbType.VarChar).Value = cbkhonhapxuat.Text;
            cmd.Parameters.Add("@dd", OleDbType.VarChar).Value = txtdd.Text;
            cmd.Parameters.Add("@theo", OleDbType.VarChar).Value = txttheo.Text;
            cmd.Parameters.Add("@htnxhang", OleDbType.VarChar).Value = cbhtnxhang.Text;
            cmd.Parameters.Add("@ldnhapxuatx", OleDbType.VarChar).Value = txtldnhapxuatx.Text;
            cmd.Parameters.Add("@thtro", OleDbType.Double).Value = classdc.dungchung.kieudouble(txtthtro.Text);
            cmd.Parameters.Add("@tenbcsnt", OleDbType.VarChar).Value = cbtenbcsnt.Text;
            cmd.Parameters.Add("@tenbccnt", OleDbType.VarChar).Value = cbtenbccnt.Text;
            cmd.Parameters.Add("@tenbpnt", OleDbType.VarChar).Value = cbtenbpnt.Text;
            cmd.Parameters.Add("@tenbcsmg", OleDbType.VarChar).Value = cbtenbcsmg.Text;
            cmd.Parameters.Add("@tenbccmg", OleDbType.VarChar).Value = cbtenbccmg.Text;
            cmd.Parameters.Add("@tenbpmg", OleDbType.VarChar).Value = cbtenbpmg.Text;
            cmd.Parameters.Add("@chibosung", OleDbType.Double).Value = classdc.dungchung.kieudouble(txtchibosung.Text);
            Connect.LuuDL(cmd);
        }
        private void updatenxct()
        {
            System.Globalization.CultureInfo cultuere = new System.Globalization.CultureInfo("vi-VN");
            cultuere.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";            
            string sql = "Update nxct set ntnx=@ntnx,htnnhang=@htnnhang,nguoigiao=@nguoigiao,ldnhapxuat=@ldnhapxuat,"
                + "khonhapxuat=@khonhapxuat,dd=@dd,theo=@theo,htnxhang=@htnxhang,ldnhapxuatx=@ldnhapxuatx"
                + ",thtro=@thtro,tenbcsnt=@tenbcsnt,tenbccnt=@tenbccnt,tenbpnt=@tenbpnt,tenbcsmg=@tenbcsmg,tenbccmg=@tenbccmg,tenbpmg=@tenbpmg,chibosung=@chibosung"
                + " where idnxct = " + Convert.ToInt64(txtidnxct.Text);
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@ntnx", OleDbType.Date).Value = Convert.ToDateTime(txtntnx.Text);
            cmd.Parameters.Add("@htnnhang", OleDbType.VarChar).Value = cbhtnnhang.Text;
            cmd.Parameters.Add("@nguoigiao", OleDbType.VarChar).Value = cbnguoigiao.Text;
            cmd.Parameters.Add("@ldnhapxuat", OleDbType.VarChar).Value = txtldnhapxuat.Text;
            cmd.Parameters.Add("@khonhapxuat", OleDbType.VarChar).Value = cbkhonhapxuat.Text;
            cmd.Parameters.Add("@dd", OleDbType.VarChar).Value = txtdd.Text;
            cmd.Parameters.Add("@theo", OleDbType.VarChar).Value = txttheo.Text;
            cmd.Parameters.Add("@htnxhang", OleDbType.VarChar).Value = cbhtnxhang.Text;
            cmd.Parameters.Add("@ldnhapxuatx", OleDbType.VarChar).Value = txtldnhapxuatx.Text;
            cmd.Parameters.Add("@thtro", OleDbType.Double).Value = classdc.dungchung.kieudouble(txtthtro.Text);
            cmd.Parameters.Add("@tenbcsnt", OleDbType.VarChar).Value = cbtenbcsnt.Text;
            cmd.Parameters.Add("@tenbccnt", OleDbType.VarChar).Value = cbtenbccnt.Text;
            cmd.Parameters.Add("@tenbpnt", OleDbType.VarChar).Value = cbtenbpnt.Text;
            cmd.Parameters.Add("@tenbcsmg", OleDbType.VarChar).Value = cbtenbcsmg.Text;
            cmd.Parameters.Add("@tenbccmg", OleDbType.VarChar).Value = cbtenbccmg.Text;
            cmd.Parameters.Add("@tenbpmg", OleDbType.VarChar).Value = cbtenbpmg.Text;
            cmd.Parameters.Add("@chibosung", OleDbType.Double).Value = classdc.dungchung.kieudouble(txtchibosung.Text);
            Connect.LuuDL(cmd);
        }
        private void capnhatct()
        {
            for (int i = 0; i < grvKQ.RowCount; i++)
            {
                if (Convert.ToInt64(grvKQ.GetRowCellValue(i, colidnhxu).ToString()) > 0)
                {
                    string sqlup = "Update nhxu set dongia=@dongia,slnh=@slnh,slxu=@slxu,slxuccnt=@slxuccnt,slxubpnt=@slxubpnt"
                        + ",slxumg=@slxumg,slxuccmg=@slxuccmg,slxubpmg=@slxubpmg,ttnh=@ttnh,ttxu=@ttxu,ttxumg=@ttxumg"
                        + " Where idnhxu = " + grvKQ.GetRowCellValue(i, colidnhxu);
                    OleDbCommand cmdup = new OleDbCommand();
                    cmdup.CommandText = sqlup;
                    cmdup.Parameters.Add("@dongia", OleDbType.Double).Value = Connect.GetDou(grvKQ.GetRowCellValue(i, coldongia));
                    cmdup.Parameters.Add("@slnh", OleDbType.Double).Value = Connect.GetDou(grvKQ.GetRowCellValue(i, colslnh));
                    cmdup.Parameters.Add("@slxu", OleDbType.Double).Value = Connect.GetDou(grvKQ.GetRowCellValue(i, colslxu));
                    cmdup.Parameters.Add("@slxuccnt", OleDbType.Double).Value = Connect.GetDou(grvKQ.GetRowCellValue(i, colslxuccnt));
                    cmdup.Parameters.Add("@slxubpnt", OleDbType.Double).Value = Connect.GetDou(grvKQ.GetRowCellValue(i, colslxubpnt));
                    cmdup.Parameters.Add("@slxumg", OleDbType.Double).Value = Connect.GetDou(grvKQ.GetRowCellValue(i, colslxumg));
                    cmdup.Parameters.Add("@slxuccmg", OleDbType.Double).Value = Connect.GetDou(grvKQ.GetRowCellValue(i, colslxuccmg));
                    cmdup.Parameters.Add("@slxubpmg", OleDbType.Double).Value = Connect.GetDou(grvKQ.GetRowCellValue(i, colslxubpmg));
                    cmdup.Parameters.Add("@ttnh", OleDbType.Double).Value = Connect.GetDou(grvKQ.GetRowCellValue(i, colttnh));
                    cmdup.Parameters.Add("@ttxu", OleDbType.Double).Value = Connect.GetDou(grvKQ.GetRowCellValue(i, colttxu));
                    cmdup.Parameters.Add("@ttxumg", OleDbType.Double).Value = Connect.GetDou(grvKQ.GetRowCellValue(i, colttxumg));                    
                    Connect.LuuDL(cmdup);
                }
                else
                {
                    string sqlin = "Insert into nhxu(idnxct,matp,tentp,donvitinh,dongia,chokho,slnh,slxu,slxuccnt,slxubpnt,slxumg"
                        + ",slxuccmg,slxubpmg,ttnh,ttxu,ttxumg)"
                        + " values(@idnxct,@matp,@tentp,@donvitinh,@dongia,@chokho,@slnh,@slxu,@slxuccnt,@slxubpnt,@slxumg"
                        + ",@slxuccmg,@slxubpmg,@ttnh,@ttxu,@ttxumg)";
                    OleDbCommand cmdin = new OleDbCommand();
                    cmdin.CommandText = sqlin;
                    cmdin.Parameters.Add("@idnxct", OleDbType.Double).Value = classdc.dungchung.kieudouble(txtidnxct.Text);
                    cmdin.Parameters.Add("@matp", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colmatp);
                    cmdin.Parameters.Add("@tentp", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, coltentp);
                    cmdin.Parameters.Add("@donvitinh", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, coldonvitinh);
                    cmdin.Parameters.Add("@dongia", OleDbType.Double).Value = Connect.GetDou(grvKQ.GetRowCellValue(i, coldongia));
                    cmdin.Parameters.Add("@chokho", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colchokho);
                    cmdin.Parameters.Add("@slnh", OleDbType.Double).Value = Connect.GetDou(grvKQ.GetRowCellValue(i, colslnh));
                    cmdin.Parameters.Add("@slxu", OleDbType.Double).Value = Connect.GetDou(grvKQ.GetRowCellValue(i, colslxu));                    
                    cmdin.Parameters.Add("@slxuccnt", OleDbType.Double).Value = Connect.GetDou(grvKQ.GetRowCellValue(i, colslxuccnt));
                    cmdin.Parameters.Add("@slxubpnt", OleDbType.Double).Value = Connect.GetDou(grvKQ.GetRowCellValue(i, colslxubpnt));
                    cmdin.Parameters.Add("@slxumg", OleDbType.Double).Value = Connect.GetDou(grvKQ.GetRowCellValue(i, colslxumg));
                    cmdin.Parameters.Add("@slxuccmg", OleDbType.Double).Value = Connect.GetDou(grvKQ.GetRowCellValue(i, colslxuccmg));
                    cmdin.Parameters.Add("@slxubpmg", OleDbType.Double).Value = Connect.GetDou(grvKQ.GetRowCellValue(i, colslxubpmg));
                    cmdin.Parameters.Add("@ttnh", OleDbType.Double).Value = Connect.GetDou(grvKQ.GetRowCellValue(i, colttnh));
                    cmdin.Parameters.Add("@ttxu", OleDbType.Double).Value = Connect.GetDou(grvKQ.GetRowCellValue(i, colttxu));
                    cmdin.Parameters.Add("@ttxumg", OleDbType.Double).Value = Connect.GetDou(grvKQ.GetRowCellValue(i, colttxumg));   
                    Connect.LuuDL(cmdin);
                }
            }
        }
        private double soluongton(string matp, string idct,double x1,double x2,double x3,double x4,double x5,double slnhap)
        {
            double sln = 0, slx = 0,kq=0;
            string sql = "Select * From nhxu Where matp = '" + matp + "'";
            OleDbDataReader dr = Connect.TruyVandr(sql);
            while (dr.Read())
            {
                sln = sln + classdc.dungchung.kieudouble(dr["slnh"].ToString());
                slx = slx + classdc.dungchung.kieudouble(dr["slxu"].ToString()) + classdc.dungchung.kieudouble(dr["slxuccnt"].ToString()) + classdc.dungchung.kieudouble(dr["slxubpnt"].ToString()) + classdc.dungchung.kieudouble(dr["slxumg"].ToString()) + classdc.dungchung.kieudouble(dr["slxuccmg"].ToString()) + classdc.dungchung.kieudouble(dr["slxubpmg"].ToString());
            }
            dr.Close();
            kq = slnhap + (sln - slx) - (x1 + x2 + x3 + x4 + x5);
            return kq;
        }
        private void grvKQ_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "dongia")
            {
                capnhatdg(classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(coldongia).ToString()));
                grvKQ.SetFocusedRowCellValue(colttnh, classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(coldongia).ToString()) * classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(colslnh).ToString()));
            }
            if (e.Column.FieldName == "slnh")
                grvKQ.SetFocusedRowCellValue(colttnh, classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(coldongia).ToString()) * classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(colslnh).ToString()));
            if (e.Column.FieldName == "slxu")
            {
                if (classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxu))) <= soluongton(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colmatp)), dcts.GetStr(grvKQ.GetFocusedRowCellValue(colidnhxu)), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxuccnt))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxubpnt))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxumg))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxuccmg))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxubpmg))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslnh)))))
                {
                    grvKQ.SetFocusedRowCellValue(colttxu, classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(coldongia).ToString()) * classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(colslxu).ToString()) + classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(coldongia).ToString()) * classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(colslxuccnt).ToString()) + classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(coldongia).ToString()) * classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(colslxubpnt).ToString()));
                }
                else
                {
                    MessageBox.Show("Số lượng còn là: " + soluongton(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colmatp)), dcts.GetStr(grvKQ.GetFocusedRowCellValue(colidnhxu)), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxuccnt))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxubpnt))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxumg))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxuccmg))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxubpmg))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslnh)))).ToString() + ", bạn đã xuất quá!","Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    grvKQ.SetFocusedRowCellValue(colslxu, 0);
                    SendKeys.Send("+{Tab}");
                }
            }
            if (e.Column.FieldName == "slxuccnt")
            {
                if (classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxuccnt))) <= soluongton(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colmatp)), dcts.GetStr(grvKQ.GetFocusedRowCellValue(colidnhxu)), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxu))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxubpnt))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxumg))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxuccmg))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxubpmg))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslnh)))))
                {
                    grvKQ.SetFocusedRowCellValue(colttxu, classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(coldongia).ToString()) * classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(colslxuccnt).ToString()) + classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(coldongia).ToString()) * classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(colslxu).ToString()) + classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(coldongia).ToString()) * classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(colslxubpnt).ToString()));
                }
                else
                {
                    MessageBox.Show("Số lượng còn là: " + soluongton(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colmatp)), dcts.GetStr(grvKQ.GetFocusedRowCellValue(colidnhxu)), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxu))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxubpnt))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxumg))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxuccmg))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxubpmg))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslnh)))).ToString() + ", bạn đã xuất quá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    grvKQ.SetFocusedRowCellValue(colslxuccnt, 0);
                    SendKeys.Send("+{Tab}");
                }
            }
            if (e.Column.FieldName == "slxubpnt")
            {
                if (classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxubpnt))) <= soluongton(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colmatp)), dcts.GetStr(grvKQ.GetFocusedRowCellValue(colidnhxu)), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxu))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxuccnt))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxumg))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxuccmg))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxubpmg))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslnh)))))
                {
                    grvKQ.SetFocusedRowCellValue(colttxu, classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(coldongia).ToString()) * classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(colslxubpnt).ToString()) + classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(coldongia).ToString()) * classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(colslxuccnt).ToString()) + classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(coldongia).ToString()) * classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(colslxu).ToString()));
                }
                else
                {
                    MessageBox.Show("Số lượng còn là: " + soluongton(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colmatp)), dcts.GetStr(grvKQ.GetFocusedRowCellValue(colidnhxu)), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxu))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxuccnt))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxumg))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxuccmg))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxubpmg))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslnh)))).ToString() + ", bạn đã xuất quá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    grvKQ.SetFocusedRowCellValue(colslxubpnt, 0);
                    SendKeys.Send("+{Tab}");
                }
            }
            if (e.Column.FieldName == "slxumg")
            {
                if (classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxumg))) <= soluongton(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colmatp)), dcts.GetStr(grvKQ.GetFocusedRowCellValue(colidnhxu)), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxu))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxuccnt))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxubpnt))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxuccmg))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxubpmg))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslnh)))))
                {
                    grvKQ.SetFocusedRowCellValue(colttxumg, classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(coldongia).ToString()) * classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(colslxumg).ToString()) + classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(coldongia).ToString()) * classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(colslxuccmg).ToString()) + classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(coldongia).ToString()) * classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(colslxubpmg).ToString()));
                }
                else
                {
                    MessageBox.Show("Số lượng còn là: " + soluongton(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colmatp)), dcts.GetStr(grvKQ.GetFocusedRowCellValue(colidnhxu)), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxu))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxuccnt))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxubpnt))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxuccmg))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxubpmg))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslnh)))).ToString() + ", bạn đã xuất quá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    grvKQ.SetFocusedRowCellValue(colslxumg, 0);
                    SendKeys.Send("+{Tab}");
                }
            }
            if (e.Column.FieldName == "slxuccmg")
            {
                if (classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxuccmg))) <= soluongton(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colmatp)), dcts.GetStr(grvKQ.GetFocusedRowCellValue(colidnhxu)), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxu))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxuccnt))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxubpnt))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxumg))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxubpmg))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslnh)))))
                {
                    grvKQ.SetFocusedRowCellValue(colttxumg, classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(coldongia).ToString()) * classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(colslxuccmg).ToString()) + classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(coldongia).ToString()) * classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(colslxumg).ToString()) + classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(coldongia).ToString()) * classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(colslxubpmg).ToString()));
                }
                else
                {
                    MessageBox.Show("Số lượng còn là: " + soluongton(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colmatp)), dcts.GetStr(grvKQ.GetFocusedRowCellValue(colidnhxu)), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxu))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxuccnt))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxubpnt))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxumg))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxubpmg))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslnh)))).ToString() + ", bạn đã xuất quá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    grvKQ.SetFocusedRowCellValue(colslxuccmg, 0);
                    SendKeys.Send("+{Tab}");
                }

            }
            if (e.Column.FieldName == "slxubpmg")
            {
                if (classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxubpmg))) <= soluongton(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colmatp)), dcts.GetStr(grvKQ.GetFocusedRowCellValue(colidnhxu)), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxu))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxuccnt))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxubpnt))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxumg))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxuccmg))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslnh)))))
                {
                    grvKQ.SetFocusedRowCellValue(colttxumg, classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(coldongia).ToString()) * classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(colslxubpmg).ToString()) + classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(coldongia).ToString()) * classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(colslxumg).ToString()) + classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(coldongia).ToString()) * classdc.dungchung.kieudouble(grvKQ.GetFocusedRowCellValue(colslxuccmg).ToString()));
                }
                else
                {
                    MessageBox.Show("Số lượng còn là: " + soluongton(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colmatp)), dcts.GetStr(grvKQ.GetFocusedRowCellValue(colidnhxu)), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxu))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxuccnt))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxubpnt))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxumg))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslxuccmg))), classdc.dungchung.kieudouble(dcts.GetStr(grvKQ.GetFocusedRowCellValue(colslnh)))).ToString() + ", bạn đã xuất quá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    grvKQ.SetFocusedRowCellValue(colslxubpmg, 0);
                    SendKeys.Send("+{Tab}");
                }
            }
        }
        private void capnhatdg(double dg)
        {
            string sql = "Update dmtp set dongia=@dongia Where matp = '" + grvKQ.GetFocusedRowCellValue(colmatp).ToString() + "'";
            OleDbCommand cmd = new OleDbCommand(sql);
            cmd.Parameters.Add("@dongia",OleDbType.Double).Value = dg;
            Connect.LuuDL(cmd);
        }
        private void txtthtro_TextChanged(object sender, EventArgs e)
        {
            txtthtro.Text = string.Format("{0:#" + decimalChar + "#}", classdc.dungchung.kieudouble(txtthtro.Text));
            SendKeys.Send("{End}");
        }
        private void frmnhapnxtpmn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }
        private void tbtXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Connect.ThaoTac("Delete * From nhxu Where idnxct = " + classdc.dungchung.kieudouble(txtidnxct.Text));                    
                    grcKQ.DataSource = null;
                    Connect.ThaoTac("Delete * From nxct Where idnxct = " + Convert.ToInt64(txtidnxct.Text));                    
                    txtntnx.Text = DateTime.Today.ToString();
                    txtidnxct.Text = "";
                    txtthtro.Text = "";
                    txtldnhapxuat.Text = "";
                    txtldnhapxuatx.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi khi xóa, hãy kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }       
        private void tbtLuu_Click(object sender, EventArgs e)
        {
            txtntnx.Text = DateTime.Today.ToString();
            txtidnxct.Text = "";
            cbhtnnhang.Text = "";
            cbnguoigiao.Text = "";
            txtldnhapxuat.Text = "";
            cbkhonhapxuat.Text = "";
            txtdd.Text = "";
            cbhtnxhang.Text = "";
            txtldnhapxuatx.Text = "";
            txtthtro.Text = "";
            cbtenbcsnt.Text = "";
            cbtenbccnt.Text = "";
            cbtenbpnt.Text = "";
            cbtenbcsmg.Text = "";
            cbtenbccmg.Text = "";
            cbtenbpmg.Text = "";
            grcKQ.DataSource = null;
        }
        private double ton()
        {
            double sodc = 0, tienht = 0, tongchi = 0;
            string sql = "Select BS,MASANG From baoan where ntan < #" + classdc.dungchung.thaydoi(txtntnx.Text) + "#";
            OleDbDataReader dr = Connect.TruyVandr(sql);
            while (dr.Read())
            {               
                sodc = sodc + classdc.dungchung.kieudouble(dr["MASANG"].ToString())*classdc.dungchung.kieudouble(dr["BS"].ToString());
            }
            dr.Close();
            OleDbDataReader drht = Connect.TruyVandr("Select thtro,ttnh From  nhxu inner join nxct on nhxu.idnxct = nxct.idnxct where nxct.ntnx < #" + classdc.dungchung.thaydoi(txtntnx.Text) + "#");
            while (drht.Read())
            {
                tienht = classdc.dungchung.kieudouble(drht["thtro"].ToString());
                tongchi = tongchi + classdc.dungchung.kieudouble(drht["ttnh"].ToString());
            }
            drht.Close();
            return sodc + tienht - tongchi;
        }
        private void sổChợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string[] st = txtntnx.Text.Split('/');
                Connect.ThaoTac("Delete * From TblDC");
                clsocho.appdc(txtntnx.Text);
                clsocho.updc(txtntnx.Text);
                DataSet dts = new DataSet();
                Connect.Loadds(dts, "Select * From TblDC order by TEN1", "TblDC");
                Forms.frmHienThi frm = new Forms.frmHienThi();
                Reports.SoCHOmn rpt = new KPBT.Reports.SoCHOmn();
                rpt.NTN.Value = "Ngày " + st[0] + " tháng " + st[1] + " năm " + st[2];
                rpt.TenDV.Value = thongtinketxuat.Default.tendv.ToString();
                rpt.HTNN.Value = cbhtnnhang.Text;
                rpt.HTNG.Value = cbnguoigiao.Text;
                double soxa = 0, mucan = 0, tienht = 0, tongchi = 0;
                string sql = "Select BS,MASANG From baoan where ntan = #" + classdc.dungchung.thaydoi(txtntnx.Text) + "#";
                OleDbDataReader dr = Connect.TruyVandr(sql);
                while (dr.Read())
                {
                    soxa = soxa + classdc.dungchung.kieudouble(dr["BS"].ToString());
                    mucan = classdc.dungchung.kieudouble(dr["MASANG"].ToString());
                }
                dr.Close();
                OleDbDataReader drht = Connect.TruyVandr("Select thtro,ttnh From  nhxu inner join nxct on nhxu.idnxct = nxct.idnxct where nxct.ntnx = #" + classdc.dungchung.thaydoi(txtntnx.Text) + "#");
                while (drht.Read())
                {
                    tienht = classdc.dungchung.kieudouble(drht["thtro"].ToString());
                    tongchi = tongchi + classdc.dungchung.kieudouble(drht["ttnh"].ToString());
                }
                drht.Close();
                rpt.soxa.Value = string.Format("{0:#" + decimalChar + "#}", soxa);
                rpt.mucan.Value = string.Format("{0:#" + decimalChar + "#}", mucan);
                rpt.sotienht.Value = string.Format("{0:#" + decimalChar + "#}", tienht);
                rpt.sotiendc.Value = string.Format("{0:#" + decimalChar + "#}", tienht + soxa * mucan);
                rpt.sochi.Value = string.Format("{0:#" + decimalChar + "#}", tongchi);
                rpt.tonht.Value = string.Format("{0:#" + decimalChar + "#}", ton());
                if (tienht + soxa * mucan + ton() - tongchi >= 0)
                {
                    rpt.sotienthua.Value = string.Format("{0:#" + decimalChar + "#}", tienht + soxa * mucan + ton() - tongchi);
                    rpt.sotienthieu.Value = "0";
                }
                else
                {
                    rpt.sotienthua.Value = "0";
                    rpt.sotienthieu.Value = string.Format("{0:#" + decimalChar + "#}", tienht + soxa * mucan + ton() - tongchi);
                }
                rpt.DataSource = dts;
                frm.printControl1.PrintingSystem = rpt.PrintingSystem;
                rpt.CreateDocument();
                frm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình tạo sổ. Bạn hãy kiểm tra lại", "Thông báo");
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
            rpt.nguoigiao.Value = cbnguoigiao.Text;

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
        private void phiếuXuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtidnxct.Text != "")
            {
                OleDbDataReader dr = Connect.TruyVandr("Select * From nhxu where idnxct = " + classdc.dungchung.kieudouble(txtidnxct.Text));
                Dataset.dsctnhapxuat dts = new Dataset.dsctnhapxuat();
                while (dr.Read())
                {
                    DataRow nrow = dts.nhxu.NewRow();
                    nrow["tentp"] = dr["tentp"].ToString();
                    nrow["matp"] = dr["matp"].ToString();
                    nrow["donvitinh"] = dr["donvitinh"].ToString();
                    nrow["slxu"] = classdc.dungchung.kieudouble(dr["slxu"].ToString()) + classdc.dungchung.kieudouble(dr["slxuccnt"].ToString()) + classdc.dungchung.kieudouble(dr["slxubpnt"].ToString()) + classdc.dungchung.kieudouble(dr["slxumg"].ToString()) + classdc.dungchung.kieudouble(dr["slxuccmg"].ToString()) + classdc.dungchung.kieudouble(dr["slxubpmg"].ToString());
                    nrow["dongia"] = classdc.dungchung.kieudouble(dr["dongia"].ToString());
                    nrow["ttxu"] = classdc.dungchung.kieudouble(dr["ttxu"].ToString()) + classdc.dungchung.kieudouble(dr["ttxumg"].ToString());
                    dts.nhxu.Rows.Add(nrow);
                }
                dr.Close();
                string[] str = txtntnx.Text.Split('/');                
                //Connect.Loadds(dts, "Select * From nhxu where idnxct = " + classdc.dungchung.kieudouble(txtidnxct.Text), "nhxu");
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
                rpt.daichi.Value = "";
                rpt.ldxk.Value = txtldnhapxuatx.Text;
                rpt.taikho.Value = cbkhonhapxuat.Text;
                rpt.dd.Value = txtdd.Text;
                rpt.TongTBC.Value = "Tổng số tiền (viết bằng chữ): " + classdc.dungchung.So_chu(classdc.dungchung.kieudouble(colttxu.SummaryItem.SummaryValue.ToString()) + classdc.dungchung.kieudouble(colttxumg.SummaryItem.SummaryValue.ToString()));
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
        private void txtchibosung_TextChanged(object sender, EventArgs e)
        {
            txtchibosung.Text = string.Format("{0:#" + decimalChar + "#}", classdc.dungchung.kieudouble(txtchibosung.Text));
            SendKeys.Send("{End}");
        }
        private void txtthtro_Leave(object sender, EventArgs e)
        {
            txtchibosung.Text = txtthtro.Text;
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
        private void btnXoa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Connect.ThaoTac("Delete * From nhxu Where idnhxu = " + Convert.ToInt64(Connect.GetStr(grvKQ.GetFocusedRowCellValue(colidnhxu))));                    
                    uncheck(grvKQ.GetFocusedRowCellValue(colmatp));
                    grvKQ.DeleteSelectedRows();
                    for (int i = 0; i < grvKQ.RowCount; i++)
                    {
                        grvKQ.SetRowCellValue(i, colSTT, i+1);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi khi xóa, hãy kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private double slxuat(string matp)
        {
            double kq = 0;
            DataTable dt = Connect.TruyVandt("Select sogam From dmtp where matp = '" + matp + "' and sogam > 0");
            kq = (classdc.dungchung.kieudouble((dt.Rows.Count > 0 ? dt.Rows[0]["sogam"].ToString() : "0")) * classdc.dungchung.kieudouble(l1.Text)) / 1000;
            return kq;
        }
        private void btnChuyen_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grvTPCT.RowCount; i++)
            {
                if (Connect.GetStr(grvTPCT.GetRowCellValue(i, colChon)) == "True" && kttp(Connect.GetStr(grvTPCT.GetRowCellValue(i, colmatp1))) == "K")
                {
                    nrow = dtlv.NewRow();
                    nrow["idnhxu"] = 0;
                    nrow["idnxct"] = 0;
                    nrow["matp"] = grvTPCT.GetRowCellValue(i, colmatp1);
                    nrow["tentp"] = grvTPCT.GetRowCellValue(i, coltentp1);
                    nrow["donvitinh"] = grvTPCT.GetRowCellValue(i, coldonvitinh1);
                    nrow["dongia"] = Connect.GetDou(grvTPCT.GetRowCellValue(i, coldongia1));
                    nrow["chokho"] = grvTPCT.GetRowCellValue(i, colchokho1);
                    nrow["slnh"] = 0;
                    nrow["slxu"] = slxuat(Connect.GetStr(grvTPCT.GetRowCellValue(i, colmatp1)));
                    nrow["ttnh"] = 0;
                    nrow["ttxu"] = slxuat(Connect.GetStr(grvTPCT.GetRowCellValue(i, colmatp1))) * Connect.GetDou(grvTPCT.GetRowCellValue(i, coldongia1));
                    nrow["chatluong"] = "";
                    nrow["STT"] = dtlv.Rows.Count + 1;
                    dtlv.Rows.Add(nrow);
                }
            }
            grcKQ.DataSource = dtlv;
        }

        string layngt(string sql, string col)
        {
            string kq = "";
            OleDbDataReader dr = Connect.TruyVandr(sql);
            while (dr.Read())
            {
                if (kq == "")
                    kq += dr[col].ToString();
                else
                    kq += ", " + dr[col].ToString();
            }   
            dr.Close();
            return kq;
        }
        private string tenba(string tenba, string nhomtuoi)
        {
            string kq = "";
            kq = layngt("Select Tenbua from tblkehoach where Ngaythang = #" + classdc.dungchung.thaydoi(txtntnx.Text) + "# and TenBA = '" + tenba + "' and MaNT = '" + nhomtuoi + "'", "Tenbua");
            return kq;           
        }

        private void dsmonan()
        {
            dtlv.Clear();
            DataTable dttt = new DataTable();
            string sql = "Select * from qrmonanTD where Ngaythang = #" + classdc.dungchung.thaydoi(txtntnx.Text) + "#";
            dttt = Connect.TruyVandt("Select * from qrmonanTD where Ngaythang = #" + classdc.dungchung.thaydoi(txtntnx.Text) + "#");
            foreach (DataRow item in Connect.TruyVandt("Select * from qrmonanTD where Ngaythang = #" + classdc.dungchung.thaydoi(txtntnx.Text) + "#").Rows)
            {
                DataRow row = dtlv.NewRow();
                row["idnhxu"] = 0;
                row["idnxct"] = 0;
                row["matp"] = item["matp"].ToString();
                row["tentp"] = item["tentp"].ToString();
                row["donvitinh"] = item["donvitinh"].ToString();
                row["dongia"] = item["dongia"].ToString();
                row["chokho"] = item["chokho"].ToString();
                row["STT"] = dtlv.Rows.Count + 1;
                dtlv.Rows.Add(row);
            }
        }

        private void txtntnx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "Select * From nxct Where idnxct <> 0 and ntnx = #" + classdc.dungchung.thaydoi(txtntnx.Text) + "#";
                DataTable dt = Connect.TruyVandt(sql);
                //txtntnx.Text = DateTime.Today.ToString();
                cbhtnnhang.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["htnnhang"].ToString() : "");
                cbnguoigiao.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["nguoigiao"].ToString() : "");
                txtldnhapxuat.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["ldnhapxuat"].ToString() : "");
                cbkhonhapxuat.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["khonhapxuat"].ToString() : "");
                txtdd.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["dd"].ToString() : "");
                txttheo.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["theo"].ToString() : "");
                cbhtnxhang.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["htnxhang"].ToString() : "");
                txtldnhapxuatx.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["ldnhapxuatx"].ToString() : "");
                txtthtro.Text = string.Format("{0:#" + decimalChar + "#}", classdc.dungchung.kieudouble((dt.Rows.Count > 0 ? dt.Rows[0]["thtro"].ToString() : "")));
                txtidnxct.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["idnxct"].ToString() : "");
                txtchibosung.Text = string.Format("{0:#" + decimalChar + "#}", classdc.dungchung.kieudouble((dt.Rows.Count > 0 ? dt.Rows[0]["chibosung"].ToString() : "")));
                // Bữa ăn
                cbtenbcsnt.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["tenbcsnt"].ToString() : "");
                cbtenbccnt.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["tenbccnt"].ToString() : "");
                cbtenbpnt.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["tenbpnt"].ToString() : "");
                cbtenbcsmg.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["tenbcsmg"].ToString() : "");
                cbtenbccmg.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["tenbccmg"].ToString() : "");
                cbtenbpmg.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["tenbpmg"].ToString() : "");

                DataTable dtxu = Connect.TruyVandt("Select BS,nhatre,MASANG From baoanhangngay Where ntan = #" + classdc.dungchung.thaydoi(txtntnx.Text) + "#");
                double tongxa = 0, nt = 0, mg = 0, mucan = 0;
                if (dtxu.Rows.Count > 0)
                {
                    for (int i = 0; i < dtxu.Rows.Count; i++)
                    {
                        mucan = classdc.dungchung.kieudouble(dtxu.Rows[0]["MASANG"].ToString());
                        tongxa = tongxa + classdc.dungchung.kieudouble(dtxu.Rows[i]["BS"].ToString());
                        if (dtxu.Rows[i]["nhatre"].ToString() == "Nhà trẻ")
                            nt = nt + classdc.dungchung.kieudouble(dtxu.Rows[i]["BS"].ToString());
                        if (dtxu.Rows[i]["nhatre"].ToString() == "Mẫu giáo")
                            mg = mg + classdc.dungchung.kieudouble(dtxu.Rows[i]["BS"].ToString());
                    }
                }
                dtlv = Connect.Loadgrc("Select * From nhxu where idnxct <> 0 and idnxct = " + classdc.dungchung.kieudouble(txtidnxct.Text));                
                lbsoxuat.Text = "Tổng số xuất ăn: " + tongxa.ToString() + " (NT: " + nt.ToString() + ", MG: " + mg.ToString() + ")";
                if (txtidnxct.Text == "")
                {
                    dsmonan();
                    // Bữa ăn
                    cbtenbcsnt.Text = tenba("Chính sáng", "Nhà trẻ");
                    cbtenbccnt.Text = tenba("Chính chiều", "Nhà trẻ");
                    cbtenbpnt.Text = tenba("Phụ", "Nhà trẻ");
                    cbtenbcsmg.Text = tenba("Chính sáng", "Mẫu giáo");
                    cbtenbccmg.Text = tenba("Chính chiều", "Mẫu giáo");
                    cbtenbpmg.Text = tenba("Phụ", "Mẫu giáo");

                }
                grcKQ.DataSource = dtlv;
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
                //lbsodc.Text = "Số được chi: " + string.Format("{0:#" + decimalChar + "#}", tongxa * mucan);
                //dtlv = Connect.Loadgrc("Select * From nhxu where idnxct = " + classdc.dungchung.kieudouble(txtidnxct.Text));
                //grcKQ.DataSource = Connect.Loadgrc("Select * From nhxu where idnxct = " + classdc.dungchung.kieudouble(txtidnxct.Text));
            }
            catch
            {
            }
        }

        private void phiếuĐiChợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string[] st = txtntnx.Text.Split('/');
                Connect.ThaoTac("Delete * From TblDC");
                clsocho.appdcphieu(txtntnx.Text);
                clsocho.updc(txtntnx.Text);
                DataSet dts = new DataSet();
                Connect.Loadds(dts, "Select * From TblDC order by TEN1", "TblDC");
                Forms.frmHienThi frm = new Forms.frmHienThi();
                Reports.PhieuCHOmn rpt = new KPBT.Reports.PhieuCHOmn();
                rpt.NTN.Value = "Ngày " + st[0] + " tháng " + st[1] + " năm " + st[2];
                rpt.TenDV.Value = thongtinketxuat.Default.tendv.ToString();
                rpt.HTNN.Value = cbhtnnhang.Text;
                rpt.HTNG.Value = cbnguoigiao.Text;
                double soxa = 0, mucan = 0, tienht = 0, tongchi = 0;
                string sql = "Select BS,MASANG From baoan where ntan = #" + classdc.dungchung.thaydoi(txtntnx.Text) + "#";
                OleDbDataReader dr = Connect.TruyVandr(sql);
                while (dr.Read())
                {
                    soxa = soxa + classdc.dungchung.kieudouble(dr["BS"].ToString());
                    mucan = classdc.dungchung.kieudouble(dr["MASANG"].ToString());
                }
                dr.Close();
                OleDbDataReader drht = Connect.TruyVandr("Select thtro,ttnh From  nhxu inner join nxct on nhxu.idnxct = nxct.idnxct where nxct.ntnx = #" + classdc.dungchung.thaydoi(txtntnx.Text) + "#");
                while (drht.Read())
                {
                    tienht = classdc.dungchung.kieudouble(drht["thtro"].ToString());
                    tongchi = tongchi + classdc.dungchung.kieudouble(drht["ttnh"].ToString());
                }
                drht.Close();
                rpt.soxa.Value = string.Format("{0:#" + decimalChar + "#}", soxa);
                rpt.mucan.Value = string.Format("{0:#" + decimalChar + "#}", mucan);
                rpt.sotienht.Value = string.Format("{0:#" + decimalChar + "#}", tienht);
                rpt.sotiendc.Value = string.Format("{0:#" + decimalChar + "#}", tienht + soxa * mucan);
                rpt.sochi.Value = string.Format("{0:#" + decimalChar + "#}", tongchi);
                rpt.tonht.Value = string.Format("{0:#" + decimalChar + "#}", ton());
                if (tienht + soxa * mucan + ton() - tongchi >= 0)
                {
                    rpt.sotienthua.Value = string.Format("{0:#" + decimalChar + "#}", tienht + soxa * mucan + ton() - tongchi);
                    rpt.sotienthieu.Value = "0";
                }
                else
                {
                    rpt.sotienthua.Value = "0";
                    rpt.sotienthieu.Value = string.Format("{0:#" + decimalChar + "#}", tienht + soxa * mucan + ton() - tongchi);
                }
                rpt.DST.Value = classdc.dungchung.So_chu(classdc.dungchung.kieudouble(colttnh.SummaryItem.SummaryValue.ToString()));
                rpt.DataSource = dts;
                frm.printControl1.PrintingSystem = rpt.PrintingSystem;
                rpt.CreateDocument();
                frm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình tạo sổ. Bạn hãy kiểm tra lại", "Thông báo");
            }
        }
    }
}
