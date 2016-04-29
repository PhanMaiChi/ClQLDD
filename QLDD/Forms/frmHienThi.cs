using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KPBT.Forms
{
    public partial class frmHienThi : DevComponents.DotNetBar.Office2007Form
    {
        public frmHienThi()
        {
            InitializeComponent();
        }

        private void barThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
