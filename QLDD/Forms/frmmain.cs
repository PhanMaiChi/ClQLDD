using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.OleDb;
using KPBT.Modules;

namespace KPBT.Forms
{
    public partial class frmmain : Office2007Form
    {        
        public frmmain()
        {
            InitializeComponent();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            //this.Text = "Phần mềm quản lý dinh dưỡng - " + thongtinketxuat.Default.tendv.ToString() + " (Năm dữ liệu: " + Settings1.Default.namlv.ToString()+")";
            txtPassword.Focus();
            try
            {
                string sql = "Drop Table TblDC";
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = sql;
                Modules.Connect.LuuDL(cmd);
                string sqlcr = "Create table TblDC(ID AUTOINCREMENT Primary Key, NTCT Datetime, NTGS Datetime, TEN1 Varchar(250), TEN2 Varchar(250),";
                sqlcr = sqlcr + "TEN3 Varchar(250),TEN4 Varchar(250),TEN5 Varchar(250),TEN6 Varchar(250),TEN7 Varchar(250),TEN8 Varchar(250),TEN9 Varchar(250),TEN10 Varchar(250),";
                sqlcr = sqlcr + "TEN11 Varchar(250),TEN12 Varchar(250),TEN13 Varchar(250),TEN14 Varchar(250),TEN15 Varchar(250),TEN16 Varchar(250),TEN17 Varchar(250),TEN18 Varchar(250),TEN19 Varchar(250),TEN20 Varchar(250),";
                sqlcr = sqlcr + "SL1 double default 0,SL2 double default 0,SL3 double default 0,SL4 double default 0,SL5 double default 0,SL6 double default 0,SL7 double default 0,SL8 double default 0,SL9 double default 0,SL10 double default 0,SL11 double default 0,SL12 double default 0,";
                sqlcr = sqlcr + "SL13 double default 0,SL14 double default 0,SL15 double default 0,SL16 double default 0,SL17 double default 0,SL18 double default 0,SL19 double default 0,SL20 double default 0";
                sqlcr = sqlcr + ",SL21 double default 0,SL22 double default 0,SL23 double default 0,SL24 double default 0,SL25 double default 0)";
                OleDbCommand cmdcr = new OleDbCommand();
                cmdcr.CommandText = sqlcr;
                Modules.Connect.LuuDL(cmdcr);
            }
            catch
            {
            }
            txttendv.Text = thongtinketxuat.Default.tendv.ToString();
            txtNamLV.Text = Settings1.Default.namdoi.ToString();
            txtduongdan.Text = Settings1.Default.thumucdoi.ToString();
            lbhotro.Text = "Số điện thoại hỗ trợ: 04.3 634 39 51";
            //Settings1.Default.dc = "";
            //Settings1.Default.Save();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if ((txtUsername.Text == Settings1.Default.namend.ToString()) && (txtPassword.Text == Settings1.Default.mknd.ToString())&&(Settings1.Default.dc == "Dc"))
            {
                mnTCTC.Enabled = true;
                tsmn.Enabled = true;
                grpdn.Visible = false;
                xnbq.Enabled = false;
                thongtinketxuat.Default.bt = txtUsername.Text;
                thongtinketxuat.Default.Save();
                //Settings1.Default.dc = "";
                //Settings1.Default.Save();
            }
            else
            {
                if ((txtUsername.Text == "trung") && (txtPassword.Text == Settings1.Default.unname.ToString()))
                {
                    mnTCTC.Enabled = true;
                    tsmn.Enabled = true;
                    grpdn.Visible = false;
                    thongtinketxuat.Default.bt = txtUsername.Text;
                    thongtinketxuat.Default.Save();
                }
                else
                {
                    if ((txtUsername.Text == "hieu") && (txtPassword.Text == "hieu19800515"))
                    {
                        mnTCTC.Enabled = true;
                        tsmn.Enabled = true;
                        grpdn.Visible = false;
                        xnbq.Enabled = true;
                        //thongtinketxuat.Default.bt = txtUsername.Text;
                        //thongtinketxuat.Default.Save();
                        //Modules.DC1.hieut = txtUsername.Text;
                        //Modules.DC1.hieup = txtPassword.Text;
                    }
                    else
                    {
                        MessageBox.Show("Chưa xác nhận bản quyền, hãy gọi đến công ty!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if ((txtUsername.Text == Settings1.Default.namend.ToString()) && (txtPassword.Text == Settings1.Default.mknd.ToString()) && (Settings1.Default.dc == "Dc"))
                {
                    mnTCTC.Enabled = true;
                    tsmn.Enabled = true;
                    grpdn.Visible = false;
                    xnbq.Enabled = false;
                    thongtinketxuat.Default.bt = txtUsername.Text;
                    thongtinketxuat.Default.Save();
                }                
                else
                {
                    if ((txtUsername.Text == "hieu") && (txtPassword.Text == "hieu19800515"))
                    {
                        mnTCTC.Enabled = true;
                        tsmn.Enabled = true;
                        grpdn.Visible = false;
                        xnbq.Enabled = true;
                        thongtinketxuat.Default.bt = txtUsername.Text;
                        thongtinketxuat.Default.Save();
                        Modules.DC1.hieut = txtUsername.Text;
                        Modules.DC1.hieup = txtPassword.Text;
                    }
                    else
                    {
                        MessageBox.Show("Chưa xác nhận bản quyền, hãy gọi đến công ty!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new frmdanhsachhs();
                frm.MdiParent = this;
                frm.Show();                
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new frmnhapbaoanN();
                frm.MdiParent = this;
                frm.Show();                
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new frmnhapnxtpmn();
                frm.MdiParent = this;
                frm.Show();                
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            
        }

        private void thoátKhỏiChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi chương trình!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                try
                {
                    string sql = "Drop Table TblDC";
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = sql;
                    Modules.Connect.LuuDL(cmd);
                    string sqlcr = "Create table TblDC(ID AUTOINCREMENT Primary Key, ngay1 Datetime, ngay2 Datetime, TEN1 Varchar(250), TEN2 Varchar(250),";
                    sqlcr = sqlcr + "TEN3 Varchar(250),TEN4 Varchar(250),TEN5 Varchar(250),TEN6 Varchar(250),TEN7 Varchar(250),TEN8 Varchar(250),TEN9 Varchar(250),TEN10 Varchar(250),";
                    sqlcr = sqlcr + "TEN11 Varchar(250),TEN12 Varchar(250),TEN13 Varchar(250),TEN14 Varchar(250),TEN15 Varchar(250),TEN16 Varchar(250),TEN17 Varchar(250),TEN18 Varchar(250),TEN19 Varchar(250),TEN20 Varchar(250),";
                    sqlcr = sqlcr + "SL1 double default 0,SL2 double default 0,SL3 double default 0,SL4 double default 0,SL5 double default 0,SL6 double default 0,SL7 double default 0,SL8 double default 0,SL9 double default 0,SL10 double default 0,SL11 double default 0,SL12 double default 0,";
                    sqlcr = sqlcr + "SL13 double default 0,SL14 double default 0,SL15 double default 0,SL16 double default 0,SL17 double default 0,SL18 double default 0,SL19 double default 0,SL20 double default 0";
                    sqlcr = sqlcr + ",SL21 double default 0,SL22 double default 0,SL23 double default 0,SL24 double default 0,SL25 double default 0)";
                    OleDbCommand cmdcr = new OleDbCommand();
                    cmdcr.CommandText = sqlcr;
                    Modules.Connect.LuuDL(cmdcr);
                }
                catch
                {
                }
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new DanhMuc.frmDMLuuMau();
                frm.MdiParent = this;
                frm.Show();                
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nhậpDanhMụcDânTộcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new DanhMuc.frmDMDT();
                frm.MdiParent = this;
                frm.Show();                
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nhậpDanhMụcPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new DanhMuc.frmDMPhongBan();
                frm.MdiParent = this;
                frm.Show();                
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nhậpDanhMụcCánBộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new DanhMuc.frmDMCanBo();
                frm.MdiParent = this;
                frm.Show();                
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nhậpDanhMụcKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new DanhMuc.frmDMKho();
                frm.MdiParent = this;
                frm.Show();               
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nhậpDanhMụcThựcPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new DanhMuc.frmDMThucPham();
                frm.MdiParent = this;
                frm.Show();                
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void danhSáchHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "Select * From hocsinh";
                DataSet ds = new DataSet();
                ds = Modules.Connect.Loadds(ds, sql, "hocsinh");
                Reports.rptdshs rpt = new Reports.rptdshs();
                Forms.frmHienThi frm = new Forms.frmHienThi();
                rpt.tendv.Value = thongtinketxuat.Default.tendv.ToString();
                rpt.ntkx.Value = thongtinketxuat.Default.diadanh.ToString() + ", ngày ... tháng ... năm ........";
                rpt.nlb.Value = thongtinketxuat.Default.nlb.ToString();
                rpt.ttdv.Value = thongtinketxuat.Default.ttdv.ToString();
                rpt.sshs.Value = ds.Tables["hocsinh"].Rows.Count;
                frm.printControl1.PrintingSystem = rpt.PrintingSystem;
                rpt.DataSource = ds;
                rpt.CreateDocument();
                frm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Có lỗi trong khi kết xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void danhSáchBáoĂnTheoTuầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new ThoaiKX.frmThoaiBaChCom();
                frm.MdiParent = this;
                frm.Show();                
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void danhSáchBáoĂnTheoThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new ThoaiKX.frmThoaiBaChComth();
                frm.MdiParent = this;
                frm.Show();                
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void danhSáchBáoĂnTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new ThoaiKX.frmThoaiBaoAHN();
                frm.MdiParent = this;
                frm.Show();                
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }      

        private void lưuMẫuThứcĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new DanhMuc.frmDMLuuMau();
                frm.MdiParent = this;
                frm.Show();                
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void danhSáchHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new frmdanhsachhs();
                frm.MdiParent = this;
                frm.Show();                
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void báoĂnHàngNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new frmnhapbaoan();
                frm.MdiParent = this;
                frm.Show();                
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nhậpXuấtThựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new frmnhapnxct();
                frm.MdiParent = this;
                frm.Show();                
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void xácNhậnBảnQuyềnPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new frmXNBQ();
                frm.MdiParent = this;
                frm.Show();                
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void đổiCơSởDữLiệuLàmViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {             
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                using (Form dn = new frmThoai_DOINAM())
                {

                    //dn.MdiParent = this;
                    dn.ShowDialog();
                    txttendv.Text = thongtinketxuat.Default.tendv.ToString();
                    txtNamLV.Text = Settings1.Default.namdoi.ToString();
                    txtduongdan.Text = Settings1.Default.thumucdoi.ToString();
                    //this.Text = "Phần mềm quản lý dinh dưỡng - " + thongtinketxuat.Default.tendv.ToString() + " (Năm dữ liệu: " + Settings1.Default.namlv.ToString()+")";
                }
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void thôngTinĐơnVịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new NhapHTDV();
                frm.MdiParent = this;
                frm.Show();                
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void thiếtLậpThôngSốPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Win32.RegistryKey rkey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Control Panel\International", true);
                rkey.SetValue("sShortDate", "dd/MM/yyyy");
                rkey.Flush();
                rkey.Close();
                Microsoft.Win32.RegistryKey rkey1 = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Control Panel\International", true);
                rkey1.SetValue("sDecimal", ",");
                rkey1.Flush();
                rkey1.Close();
                Microsoft.Win32.RegistryKey rkey2 = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Control Panel\International", true);
                rkey2.SetValue("sThousand", ".");
                rkey2.Flush();
                rkey2.Close();
                MessageBox.Show("Đã thiết lập xong thông số cho phần mềm!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra, bạn hãy liên hệ với công ty phần mềm để được hỗ trợ!", "Thông báo");
            }
        }

        private void hỗTrợTrựcTuyếnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Application.StartupPath + @"\TeamViewerQS_vi.exe");
            }
            catch
            {
                MessageBox.Show("Bạn hãy kiểm tra xem đã cài phần mềm teamview chưa!", "Thông báo");
            }
        }

        private void saoLưuDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new frmThoai_SAOLUU();
                frm.MdiParent = this;
                frm.Show();                
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void phụcHồiDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new frmThoai_PHUCHOI();
                frm.MdiParent = this;
                frm.Show();                
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void quyếtToánTiềnĂnHàngThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new ThoaiKX.frmThoaiTTQTTAHT();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nhậpThuTiềnHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new Nhapthutien();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nhậnHọcSinhTừFileExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new frmnhanfilecls();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void danhSáchBáoĂnChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new Forms.ThoaiKX.ThoaiDsbachitiet();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nhậpDanhMụcTiêuChuẩnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new DanhMuc.frmDMTCSK();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
              

        private void thu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new Forms.frmQLThu();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nhậpDanhMụcKhoảnThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new Forms.DanhMuc.frmDMKhoanThu();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }       

        private void baoĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new Forms.frmnhapbaoanN();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }       

        private void nhậpChứngTừThuChiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new frmchungtu();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nhậpCácKhoảnThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new frmQLThu();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }        

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new Forms.frmTDSKHS();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void đánhGiáSứcKhỏeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new Forms.frmTDSKHS();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nhậpChứngTừThuChiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new frmchungtu();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nhậpKhoảnThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new frmQLThu();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void sổChợToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new ThoaiKX.frmThoaiSoCho();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void sổGiaoNhậnThựcPhẩmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new ThoaiKX.frmThoaiGiNTP();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void sổLưuMẫuThứcĂnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new ThoaiKX.frmThoaiLuuMTAn();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void sổQuỹTiềnMặtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new ThoaiKX.ThoaiSoQTM();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void sổChiTiếtQuỹToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new ThoaiKX.ThoaiSoCTQuy();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void sổChiTiếtNhậpXuấtTồnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new ThoaiKX.ThoaiSoCTNhapXuatTon();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void sổThuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new Forms.ThoaiKX.ThoaiSoThuvaTT();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void sổNhậtKýThuVàBànGiaoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new Forms.ThoaiKX.ThoaiSoNKBG();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void sổTínhKhẩuPhầnĂnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new Forms.ThoaiKX.ThoaiSoTKPA();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void báoCáoTheoDõiĐánhGiáHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new Forms.ThoaiKX.frmThoaiBcTDSKHS();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void thoátKhỏiChươngTrìnhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi chương trình!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Modules.DC1.iform == 1)
                {                    
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void tạoNămMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new Forms.DanhMuc.frmTaoNamMoi();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void chuyểnSốDưSangNămTớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new Forms.DanhMuc.ChuyenSD();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txttendv_EditValueChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText(txttendv.Text, txttendv.Font);
            txttendv.Width = size.Width;
            txttendv.Height = size.Height;
            lbduongdan.Location = new Point(txttendv.Location.X + size.Width + 10, 0);
            txtduongdan.Location = new Point(lbduongdan.Location.X + lbduongdan.Size.Width + 10, 0);
        }

        private void txtduongdan_EditValueChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText(txtduongdan.Text, txtduongdan.Font);
            txtduongdan.Width = size.Width;
            txtduongdan.Height = size.Height;
            lbnamlv.Location = new Point(txtduongdan.Location.X + txtduongdan.Size.Width + 10, 0);
            txtNamLV.Location = new Point(lbnamlv.Location.X + lbnamlv.Size.Width + 10, 0);
        }

        private void txtNamLV_EditValueChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText(txtNamLV.Text, txtNamLV.Font);
            txtNamLV.Width = size.Width;
            txtNamLV.Height = size.Height;            
        }

        private void lbhotro_TextChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText(lbhotro.Text, lbhotro.Font);
            lbhotro.Width = size.Width;
            lbhotro.Height = size.Height;
            lbhotro.TextAlignment = StringAlignment.Center;
            lbhotro.TextLineAlignment = StringAlignment.Center;
        }

        private void luuTTDV()
        {
            string sql = "Select * From ttdv";
            OleDbDataReader dr = Connect.TruyVandr(sql);
            while (dr.Read())
            {
                thongtinketxuat.Default.diadanh = dr["diadanh"].ToString();
                thongtinketxuat.Default.Save();
                thongtinketxuat.Default.nlb = dr["nlb"].ToString();
                thongtinketxuat.Default.Save();
                thongtinketxuat.Default.ttdv = dr["ttdv"].ToString();
                thongtinketxuat.Default.Save();
                thongtinketxuat.Default.ptkt = dr["ketoan"].ToString();
                thongtinketxuat.Default.Save();
                thongtinketxuat.Default.NTT = dr["nkxtu"].ToString();
                thongtinketxuat.Default.Save();
                thongtinketxuat.Default.NTD = dr["nkxden"].ToString();
                thongtinketxuat.Default.Save();
            }
            dr.Close();
        }

        private void lbduongdan_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string vung = "", namdl = "";
                string dl = "";
                OpenFileDialog fd = new OpenFileDialog();
                fd.InitialDirectory = txtduongdan.Text;
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    dl = fd.FileName.ToString();
                    if (dl.IndexOf(".mdb") == -1)
                    {
                        MessageBox.Show("Không tồn tại file dữ liệu", "Thông báo");
                    }
                    else
                    {
                        if (dl.IndexOf("QLDD.mdb") > 0)
                        {
                            MessageBox.Show("Đây là năm dữ liệu mẫu. Bạn hãy chọn lại!","Thông báo");
                            OpenFileDialog fd1 = new OpenFileDialog();
                            fd1.InitialDirectory = txtduongdan.Text;
                            fd1.ShowDialog();
                        }
                        else
                        {
                            if (dl.IndexOf("QLDD") == -1)
                            {
                                MessageBox.Show("Đây không phải là csdl, bạn chọn lại", "Thông báo");
                                OpenFileDialog fd2 = new OpenFileDialog();
                                fd2.InitialDirectory = txtduongdan.Text;
                                fd2.ShowDialog();
                            }
                            else
                            {
                                Settings1.Default.namlv = dl;
                                Settings1.Default.Save();
                                DC1.namdllv = dl;
                                Connect.Reconnect();
                                luuTTDV();
                                vung = dl.Substring(0, dl.Length - 12);
                                namdl = dl.Substring(dl.Length - 12, 12);
                                Settings1.Default.thumucdoi = vung;
                                Settings1.Default.Save();
                                Settings1.Default.namdoi = namdl;
                                Settings1.Default.Save();
                                txttendv.Text = thongtinketxuat.Default.tendv.ToString();
                                txtNamLV.Text = Settings1.Default.namdoi.ToString();
                                txtduongdan.Text = Settings1.Default.thumucdoi.ToString();
                            }
                        }
                    }                  
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình đổi dữ liệu. Bạn hãy kiểm tra lại!", "Thông báo");
            }
        }       

        private void nhậpDanhMụcBữaĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new Forms.DanhMuc.frmDMBA();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tạoNhómTuổiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new Forms.frmTaonhomtuoi();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void inBiểuĐồDinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new Forms.ThoaiKX.ThoaiTest();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void xâyDựngMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new Forms.frmxaydungMA();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void xâyDựngThựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new Forms.frmxaydungTD();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void xaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void địnhMứcDinhDưỡngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new Forms.frmTaonhomtuoi();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void xâyDựngMónĂnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new Forms.frmxaydungMA();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void xâyDựngThựcĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new Forms.frmxaydungTD();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void xâyDựngKếHoạchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new Forms.frmnhapkehoach();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void xâyDựngKếHoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new Forms.frmnhapkehoach();
                //frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void xâyDựngKếHoạchTheoTuầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new Forms.frmnhapkehoachtuan();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void phiếuTònKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new Forms.ThoaiKX.frmThoaiPhieuTK();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void phiếuXuấtTồnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modules.DC1.iform == 1)
            {
                Modules.DC1.iform = 2;
                Form frm = new Forms.ThoaiKX.frmThoaiPhieuNXT();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần đóng form hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }                
    }
}
