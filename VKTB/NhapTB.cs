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
    public partial class NhapTB : DevExpress.XtraEditors.XtraForm
    {
        public NhapTB()
        {
            InitializeComponent();
        }

        public bool Check()
        {
            bool ck = true;
            if(txtSoLuong.Text == "" || txtTenTB.Text == "")
            {
                ck = false;
            }
            return ck;
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(Check())
            {
                int soLuong = Convert.ToInt32(txtSoLuong.Text);
                for (int i = 0; i < soLuong; i++)
                {
                    string maTB = D_QuanLyTB.LayMaTB();
                    D_QuanLyTB.ThemTB(maTB, txtTenTB.Text, cmbLoaiTB.SelectedValue.ToString(), cbxPhong.SelectedValue.ToString(), cbxNCC.SelectedValue.ToString(), dtpNgayNhapKho.Value);
                }
                MessageBox.Show("Thêm thiết bị thành công!");
                D_QuanLyTB.CapNhatSL();
            }
            else
            {
                MessageBox.Show("Thiếu thông tin!");
            }
            

        }

        private void NhapVuKhi_Load(object sender, EventArgs e)
        {
            //cmbLoaiVK.DataSource = D_QuanLyVK.LayLoaiVk(); 
            //cmbLoaiVK.DisplayMember = "TenLoai";
            //cmbLoaiVK.ValueMember = "MaLoai";
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbLoaiVK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgayNhapKho_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtMaVuKhi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)// thêm Nhà cung cấp
        {
            ThemNCC tnc1 = new ThemNCC();
            tnc1.ShowDialog();
            cbxNCC.DataSource = D_QuanLyTB.LayNCC();
            cbxNCC.DisplayMember = "TenNCC";
            cbxNCC.ValueMember = "MaNCC";
        }

        private void pictureBox2_Click(object sender, EventArgs e)// Thêm Phòng
        {
            ThemPhong tp1 = new ThemPhong();
            tp1.ShowDialog();
            cbxPhong.DataSource = D_QuanLyTB.LayPhong();
            cbxPhong.DisplayMember = "TenPhong";
            cbxPhong.ValueMember = "MaPhong";
        }

        private void NhapTB_Load(object sender, EventArgs e)
        {
            cmbLoaiTB.DataSource = D_QuanLyTB.LayDanhMucTB();
            cmbLoaiTB.DisplayMember = "TenLoai";
            cmbLoaiTB.ValueMember = "MaLoai";

            cbxPhong.DataSource = D_QuanLyTB.LayPhong();
            cbxPhong.DisplayMember = "TenPhong";
            cbxPhong.ValueMember = "MaPhong";

            cbxNCC.DataSource = D_QuanLyTB.LayNCC();
            cbxNCC.DisplayMember = "TenNCC";
            cbxNCC.ValueMember = "MaNCC";
        }
    }
}