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
    public partial class TongTinCN_GV : DevExpress.XtraEditors.XtraForm
    {
        public TongTinCN_GV()
        {
            InitializeComponent();
        }

        private void TongTinCN_GV_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = D_QLCanBo.ThongTinGV(DangNhap.MaCB);
            txtMaCB.Text = dt.Rows[0][0].ToString();
            txtTenCB.Text = dt.Rows[0][1].ToString();
            txtChucVu.Text = dt.Rows[0][2].ToString();
            txtBoMon.Text = dt.Rows[0][3].ToString();
            txtSDT.Text = dt.Rows[0][4].ToString();
            txtTenTK.Text = dt.Rows[0][5].ToString();
            txtMK.Text = dt.Rows[0][6].ToString();

            txtMaCB.Enabled = false;
            txtTenCB.Enabled = false;
            txtChucVu.Enabled = false;
            txtBoMon.Enabled = false;
            txtSDT.Enabled = false;
            txtTenTK.Enabled = false;
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            D_QLCanBo.DoiMK(DangNhap.MaCB, txtMK.Text);
            MessageBox.Show("Đổi mật khẩu thành công");
        }
    }
}