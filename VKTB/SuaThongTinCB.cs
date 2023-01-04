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
using DAL;

namespace VKTB
{
    public partial class SuaThongTinCB : DevExpress.XtraEditors.XtraForm
    {
        public SuaThongTinCB()
        {
            InitializeComponent();
        }

        private void SuaThongTinCB_Load(object sender, EventArgs e)
        {
            //string macb = "CB01";
            DataTable dt=new DataTable();
            dt = D_QLCanBo.ThongTinCB(DangNhap.MaCB);
            txtMaCB.Text = dt.Rows[0][0].ToString();
            txtTenCB.Text = dt.Rows[0][1].ToString();
            cmbChucVu.Text = dt.Rows[0][2].ToString();
            txtBoMon.Text = dt.Rows[0][3].ToString();
            txtSDT.Text = dt.Rows[0][4].ToString();

            txtMaCB.Enabled = false;
            txtBoMon.Enabled = false;

            cmbChucVu.DataSource=D_QLCanBo.ALLChucVu();
            cmbChucVu.DisplayMember = "TenCVu";
            cmbChucVu.ValueMember= "MaCVu";

        }

        private void btnSuaCB_Click(object sender, EventArgs e)
        {
            //string macb = "CB01";
            D_QLCanBo.SuaThongTinCB(DangNhap.MaBM, txtTenCB.Text, cmbChucVu.SelectedValue.ToString(), txtBoMon.Text, Int32.Parse(txtSDT.Text));
            MessageBox.Show("Sửa thông tin thành công");
            this.Close();
        }

    }
}