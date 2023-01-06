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
    public partial class ThemTK : DevExpress.XtraEditors.XtraForm
    {
        public ThemTK()
        {
            InitializeComponent();
        }

        private void ThemTK_Load(object sender, EventArgs e)
        {
            cmbMaCB.DataSource = D_QLCanBo.ALLMaCB_TaoTK(DangNhap.MaBM);
            cmbMaCB.DisplayMember = "macb";
            cmbMaCB.ValueMember = "macb";

            cmbQuyen.DataSource = D_QLCanBo.ALLQuyen();
            cmbQuyen.DisplayMember = "Quyen";
            cmbQuyen.ValueMember = "Quyen";
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            D_QLCanBo.ThemTK(txtMaTK.Text, cmbMaCB.SelectedValue.ToString(), txtTenTK.Text, txtMatKhau.Text, cmbQuyen.SelectedValue.ToString());
            MessageBox.Show("Thêm thành công");
            this.Close();
        }
    }
}