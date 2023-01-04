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
            string macb = "CB01";
            DataTable dt=new DataTable();
            dt = D_QLCanBo.ThongTinCB(macb);
            txtMaCB.Text = dt.Rows[0][0].ToString();
            txtTenCB.Text = dt.Rows[0][1].ToString();
            cmbChucVu.Text = dt.Rows[0][2].ToString();
            cmbBoMon.Text = dt.Rows[0][3].ToString();
            txtSDT.Text = dt.Rows[0][4].ToString();

            txtMaCB.Enabled = false;

            cmbChucVu.DataSource=D_QLCanBo.ALLChucVu();
            cmbChucVu.DisplayMember = "TenCVu";
            cmbChucVu.ValueMember= "MaCVu";

            cmbBoMon.DataSource=D_QLCanBo.ALLBoMon();
            cmbBoMon.DisplayMember = "TenBM";
            cmbBoMon.ValueMember = "MaBM";
        }

        private void btnSuaCB_Click(object sender, EventArgs e)
        {
            string macb = "CB01";
            D_QLCanBo.SuaThongTinCB(macb, txtTenCB.Text, cmbChucVu.SelectedValue.ToString(), cmbBoMon.SelectedValue.ToString(), Int32.Parse(txtSDT.Text));
            MessageBox.Show("Sửa thông tin thành công");
            this.Close();
        }
    }
}