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
using DevExpress.XtraReports.Parameters;
using KPBT.Modules;


namespace KPBT.Forms.ThoaiKX
{
    public partial class ThoaiSoTKPA : Office2007Form
    {
        public ThoaiSoTKPA()
        {
            InitializeComponent();
        }  
        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ThoaiSoQTM_Load(object sender, EventArgs e)
        {

            dtpNTTu.EditValue = thongtinketxuat.Default.NTT.ToString();
            dtpNTDen.EditValue = thongtinketxuat.Default.NTD.ToString();
        }
        private double soluongton(string ngaythang, string mahang)
        {            
            double kq1 = Connect.doubltt(Connect.TruyVandr("Select nxct.*,nhxu.* From nxct INNER JOIN nhxu ON nxct.idnxct = nhxu.idnxct where nhxu.matp = '" + mahang + "' and nxct.ntnx < #" + classdc.dungchung.thaydoi(ngaythang) + "#"), "slnh");
            double kq2 = Connect.doubltt(Connect.TruyVandr("Select nhxu.slxu+nhxu.slxuccnt+nhxu.slxubpnt+nhxu.slxumg+nhxu.slxuccmg+nhxu.slxubpmg as slxu From nxct INNER JOIN nhxu ON nxct.idnxct = nhxu.idnxct where nhxu.matp = '" + mahang + "' and nxct.ntnx < #" + classdc.dungchung.thaydoi(ngaythang) + "#"), "slxu");
            double kq = kq1 - kq2;
            return kq;
        }
        private double sotienton(string ngaythang, string mahang)
        {
            double kq1 = Connect.doubltt(Connect.TruyVandr("Select nxct.*,nhxu.* From nxct INNER JOIN nhxu ON nxct.idnxct = nhxu.idnxct where nhxu.matp = '" + mahang + "' and nxct.ntnx < #" + classdc.dungchung.thaydoi(ngaythang) + "#"), "ttnh");
            double kq2 = Connect.doubltt(Connect.TruyVandr("Select nhxu.ttxu + nhxu.ttxumg as ttxu  From nxct INNER JOIN nhxu ON nxct.idnxct = nhxu.idnxct where nhxu.matp = '" + mahang + "' and nxct.ntnx < #" + classdc.dungchung.thaydoi(ngaythang) + "#"), "ttxu");
            double kq = kq1 - kq2;
            return kq;
        }
        private double thangtruoc()
        {
            double kq1 = Connect.doubltt(Connect.TruyVandr("Select thutien.sotienthu From thutien inner join dmthu on thutien.makhthu = dmthu.makhthu where dmthu.tenkhoanthu = 'Tiền ăn' and thutien.ngaythu <= #" + classdc.dungchung.thaydoi(dtpNTTu.Text) + "#"), "sotienthu");
            double kq2 = Connect.doubltt(Connect.TruyVandr("Select nhxu.ttxu + nhxu.ttxumg as ttxu  From nxct INNER JOIN nhxu ON nxct.idnxct = nhxu.idnxct where nxct.ntnx < #" + classdc.dungchung.thaydoi(dtpNTTu.Text) + "#"), "ttxu");
            double kq3 = Connect.doubltt(Connect.TruyVandr("Select thtro From nxct where ntnx < #" + classdc.dungchung.thaydoi(dtpNTTu.Text) + "#"), "thtro");
            double kq4 = Connect.doubltt(Connect.TruyVandr("Select chibosung From nxct where ntnx < #" + classdc.dungchung.thaydoi(dtpNTTu.Text) + "#"), "chibosung");
            double kq = kq1 - kq2 + kq3 - kq4;
            return kq;
        }
        private double cuoithang()
        {
            double kq1 = Connect.doubltt(Connect.TruyVandr("Select thutien.sotienthu From thutien inner join dmthu on thutien.makhthu = dmthu.makhthu where dmthu.tenkhoanthu = 'Tiền ăn' and thutien.ngaythu <= #" + classdc.dungchung.thaydoi(dtpNTDen.Text) + "#"), "sotienthu");
            double kq2 = Connect.doubltt(Connect.TruyVandr("Select nhxu.ttxu + nhxu.ttxumg as ttxu  From nxct INNER JOIN nhxu ON nxct.idnxct = nhxu.idnxct where nxct.ntnx <= #" + classdc.dungchung.thaydoi(dtpNTDen.Text) + "#"), "ttxu");
            double kq3 = Connect.doubltt(Connect.TruyVandr("Select thtro From nxct where ntnx <= #" + classdc.dungchung.thaydoi(dtpNTDen.Text) + "#"), "thtro");
            double kq4 = Connect.doubltt(Connect.TruyVandr("Select chibosung From nxct where ntnx <= #" + classdc.dungchung.thaydoi(dtpNTDen.Text) + "#"), "chibosung");
            double kq = kq1 - kq2 + kq3 - kq4;
            return kq;
        }
        private double tienanthuathieutt()
        {
            double kq1 = Connect.doubltt(Connect.TruyVandr("Select MA*BS as TienAn From baoan where ntan between #" + classdc.dungchung.thaydoi(dtpNTTu.Text) + "# and #" + classdc.dungchung.thaydoi(dtpNTDen.Text) + "# "), "TienAn");
            double kq2 = Connect.doubltt(Connect.TruyVandr("Select nhxu.ttxu + nhxu.ttxumg as ttxu  From nxct INNER JOIN nhxu ON nxct.idnxct = nhxu.idnxct where nxct.ntnx between #" + classdc.dungchung.thaydoi(dtpNTTu.Text) + "# and #" + classdc.dungchung.thaydoi(dtpNTDen.Text) + "#"), "ttxu");
            double kq = kq1 - kq2;
            return kq;
        }
        private double tienanthuathieuct()
        {
            double kq1 = Connect.doubltt(Connect.TruyVandr("Select MA*BS as TienAn From baoan where ntan <= #" + classdc.dungchung.thaydoi(dtpNTDen.Text) + "# "), "TienAn");
            double kq2 = Connect.doubltt(Connect.TruyVandr("Select nhxu.ttxu + nhxu.ttxumg as ttxu  From nxct INNER JOIN nhxu ON nxct.idnxct = nhxu.idnxct where nxct.ntnx <= #" + classdc.dungchung.thaydoi(dtpNTDen.Text) + "#"), "ttxu");
            double kq = kq1 - kq2;
            return kq;
        }
        private double nhatre(string ngaythang, string loai)
        {
            double kq = 0;
            OleDbDataReader dr = Connect.TruyVandr("SELECT distinct baoan.mshs FROM phong INNER JOIN baoan ON phong.tenphong = baoan.tenphong where phong.nhatre ='" + loai + "'  and  baoan.ntan = #" + classdc.dungchung.thaydoi(ngaythang) + "#");
            while (dr.Read())
            {
                kq += 1;
            } dr.Close();
            return kq;
        }        
        private double protein(string mahang, string ngaythang,string loai)
        {
            double kq = 0;
            if (loai == "Nhà trẻ")
            {
                 kq = Connect.doubltt(Connect.TruyVandr("Select (slxu+slxuccnt+slxubpnt)*protein as P" +
                    " From dmtp INNER JOIN (nxct INNER JOIN nhxu ON nxct.idnxct = nhxu.idnxct) ON dmtp.matp = nhxu.matp" +
                    " where nxct.ntnx = #" + classdc.dungchung.thaydoi(ngaythang) + "# and nhxu.matp = '" + mahang + "'"), "P");
            }
            else
            {
                 kq = Connect.doubltt(Connect.TruyVandr("Select (slxumg+slxuccmg+slxubpmg)*protein as P" +
                " From dmtp INNER JOIN (nxct INNER JOIN nhxu ON nxct.idnxct = nhxu.idnxct) ON dmtp.matp = nhxu.matp" +
                " where nxct.ntnx = #" + classdc.dungchung.thaydoi(ngaythang) + "# and nhxu.matp = '" + mahang + "'"), "P");
            }
            return kq;
        }
        private double lipid(string mahang, string ngaythang, string loai)
        {
            double kq = 0;
            if (loai == "Nhà trẻ")
            {
                 kq = Connect.doubltt(Connect.TruyVandr("Select (slxu+slxuccnt+slxubpnt)*chatbeo as L" +
                    " From dmtp INNER JOIN (nxct INNER JOIN nhxu ON nxct.idnxct = nhxu.idnxct) ON dmtp.matp = nhxu.matp" +
                    " where nxct.ntnx = #" + classdc.dungchung.thaydoi(ngaythang) + "# and nhxu.matp = '" + mahang + "'"), "L");
            }
            else
            {
                 kq = Connect.doubltt(Connect.TruyVandr("Select (slxumg+slxuccmg+slxubpmg)*chatbeo as L" +
                " From dmtp INNER JOIN (nxct INNER JOIN nhxu ON nxct.idnxct = nhxu.idnxct) ON dmtp.matp = nhxu.matp" +
                " where nxct.ntnx = #" + classdc.dungchung.thaydoi(ngaythang) + "# and nhxu.matp = '" + mahang + "'"), "L");
            }
            return kq;
        }
        private double Gluxit(string mahang, string ngaythang, string loai)
        {
            double kq = 0;
            if (loai == "Nhà trẻ")
            {
                 kq = Connect.doubltt(Connect.TruyVandr("Select (slxu+slxuccnt+slxubpnt)*carbohydrat as G" +
                    " From dmtp INNER JOIN (nxct INNER JOIN nhxu ON nxct.idnxct = nhxu.idnxct) ON dmtp.matp = nhxu.matp" +
                    " where nxct.ntnx = #" + classdc.dungchung.thaydoi(ngaythang) + "# and nhxu.matp = '" + mahang + "'"), "G");
            }
            else
            {
                 kq = Connect.doubltt(Connect.TruyVandr("Select (slxumg+slxuccmg+slxubpmg)*carbohydrat as G" +
                " From dmtp INNER JOIN (nxct INNER JOIN nhxu ON nxct.idnxct = nhxu.idnxct) ON dmtp.matp = nhxu.matp" +
                " where nxct.ntnx = #" + classdc.dungchung.thaydoi(ngaythang) + "# and nhxu.matp = '" + mahang + "'"), "G");
            }
            return kq;
        }
        private double B1(string mahang, string ngaythang, string loai)
        {
            double kq = 0;
            if (loai == "Nhà trẻ")
            {
                 kq = Connect.doubltt(Connect.TruyVandr("Select (slxu+slxuccnt+slxubpnt)*vitaminb as B" +
                    " From dmtp INNER JOIN (nxct INNER JOIN nhxu ON nxct.idnxct = nhxu.idnxct) ON dmtp.matp = nhxu.matp" +
                    " where nxct.ntnx = #" + classdc.dungchung.thaydoi(ngaythang) + "# and nhxu.matp = '" + mahang + "'"), "B");
            }
            else
            {
                 kq = Connect.doubltt(Connect.TruyVandr("Select (slxumg+slxuccmg+slxubpmg)*vitaminb as B" +
                " From dmtp INNER JOIN (nxct INNER JOIN nhxu ON nxct.idnxct = nhxu.idnxct) ON dmtp.matp = nhxu.matp" +
                " where nxct.ntnx = #" + classdc.dungchung.thaydoi(ngaythang) + "# and nhxu.matp = '" + mahang + "'"), "B");
            }
            return kq;
        }
        private double Calo(string mahang, string ngaythang, string loai)
        {
            double kq = 0;
            if (loai == "Nhà trẻ")
            {
                 kq = Connect.doubltt(Connect.TruyVandr("Select (slxu+slxuccnt+slxubpnt)*nangluong as Cal" +
                    " From dmtp INNER JOIN (nxct INNER JOIN nhxu ON nxct.idnxct = nhxu.idnxct) ON dmtp.matp = nhxu.matp" +
                    " where nxct.ntnx = #" + classdc.dungchung.thaydoi(ngaythang) + "# and nhxu.matp = '" + mahang + "'"), "Cal");
            }
            else
            {
                 kq = Connect.doubltt(Connect.TruyVandr("Select (slxumg+slxuccmg+slxubpmg)*nangluong as Cal" +
                " From dmtp INNER JOIN (nxct INNER JOIN nhxu ON nxct.idnxct = nhxu.idnxct) ON dmtp.matp = nhxu.matp" +
                " where nxct.ntnx = #" + classdc.dungchung.thaydoi(ngaythang) + "# and nhxu.matp = '" + mahang + "'"), "Cal");
            }
            return kq;
        }
        private void insertDC()
        {
            string sql = "Insert into TblDC (TEN2,TEN1,SL3,SL4,SL5,SL6,SL7,SL8,NTGS,TEN3,TEN4,TEN5,TEN6,TEN7,TEN8)" +
            "Select distinct nhxu.matp, nhxu.tentp, nhxu.slnh, nhxu.dongia, nhxu.ttnh, nhxu.slxu+nhxu.slxuccnt+nhxu.slxubpnt+nhxu.slxumg+nhxu.slxuccmg+nhxu.slxubpmg as slxu,"+
            " nhxu.dongia, nhxu.ttxu + nhxu.ttxumg as ttxu ,nxct.ntnx, nxct.tenbcsnt,nxct.tenbccnt,nxct.tenbpnt,nxct.tenbcsmg,nxct.tenbccmg,nxct.tenbpmg"
                + " From nxct INNER JOIN nhxu ON nxct.idnxct = nhxu.idnxct Where nxct.ntnx Between #" + classdc.dungchung.thaydoi(dtpNTTu.Text) + "# and #"
                                                            + classdc.dungchung.thaydoi(dtpNTDen.Text) + "#";
            Connect.ThaoTac(sql);
        }
        private void updateDC()
        {
            OleDbDataReader dr = Connect.TruyVandr("Select * From TblDC");
            while (dr.Read())
            {
                string sql = "update TblDC set SL1=@SL1,SL2=@SL2,SL25=@SL25,SL11=@SL11,SL12=@SL12,SL13=@SL13,SL14=@SL14,SL15=@SL15,SL16=@SL16,SL17=@SL17,SL18=@SL18,SL19=@SL19,SL20=@SL20,SL21=@SL21,SL22=@SL22,SL23=@SL23,SL24=@SL24 where ID = " + Convert.ToInt64(dr["ID"].ToString());
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@SL1", OleDbType.Double).Value = soluongton(dr["NTGS"].ToString(), dr["TEN2"].ToString());
                cmd.Parameters.Add("@SL2", OleDbType.Double).Value = sotienton(dr["NTGS"].ToString(), dr["TEN2"].ToString());
                cmd.Parameters.Add("@SL25", OleDbType.Double).Value = Connect.doubltt(Connect.TruyVandr("Select Sum(BS) as SumofBS from baoan where ntan = #" + classdc.dungchung.thaydoi(dr["NTGS"].ToString()) + "#"), "SumofBS");
                cmd.Parameters.Add("@SL11", OleDbType.Double).Value = nhatre(dr["NTGS"].ToString(),"Nhà trẻ");
                cmd.Parameters.Add("@SL12", OleDbType.Double).Value = Connect.doubltt(Connect.TruyVandr("SELECT BS*MA as TienAn FROM phong INNER JOIN baoan ON phong.tenphong = baoan.tenphong where phong.nhatre ='Nhà trẻ'  and  baoan.ntan = #" + classdc.dungchung.thaydoi(dr["NTGS"].ToString()) + "#"), "TienAn");
                cmd.Parameters.Add("@SL13", OleDbType.Double).Value = protein(dr["TEN2"].ToString(), dr["NTGS"].ToString(), "Nhà trẻ");
                cmd.Parameters.Add("@SL14", OleDbType.Double).Value = lipid(dr["TEN2"].ToString(), dr["NTGS"].ToString(), "Nhà trẻ");
                cmd.Parameters.Add("@SL15", OleDbType.Double).Value = Gluxit(dr["TEN2"].ToString(), dr["NTGS"].ToString(), "Nhà trẻ");
                cmd.Parameters.Add("@SL16", OleDbType.Double).Value = B1(dr["TEN2"].ToString(), dr["NTGS"].ToString(), "Nhà trẻ");
                cmd.Parameters.Add("@SL17", OleDbType.Double).Value = Calo(dr["TEN2"].ToString(), dr["NTGS"].ToString(), "Nhà trẻ");
                cmd.Parameters.Add("@SL18", OleDbType.Double).Value = nhatre(dr["NTGS"].ToString(), "Mẫu giáo");
                cmd.Parameters.Add("@SL19", OleDbType.Double).Value = Connect.doubltt(Connect.TruyVandr("SELECT BS*MA as TienAn FROM phong INNER JOIN baoan ON phong.tenphong = baoan.tenphong where phong.nhatre ='Mẫu giáo'  and  baoan.ntan = #" + classdc.dungchung.thaydoi(dr["NTGS"].ToString()) + "#"), "TienAn");
                cmd.Parameters.Add("@SL20", OleDbType.Double).Value = protein(dr["TEN2"].ToString(), dr["NTGS"].ToString(), "Mẫu giáo");
                cmd.Parameters.Add("@SL21", OleDbType.Double).Value = lipid(dr["TEN2"].ToString(), dr["NTGS"].ToString(), "Mẫu giáo");
                cmd.Parameters.Add("@SL22", OleDbType.Double).Value = Gluxit(dr["TEN2"].ToString(), dr["NTGS"].ToString(), "Mẫu giáo");
                cmd.Parameters.Add("@SL23", OleDbType.Double).Value = B1(dr["TEN2"].ToString(), dr["NTGS"].ToString(), "Mẫu giáo");
                cmd.Parameters.Add("@SL24", OleDbType.Double).Value = Calo(dr["TEN2"].ToString(), dr["NTGS"].ToString(), "Mẫu giáo");
                Connect.LuuDL(cmd);
            }
            dr.Close();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            Connect.ThaoTac("Delete * From TblDC");
            insertDC();
            updateDC();
            DataSet dts = new DataSet();
            DataTable dt = Connect.TruyVandt("Select * From TblDC");
            dt.TableName = "TblDC";
            dts.Tables.Add(dt);
            Reports.SoTKPA rpt = new Reports.SoTKPA();
            frmHienThi frm = new frmHienThi();            
            //Dataset.dsTblDC dts = new Dataset.dsTblDC();
            //foreach (DataRow row in Connect.TruyVandt("Select distinct nhxu.matp, nhxu.tentp, nhxu.slnh, nhxu.dongia, nhxu.ttnh, nhxu.slxu, nhxu.dongia, nhxu.ttxu,nxct.ntnx"
            //    + " From nxct INNER JOIN nhxu ON nxct.idnxct = nhxu.idnxct Where nxct.ntnx Between #" + DC1.ngaythang(dtpNTTu.Text) + "# and #"
            //                                                + DC1.ngaythang(dtpNTDen.Text) + "#").Rows)
            //    dts.TblDC.Rows.Add(null, row["ntnx"], row["ntnx"], row["tentp"], row["matp"], "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "",
            //        0,0,row["slnh"],row["dongia"],row["ttnh"],row["slxu"],row["dongia"],row["ttxu"]);
            //foreach (DataRow row in dts.TblDC.Rows)
            //{
            //    row["SL1"] = soluongton(row["NTGS"].ToString(), row["TEN2"].ToString());
            //    row["SL2"] = sotienton(row["NTGS"].ToString(), row["TEN2"].ToString());
            //}
            //rpt.Huyen.Value = thongtinketxuat.Default.tendv.ToString();
            //rpt.NTNSo.Value = thongtinketxuat.Default.diadanh.ToString() + ", ngay ... thang ... năm ......";
            //rpt.HTNGSo.Value = thongtinketxuat.Default.thuquy.ToString();
            //rpt.HTKeTT.Value = thongtinketxuat.Default.ptkt.ToString();
            //rpt.HTNK.Value = thongtinketxuat.Default.ttdv.ToString();
            rpt.Namhoc.Value = thongtinketxuat.Default.namhoc.ToString();
            rpt.DiaDanh.Value = thongtinketxuat.Default.diadanh.ToString();
            rpt.TenDV.Value = thongtinketxuat.Default.tendv.ToString();
            rpt.Thangnam.Value = "THÁNG " + Convert.ToDateTime(dtpNTTu.Text).Month + " NĂM " + Convert.ToDateTime(dtpNTTu.Text).Year;
            rpt.Thangtruoc.Value = thangtruoc().ToString("#,#");
            rpt.SoVett.Value = Connect.doubltt(Connect.TruyVandr("Select thutien.sothu  FROM thutien INNER JOIN dmthu ON thutien.makhthu = dmthu.makhthu where thutien.ngaythu between #" + classdc.dungchung.thaydoi(dtpNTTu.Text) + "# and #" + classdc.dungchung.thaydoi(dtpNTDen.Text) + "# and dmthu.tenkhoanthu = 'Tiền ăn'"), "sothu").ToString("#,#");
            rpt.Thanhtientt.Value = Connect.doubltt(Connect.TruyVandr("Select thutien.sotienthu FROM thutien INNER JOIN dmthu ON thutien.makhthu = dmthu.makhthu where thutien.ngaythu between #" + classdc.dungchung.thaydoi(dtpNTTu.Text) + "# and #" + classdc.dungchung.thaydoi(dtpNTDen.Text) + "# and dmthu.tenkhoanthu = 'Tiền ăn'"), "sotienthu").ToString("#,#");
            rpt.nguonbxtt.Value = Connect.doubltt(Connect.TruyVandr("Select thtro from nxct where ntnx between #" + classdc.dungchung.thaydoi(dtpNTTu.Text) + "# and #" + classdc.dungchung.thaydoi(dtpNTDen.Text) + "#"), "thtro").ToString("#,#");
            rpt.Sobuaandc.Value = Connect.doubltt(Connect.TruyVandr("Select Sum(BS) as SumofBS from baoan where ntan between #" + classdc.dungchung.thaydoi(dtpNTTu.Text) + "# and #" + classdc.dungchung.thaydoi(dtpNTDen.Text) + "#"), "SumofBS").ToString("#,#");
            rpt.tienandc.Value = Connect.doubltt(Connect.TruyVandr("Select MA*BS as TienAn From baoan where ntan between #" + classdc.dungchung.thaydoi(dtpNTTu.Text) + "# and #" + classdc.dungchung.thaydoi(dtpNTDen.Text) + "# "), "TienAn").ToString("#,#");
            rpt.Tienanthuathieu.Value = tienanthuathieutt().ToString("#,#");
            rpt.nguonbxdc.Value = Connect.doubltt(Connect.TruyVandr("Select chibosung from nxct where ntnx between #" + classdc.dungchung.thaydoi(dtpNTTu.Text) + "# and #" + classdc.dungchung.thaydoi(dtpNTDen.Text) + "#"), "chibosung").ToString("#,#");
            rpt.toncuoithang.Value = cuoithang().ToString("#,#");
            rpt.SoVeton.Value = (Connect.doubltt(Connect.TruyVandr("Select thutien.sothu FROM thutien INNER JOIN dmthu ON thutien.makhthu = dmthu.makhthu where thutien.ngaythu <= #" + classdc.dungchung.thaydoi(dtpNTDen.Text) + "# and dmthu.tenkhoanthu = 'Tiền ăn'"), "sothu")
                - Connect.doubltt(Connect.TruyVandr("Select Sum(BS) as SumofBS from baoan where ntan <= #" + classdc.dungchung.thaydoi(dtpNTDen.Text) + "#"), "SumofBS")).ToString("#,#");
            rpt.thanhtienveton.Value  = (Connect.doubltt(Connect.TruyVandr("Select thutien.sotienthu FROM thutien INNER JOIN dmthu ON thutien.makhthu = dmthu.makhthu where thutien.ngaythu <= #" + classdc.dungchung.thaydoi(dtpNTDen.Text) + "# and dmthu.tenkhoanthu = 'Tiền ăn'"), "sotienthu")
                - Connect.doubltt(Connect.TruyVandr("Select MA*BS as TienAn From baoan where ntan <= #" + classdc.dungchung.thaydoi(dtpNTDen.Text) + "# "), "TienAn")).ToString("#,#");
            rpt.tontienanthuathieu.Value = tienanthuathieuct().ToString("#,#");
            rpt.nguonbxton.Value = (Connect.doubltt(Connect.TruyVandr("Select thtro from nxct where ntnx <= #" + classdc.dungchung.thaydoi(dtpNTDen.Text) + "#"), "thtro") -
                Connect.doubltt(Connect.TruyVandr("Select chibosung from nxct where ntnx <= #" + classdc.dungchung.thaydoi(dtpNTDen.Text) + "#"), "chibosung")).ToString("#,#");
            frm.printControl1.PrintingSystem = rpt.PrintingSystem;
            rpt.DataSource = dts;
            rpt.CreateDocument();
            frm.ShowDialog();
            this.Close();
        }

        private void ThoaiSoQTM_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }
    }
}
