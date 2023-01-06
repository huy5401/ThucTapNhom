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
    public partial class TaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public TaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void TaoTaiKhoan_Load(object sender, EventArgs e)
        {
            DsTaiKhoan.DataSource = D_QLCanBo.ThongTinTaiKhoan(DangNhap.MaBM);
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
/*            DataRow hang = gridView1.GetFocusedDataRow();
            DangNhap.MaCB = hang["MaCB"].ToString();
*/
            DataTable dt = new DataTable();
            dt = D_QLCanBo.ThongTinTaiKhoan(DangNhap.MaBM);
            txtMaTK.Text = dt.Rows[0][0].ToString();
            txtMaCB.Text = dt.Rows[0][1].ToString();
            txtTenTK.Text = dt.Rows[0][2].ToString();
            txtMatKhau.Text = dt.Rows[0][3].ToString();
            txtQuyen.Text = dt.Rows[0][4].ToString();

            groupThongTinTK.Enabled = false;
        }

        void loadThongTinTK()
        {
            DsTaiKhoan.DataSource = D_QLCanBo.ThongTinTaiKhoan(DangNhap.MaBM);
        }

        private void btnThemTT_Click(object sender, EventArgs e)
        {
            ThemTK themtk = new ThemTK();
            themtk.ShowDialog();
            loadThongTinTK();
        }
    }
}