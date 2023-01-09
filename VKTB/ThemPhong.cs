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
    public partial class ThemPhong : DevExpress.XtraEditors.XtraForm
    {
        public ThemPhong()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //string MaCBNhap = DangNhap.MaCB; 
            //if (D_QuanLyVK.KiemTraSuTonTaiTrongBangVK (txtMaPhong.Text) == true)  // mã vũ khí nhập vào đã tồn tại trong bảng vũ khí
            //{
            //    MessageBox.Show("Mã vũ khí đã tồn tại");
            //    D_QuanLyVK.CapNhatBangVuKhi(txtMaPhong.Text);
            //    D_QuanLyVK.ThemVaoBangVKCB(txtMaPhong.Text, MaCBNhap, dtpNgayNhapKho.Value);
            //    D_QuanLyVK.ThemVaoBangVuKhiTinhTrang(txtMaPhong.Text, dtpNgayNhapKho.Value);
            //    txtMaPhong.Text = "";
            //}
            //else
            //{
            //    MessageBox.Show("Mã vũ khí chưa tồn tại");

            //    D_QuanLyVK.ThemVaoBangVuKhi(txtMaPhong.Text, cmbBoMon.SelectedValue.ToString());
            //    D_QuanLyVK.ThemVaoBangVKCB(txtMaPhong.Text, MaCBNhap, dtpNgayNhapKho.Value);
            //    D_QuanLyVK.ThemVaoBangVuKhiTinhTrang(txtMaPhong.Text, dtpNgayNhapKho.Value);
            //    txtMaPhong.Text = "";
            //}

            D_QuanLyTB.ThemPhong(txtMaPhong.Text, txtTen.Text, txtDiaDiem.Text, cmbBoMon.SelectedValue.ToString());
            MessageBox.Show("Thêm phòng thành công !");


        }

        private void NhapVuKhi_Load(object sender, EventArgs e)
        {
            //cmbBoMon.DataSource = D_QuanLyVK.LayLoaiVk(); 
            //cmbBoMon.DisplayMember = "TenLoai";
            //cmbBoMon.ValueMember = "MaLoai";
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ThemPhong_Load(object sender, EventArgs e)
        {
            txtMaPhong.Text = D_QuanLyTB.LayMaPhong();
            cmbBoMon.DataSource = D_QuanLyTB.LayBM();
            cmbBoMon.DisplayMember = "TenBM";
            cmbBoMon.ValueMember = "MaBM";
        }
    }
}