using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.IO;
using System.Data.OleDb;
using KPBT.Modules;

namespace KPBT.Forms.DanhMuc
{
    public partial class frmTaoNamMoicd : Office2007Form
    {
        public OleDbConnection cn1;
        public OleDbConnection cn2;        
        string dlmau = "";
        string fd = "";
        public frmTaoNamMoicd()
        {
            InitializeComponent();
            //cn1 = DC1.Ketnoi_Database(DC1.namdllv);
        }

        private void Thoaitaocsdl_Load(object sender, EventArgs e)
        {
            dlmau = Settings1.Default.nammau.ToString();
        }

        private void labelX4_Click(object sender, EventArgs e)
        {            
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                dlmau = fd.FileName.ToString();
                if (dlmau.IndexOf("QLDD.mdb") == -1)
                {
                    MessageBox.Show("Đây không phải năm dữ liệu mẫu!", "Thông báo");
                    dlmau = "";
                    lbfilemau.Text = "Đường dẫn file:";
                }
                else
                {
                    //lbfilemau.Text = "Đường dẫn file: " + dlmau;                    
                }
            }
        }

        private void labelX2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog tm = new FolderBrowserDialog();
            if (tm.ShowDialog() == DialogResult.OK)
            {
                lbtm.Text = "Đường dẫn thư mục: " + tm.SelectedPath;
                fd = tm.SelectedPath;
            }
        }

        private void labelX5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelX21_Click(object sender, EventArgs e)
        {
            try
            {
                if (ckbNamLV.Checked == true)
                {
                    Program.openfrm = "Cài đặt";
                    this.Visible = false;
                    Form frm = new KPBT.Forms.frmThoai_DOINAM();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    System.Globalization.CultureInfo cultuere = new System.Globalization.CultureInfo("vi-VN");
                    cultuere.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
                    string pathlv = "";
                    pathlv = fd + @"\QLDD" + cbnam.Text + ".mdb";
                    if (File.Exists(pathlv) == true)
                    {
                        MessageBox.Show("Năm dữ liệu này đã tồn tại, bạn tạo năm khác!", "Thông báo");
                    }
                    else
                    {

                        if (MessageBox.Show("Bạn có muốn tạo năm làm việc tại đường dẫn " + pathlv + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            File.Copy(dlmau, pathlv, true);
                            cn2 = DC1.Ketnoi_Database(pathlv);
                            if (ckbDM.Checked == true)
                            {
                                #region Danh mục lớp
                                string sqldelctmt = "Delete * From phong";
                                OleDbCommand cmddelctmt = new OleDbCommand(sqldelctmt, cn2);
                                cmddelctmt.ExecuteNonQuery();
                                string sql1 = " Select * From phong";
                                OleDbCommand cmd1 = new OleDbCommand(sql1, cn1);
                                OleDbDataReader dr1 = cmd1.ExecuteReader();
                                while (dr1.Read())
                                {
                                    string sqlinctmt = "Insert into phong (tenphong,nhatre,ttkhac,loptren)" +
                                        " Values (@tenphong,@nhatre,@ttkhac,@loptren)";
                                    OleDbCommand cmdinctmt = new OleDbCommand(sqlinctmt, cn2);
                                    cmdinctmt.Parameters.Add("@tenphong", OleDbType.VarChar).Value = dr1["tenphong"].ToString();
                                    cmdinctmt.Parameters.Add("@nhatre", OleDbType.VarChar).Value = dr1["nhatre"].ToString();
                                    cmdinctmt.Parameters.Add("@ttkhac", OleDbType.VarChar).Value = dr1["ttkhac"].ToString();
                                    cmdinctmt.Parameters.Add("@loptren", OleDbType.VarChar).Value = dr1["loptren"].ToString();
                                    cmdinctmt.ExecuteNonQuery();
                                }
                                dr1.Close();
                                #endregion

                                #region Danh mục Cán bộ quản lý lớp
                                string sqldelch = "Delete * From canbo";
                                OleDbCommand cmddelch = new OleDbCommand(sqldelch, cn2);
                                cmddelch.ExecuteNonQuery();
                                string sql2 = " Select * From canbo";
                                OleDbCommand cmd2 = new OleDbCommand(sql2, cn1);
                                OleDbDataReader dr2 = cmd2.ExecuteReader();
                                while (dr2.Read())
                                {
                                    string sqlinch = "Insert into canbo (macb,tencb,dccb,phongban)" +
                                        " Values (@macb,@tencb,@dccb,@phongban)";
                                    OleDbCommand cmdinch = new OleDbCommand(sqlinch, cn2);
                                    cmdinch.Parameters.Add("@macb", OleDbType.VarChar).Value = dr2["macb"].ToString();
                                    cmdinch.Parameters.Add("@tencb", OleDbType.VarChar).Value = dr2["tencb"].ToString();
                                    cmdinch.Parameters.Add("@dccb", OleDbType.VarChar).Value = dr2["dccb"].ToString();
                                    cmdinch.Parameters.Add("@phongban", OleDbType.VarChar).Value = dr2["phongban"].ToString();
                                    cmdinch.ExecuteNonQuery();
                                }
                                dr2.Close();
                                #endregion

                                #region Danh mục Kho
                                string sqldelkh = "Delete * From kho";
                                OleDbCommand cmddelkh = new OleDbCommand(sqldelkh, cn2);
                                cmddelkh.ExecuteNonQuery();
                                string sql4 = " Select * From kho";
                                OleDbCommand cmd4 = new OleDbCommand(sql4, cn1);
                                OleDbDataReader dr4 = cmd4.ExecuteReader();
                                while (dr4.Read())
                                {
                                    string sqlinkh = "Insert into kho (tenkho,dd)" +
                                        " Values (@tenkho,@dd)";
                                    OleDbCommand cmdinkh = new OleDbCommand(sqlinkh, cn2);
                                    cmdinkh.Parameters.Add("@tenkho ", OleDbType.VarChar).Value = dr4["tenkho"].ToString();
                                    cmdinkh.Parameters.Add("@dd", OleDbType.VarChar).Value = dr4["dd"].ToString();
                                    cmdinkh.ExecuteNonQuery();
                                }
                                dr4.Close();
                                #endregion

                                #region Danh mục thực phẩm
                                string sqldellk = "Delete * From dmtp";
                                OleDbCommand cmddellk = new OleDbCommand(sqldellk, cn2);
                                cmddellk.ExecuteNonQuery();
                                string sql5 = " Select * From dmtp";
                                OleDbCommand cmd5 = new OleDbCommand(sql5, cn1);
                                OleDbDataReader dr5 = cmd5.ExecuteReader();
                                while (dr5.Read())
                                {
                                    string sqlinlk = "Insert into dmtp (matp,tentp,donvitinh,dongia,sogam,chokho,tilethai,nangluong,protein,chatbeo,carbohydrat,chatxo,choleterol,canxi,phospho,sat,natri,kali,betacaroten,vitamina,vitaminb,vitaminc)" +
                                        " Values (@matp,@tentp,@donvitinh,@dongia,@sogam,@chokho,@tilethai,@nangluong,@protein,@chatbeo,@carbohydrat,@chatxo,@choleterol,@canxi,@phospho,@sat,@natri,@kali,@betacaroten,@vitamina,@vitaminb,@vitaminc)";
                                    OleDbCommand cmdinlk = new OleDbCommand(sqlinlk, cn2);
                                    cmdinlk.Parameters.Add("@matp", OleDbType.VarChar).Value = dr5["matp"].ToString();
                                    cmdinlk.Parameters.Add("@tentp", OleDbType.VarChar).Value = dr5["tentp"].ToString();
                                    cmdinlk.Parameters.Add("@donvitinh", OleDbType.VarChar).Value = dr5["donvitinh"].ToString();
                                    cmdinlk.Parameters.Add("@dongia", OleDbType.Double).Value = classdc.dungchung.kieudouble(dr5["dongia"].ToString());
                                    cmdinlk.Parameters.Add("@sogam", OleDbType.Double).Value = classdc.dungchung.kieudouble(dr5["sogam"].ToString());
                                    cmdinlk.Parameters.Add("@chokho", OleDbType.VarChar).Value = dr5["chokho"].ToString();
                                    cmdinlk.Parameters.Add("@tilethai", OleDbType.Double).Value = classdc.dungchung.kieudouble(dr5["tilethai"].ToString());
                                    cmdinlk.Parameters.Add("@nangluong", OleDbType.Double).Value = classdc.dungchung.kieudouble(dr5["nangluong"].ToString());
                                    cmdinlk.Parameters.Add("@protein", OleDbType.Double).Value = classdc.dungchung.kieudouble(dr5["protein"].ToString());
                                    cmdinlk.Parameters.Add("@chatbeo", OleDbType.Double).Value = classdc.dungchung.kieudouble(dr5["chatbeo"].ToString());
                                    cmdinlk.Parameters.Add("@carbohydrat", OleDbType.Double).Value = classdc.dungchung.kieudouble(dr5["carbohydrat"].ToString());
                                    cmdinlk.Parameters.Add("@chatxo", OleDbType.Double).Value = classdc.dungchung.kieudouble(dr5["chatxo"].ToString());
                                    cmdinlk.Parameters.Add("@choleterol", OleDbType.Double).Value = classdc.dungchung.kieudouble(dr5["choleterol"].ToString());
                                    cmdinlk.Parameters.Add("@canxi", OleDbType.Double).Value = classdc.dungchung.kieudouble(dr5["canxi"].ToString());
                                    cmdinlk.Parameters.Add("@phospho", OleDbType.Double).Value = classdc.dungchung.kieudouble(dr5["phospho"].ToString());
                                    cmdinlk.Parameters.Add("@sat", OleDbType.Double).Value = classdc.dungchung.kieudouble(dr5["sat"].ToString());
                                    cmdinlk.Parameters.Add("@natri", OleDbType.Double).Value = classdc.dungchung.kieudouble(dr5["natri"].ToString());
                                    cmdinlk.Parameters.Add("@kali", OleDbType.Double).Value = classdc.dungchung.kieudouble(dr5["kali"].ToString());
                                    cmdinlk.Parameters.Add("@betacaroten", OleDbType.Double).Value = classdc.dungchung.kieudouble(dr5["betacaroten"].ToString());
                                    cmdinlk.Parameters.Add("@vitamina", OleDbType.Double).Value = classdc.dungchung.kieudouble(dr5["vitamina"].ToString());
                                    cmdinlk.Parameters.Add("@vitaminb", OleDbType.Double).Value = classdc.dungchung.kieudouble(dr5["vitaminb"].ToString());
                                    cmdinlk.Parameters.Add("@vitaminc", OleDbType.Double).Value = classdc.dungchung.kieudouble(dr5["vitaminc"].ToString());
                                    cmdinlk.ExecuteNonQuery();
                                }
                                dr5.Close();
                                #endregion

                                #region Danh mục khoản thu
                                string sqldelng = "Delete * From dmthu";
                                OleDbCommand cmddelng = new OleDbCommand(sqldelng, cn2);
                                cmddelng.ExecuteNonQuery();
                                string sql6 = " Select * From dmthu";
                                OleDbCommand cmd6 = new OleDbCommand(sql6, cn1);
                                OleDbDataReader dr6 = cmd6.ExecuteReader();
                                while (dr6.Read())
                                {
                                    string sqlinng = "Insert into dmthu (makhthu,tenkhoanthu,soluong,sotien)" +
                                        " Values (@makhthu,@tenkhoanthu,@soluong,@sotien)";
                                    OleDbCommand cmdinng = new OleDbCommand(sqlinng, cn2);
                                    cmdinng.Parameters.Add("@makhthu", OleDbType.VarChar).Value = dr6["makhthu"].ToString();
                                    cmdinng.Parameters.Add("@tenkhoanthu", OleDbType.VarChar).Value = dr6["tenkhoanthu"].ToString();
                                    cmdinng.Parameters.Add("@soluong", OleDbType.Double).Value = classdc.dungchung.kieudouble(dr6["soluong"].ToString());
                                    cmdinng.Parameters.Add("@sotien", OleDbType.Double).Value = classdc.dungchung.kieudouble(dr6["sotien"].ToString());
                                    cmdinng.ExecuteNonQuery();
                                }
                                dr6.Close();
                                #endregion

                                #region Hệ thống
                                string sqldelht = "Delete * From ttdv";
                                OleDbCommand cmddelht = new OleDbCommand(sqldelht, cn2);
                                cmddelht.ExecuteNonQuery();
                                string sql15 = " Select * From ttdv";
                                OleDbCommand cmd15 = new OleDbCommand(sql15, cn1);
                                OleDbDataReader dr15 = cmd15.ExecuteReader();
                                while (dr15.Read())
                                {
                                    string sqlinda = "Insert into ttdv (tendv,tenct,dcdv,nlb,nnhanhang,thukho,ketoan," +
                                        " kttruong,ttdv,MHTT,MA,mqhns,bophan,diadanh,thuquy,MASANG,MATOI,MUCHT,Namhoc";
                                    if (dr15["nkxtu"].ToString() != "")
                                    {
                                        sqlinda = sqlinda + ",nkxtu";
                                    }
                                    if (dr15["nkxden"].ToString() != "")
                                    {
                                        sqlinda = sqlinda + ",nkxden";
                                    }
                                    sqlinda = sqlinda + ")" +
                                    " Values (@tendv,@tenct,@dcdv,@nlb,@nnhanhang,@thukho,@ketoan," +
                                    " @kttruong,@ttdv,@MHTT,@MA,@mqhns,@bophan,@diadanh,@thuquy,@MASANG,@MATOI,@MUCHT,@Namhoc";
                                    if (dr15["nkxtu"].ToString() != "")
                                    {
                                        sqlinda = sqlinda + ",@nkxtu";
                                    }
                                    if (dr15["nkxden"].ToString() != "")
                                    {
                                        sqlinda = sqlinda + ",@nkxden";
                                    }
                                    sqlinda = sqlinda + ")";
                                    OleDbCommand cmdinda = new OleDbCommand(sqlinda, cn2);
                                    cmdinda.Parameters.Add("@tendv", OleDbType.VarChar).Value = dr15["tendv"].ToString();
                                    cmdinda.Parameters.Add("@tenct", OleDbType.VarChar).Value = dr15["tenct"].ToString();
                                    cmdinda.Parameters.Add("@dcdv", OleDbType.VarChar).Value = dr15["dcdv"].ToString();
                                    cmdinda.Parameters.Add("@nlb", OleDbType.VarChar).Value = dr15["nlb"].ToString();
                                    cmdinda.Parameters.Add("@nnhanhang", OleDbType.VarChar).Value = dr15["nnhanhang"].ToString();
                                    cmdinda.Parameters.Add("@thukho", OleDbType.VarChar).Value = dr15["thukho"].ToString();
                                    cmdinda.Parameters.Add("@ketoan", OleDbType.VarChar).Value = dr15["ketoan"].ToString();
                                    cmdinda.Parameters.Add("@kttruong", OleDbType.VarChar).Value = dr15["kttruong"].ToString();
                                    cmdinda.Parameters.Add("@ttdv", OleDbType.VarChar).Value = dr15["ttdv"].ToString();
                                    cmdinda.Parameters.Add("@MHTT", OleDbType.Double).Value = classdc.dungchung.kieudouble(dr15["MHTT"].ToString());
                                    cmdinda.Parameters.Add("@MA", OleDbType.Double).Value = classdc.dungchung.kieudouble(dr15["MA"].ToString());
                                    cmdinda.Parameters.Add("@mqhns", OleDbType.VarChar).Value = dr15["mqhns"].ToString();
                                    cmdinda.Parameters.Add("@bophan", OleDbType.VarChar).Value = dr15["bophan"].ToString();
                                    cmdinda.Parameters.Add("@diadanh", OleDbType.VarChar).Value = dr15["diadanh"].ToString();
                                    cmdinda.Parameters.Add("@thuquy", OleDbType.VarChar).Value = dr15["thuquy"].ToString();
                                    cmdinda.Parameters.Add("@MASANG", OleDbType.Double).Value = classdc.dungchung.kieudouble(dr15["MASANG"].ToString());
                                    cmdinda.Parameters.Add("@MATOI", OleDbType.Double).Value = classdc.dungchung.kieudouble(dr15["MATOI"].ToString());
                                    cmdinda.Parameters.Add("@MUCHT", OleDbType.Double).Value = classdc.dungchung.kieudouble(dr15["MUCHT"].ToString());
                                    cmdinda.Parameters.Add("@Namhoc", OleDbType.VarChar).Value = dr15["Namhoc"].ToString();
                                    if (dr15["nkxtu"].ToString() != "")
                                    {
                                        cmdinda.Parameters.Add("@nkxtu", OleDbType.Date).Value = Convert.ToDateTime(dr15["nkxtu"].ToString(), cultuere);
                                    }
                                    if (dr15["nkxden"].ToString() != "")
                                    {
                                        cmdinda.Parameters.Add("@nkxden", OleDbType.Date).Value = Convert.ToDateTime(dr15["nkxden"].ToString(), cultuere);
                                    }
                                    cmdinda.ExecuteNonQuery();
                                }
                                dr15.Close();
                                #endregion

                            }
                            Settings1.Default.namlv = pathlv;
                            Settings1.Default.Save();
                            DC1.namdllv = pathlv;

                            Settings1.Default.thumucdoi = fd;
                            Settings1.Default.Save();
                            Settings1.Default.namdoi = "QLDD" + cbnam.Text + ".mdb";
                            Settings1.Default.Save();

                            Connect.Reconnect();
                            //MessageBox.Show("Năm dữ liệu đã được tạo ra!", "Thông báo");
                            this.Visible = false;
                            Form frm = new KPBT.Forms.frmXNBQ();
                            frm.ShowDialog();
                            this.Close();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Hay kiểm tra lại các thông tin!", "Thông báo");
            }
        }

        private void frmTaoNamMoi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
            Program.openfrm = "";
        }

        private void ckbNamLV_CheckedChanged(object sender, EventArgs e)
        {
            lbtm.Visible = !lbtm.Visible;
            labelX2.Visible = !labelX2.Visible;
            labelX1.Visible = !labelX1.Visible;
            cbnam.Visible = !cbnam.Visible;
            if (ckbNamLV.Checked == false)
                labelX21.Text = "Tạo năm";
            else
                labelX21.Text = "Đổi năm";
        }
    }
}
