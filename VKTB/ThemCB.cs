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

        private void ThemCB_Load(object sender, EventArgs e)
        {
            cmbChucVu.DataSource = D_QLCanBo.ALLChucVu();
            cmbChucVu.DisplayMember = "TenCVu";
            cmbChucVu.ValueMember = "MaCVu";

            cmbBoMon.DataSource = D_QLCanBo.ALLBoMon();
            cmbBoMon.DisplayMember = "TenBM";
            cmbBoMon.ValueMember = "MaBM";
        }

        private void btnThemCB_Click(object sender, EventArgs e)
        {
            D_QLCanBo.ThemCB(txtMaCB.Text, txtTenCB.Text, cmbChucVu.SelectedValue.ToString(), cmbBoMon.SelectedValue.ToString(), Int32.Parse(txtSDT.Text));
            MessageBox.Show("Thêm thành công");
            this.Close();
        }
    }
}