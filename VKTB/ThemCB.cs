using DAL;
using DevExpress.XtraEditors;
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
    public partial class ThemCB : DevExpress.XtraEditors.XtraForm
    {
        public ThemCB()
        {
            InitializeComponent();
        }
        //public string MaBMHienTai = "BM01";
        private void ThemCB_Load(object sender, EventArgs e)
        {
            cmbChucVu.DataSource = D_QLCanBo.ALLChucVu();
            cmbChucVu.DisplayMember = "TenCVu";
            cmbChucVu.ValueMember = "MaCVu";

            txtBoMon.Text = DangNhap.MaBM;
            txtBoMon.Enabled=false;
        }

        private void btnThemCB_Click(object sender, EventArgs e)
        {
            D_QLCanBo.ThemCB(txtMaCB.Text, txtTenCB.Text, cmbChucVu.SelectedValue.ToString(), txtBoMon.Text, Int32.Parse(txtSDT.Text));
            MessageBox.Show("Thêm thành công");
            this.Close();
        }
    }
}