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
    public partial class ThoaiSoThuvaTT : Office2007Form
    {
        public ThoaiSoThuvaTT()
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
            DataTable dt = new DataTable();            
            dt.Columns.Add("TEN2", typeof(string));
            dt = Connect.TruyVandt("Select tenkhoanthu as TEN2 from dmthu where tenkhoanthu <> 'Tiền ăn'");
            dt.Columns.Add("TEN1", typeof(Boolean));
            grcMain.DataSource = dt;
        }
        private void button16_Click(object sender, EventArgs e)
        {
            string kt1 = "", kt2 = "", kt3 = "", kt4 = "",kt5 = "Tiền ăn";
            double d = 0, a = 0;
            for (int i = 0; i < grvCT.RowCount; i++)
            {
                if (grvCT.GetRowCellValue(i, colCheck).ToString() == "True" && grvCT.GetRowCellValue(i,colTenKhoanThu).ToString() != "Tiền ăn")
                {
                    d += 1;
                    if (d == 1)
                        kt1 = grvCT.GetRowCellValue(i, colTenKhoanThu).ToString();
                    if (d == 2)
                        kt2 = grvCT.GetRowCellValue(i, colTenKhoanThu).ToString();
                    if (d == 3)
                        kt3 = grvCT.GetRowCellValue(i, colTenKhoanThu).ToString();
                    if (d == 4)
                        kt4 = grvCT.GetRowCellValue(i, colTenKhoanThu).ToString();                                     
                }
            }
            DataTable dt = Connect.TruyVandt("Select * FROM qrThuTT ");
            Dataset.dsTblDC dts = new KPBT.Dataset.dsTblDC();
            foreach (DataRow item in Connect.TruyVandt("Select ngaythu,sophieu,mshs,tenhs,thang From qrThuTT where ngaythu Between #" + DC1.ngaythang(dtpNTTu.Text) + "# and #" + DC1.ngaythang(dtpNTDen.Text) + "# Group by ngaythu,sophieu,mshs,tenhs,thang").Rows)
                dts.qrThuTT.Rows.Add(item["ngaythu"], item["sophieu"], item["mshs"], item["tenhs"],item["thang"]);
            foreach (DataRow item in dts.qrThuTT.Rows)
            {
                //DateTime? ngaythu = item
                item["SL1"] = dcts.TinhToan(dt.Select(" mshs = '" + item["mshs"] + "' and thang = " + double.Parse(item["thang"].ToString()) + " and tenkhoanthu = 'Tiền ăn'"), "SumOfsoluongton");
                item["SL2"] = dcts.TinhToan(dt.Select("mshs = '" + item["mshs"] + "' and thang = " + double.Parse(item["thang"].ToString()) + " and tenkhoanthu = 'Tiền ăn'"), "SumOfsophaithu");
                item["SL3"] = dcts.TinhToan(dt.Select("mshs = '" + item["mshs"] + "' and thang = " + double.Parse(item["thang"].ToString()) + " and tenkhoanthu = 'Tiền ăn'"), "SumOfsotienphaithu");
                if (kt1 != "")
                    item["SL4"] = dcts.TinhToan(dt.Select("mshs = '" + item["mshs"] + "' and thang = " + double.Parse(item["thang"].ToString()) + " and tenkhoanthu = '" + kt1 + "'"), "SumOfsotienphaithu");
                if (kt2 != "")
                    item["SL5"] = dcts.TinhToan(dt.Select("mshs = '" + item["mshs"] + "' and thang = " + double.Parse(item["thang"].ToString()) + " and tenkhoanthu = '" + kt2 + "'"), "SumOfsotienphaithu");
                if (kt3 != "")
                    item["SL6"] = dcts.TinhToan(dt.Select("mshs = '" + item["mshs"] + "' and thang = " + double.Parse(item["thang"].ToString()) + " and tenkhoanthu = '" + kt3 + "'"), "SumOfsotienphaithu");
                if (kt4 != "")
                    item["SL7"] = dcts.TinhToan(dt.Select("mshs = '" + item["mshs"] + "' and thang = " + double.Parse(item["thang"].ToString()) + " and tenkhoanthu = '" + kt4 + "'"), "SumOfsotienphaithu");
                item["SL8"] = dcts.TinhToan(dt.Select("mshs = '" + item["mshs"] + "' and thang = " + double.Parse(item["thang"].ToString()) + " and tenkhoanthu <> '" + kt1 + "' and tenkhoanthu <> '" + kt2 + "'and tenkhoanthu <> '" + kt3 + "'and tenkhoanthu <> '" + kt4 + "' and tenkhoanthu <> '" + kt5 + "'"), "SumOfsotienphaithu");
                item["SL10"] = dcts.TinhToan(dt.Select("mshs = '" + item["mshs"] + "' and thang = " + double.Parse(item["thang"].ToString()) + " and tenkhoanthu = 'Tiền ăn'"), "SumOfsothu");
                item["SL11"] = dcts.TinhToan(dt.Select("mshs = '" + item["mshs"] + "' and thang = " + double.Parse(item["thang"].ToString()) + " and tenkhoanthu = 'Tiền ăn'"), "SumOfsotienthu");                
            }
            Reports.SoThuvaTT rpt = new Reports.SoThuvaTT();
            frmHienThi frm = new frmHienThi();            
            rpt.tendv.Value = thongtinketxuat.Default.tendv.ToString();            
            rpt.thukho.Value = thongtinketxuat.Default.thukho.ToString();
            rpt.ktoan.Value = thongtinketxuat.Default.ptkt.ToString();
            rpt.ttdv.Value = thongtinketxuat.Default.ttdv.ToString();
            rpt.KT1.Value = kt1;
            rpt.KT2.Value = kt2;
            rpt.KT3.Value = kt3;
            rpt.KT4.Value = kt4;
            rpt.KT5.Value = kt5;
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
