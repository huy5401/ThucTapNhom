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
using DAL;

namespace VKTB
{
    public partial class DangNhap : DevExpress.XtraEditors.XtraForm
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        public static string MaCB;
        public static string Quyen;
        public static string MaBM;

        private void DangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar= true;
        }

        private void buttonXem_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.UseSystemPasswordChar == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (D_QLCanBo.DangNhap(txtTenDangNhap.Text, txtMatKhau.Text) == 1)
            {
                DataTable dt= new DataTable();
                dt = D_QLCanBo.LayALLThongTinCanBo(txtTenDangNhap.Text, txtMatKhau.Text);
                MaCB = dt.Rows[0][0].ToString();
                MaBM = dt.Rows[0][1].ToString();
                Quyen = dt.Rows[0][2].ToString();
                frmRibbonForm form=new frmRibbonForm();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai");
            }
        }
    }
}