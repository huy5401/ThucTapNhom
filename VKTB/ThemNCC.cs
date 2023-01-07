using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL;

namespace VKTB
{
    public partial class ThemNCC : DevExpress.XtraEditors.XtraForm
    {
        public ThemNCC()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            D_QuanLyTB.ThemNCC(txtMaNCC.Text, txtTen.Text);
            MessageBox.Show("Thêm nhà cung cấp thành công !");

        }

        private void NhapVuKhi_Load(object sender, EventArgs e)
        {
            txtMaNCC.Text = D_QuanLyTB.LayMaNCC();




        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}