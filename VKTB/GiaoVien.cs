using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VKTB
{
    public partial class GiaoVien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public GiaoVien()
        {
            InitializeComponent();
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}