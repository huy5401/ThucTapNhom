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
    public partial class ThayDoiTTTB : DevExpress.XtraEditors.XtraForm
    {
        public ThayDoiTTTB()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {


            //string MaCBNhap = DangNhap.MaCB; 
            //if (D_QuanLyVK.KiemTraSuTonTaiTrongBangVK (txtMaVuKhi.Text) == true)  // mã vũ khí nhập vào đã tồn tại trong bảng vũ khí
            //{
            //    MessageBox.Show("Mã vũ khí đã tồn tại");
            //    D_QuanLyVK.CapNhatBangVuKhi(txtMaVuKhi.Text);
            //    D_QuanLyVK.ThemVaoBangVKCB(txtMaVuKhi.Text, MaCBNhap, dtpNgayNhapKho.Value);
            //    D_QuanLyVK.ThemVaoBangVuKhiTinhTrang(txtMaVuKhi.Text, dtpNgayNhapKho.Value);
            //    txtMaVuKhi.Text = "";
            //}
            //else
            //{
            //    MessageBox.Show("Mã vũ khí chưa tồn tại");
             
            //    D_QuanLyVK.ThemVaoBangVuKhi(txtMaVuKhi.Text, cmbLoaiVK.SelectedValue.ToString());
            //    D_QuanLyVK.ThemVaoBangVKCB(txtMaVuKhi.Text, MaCBNhap, dtpNgayNhapKho.Value);
            //    D_QuanLyVK.ThemVaoBangVuKhiTinhTrang(txtMaVuKhi.Text, dtpNgayNhapKho.Value);
            //    txtMaVuKhi.Text = "";
            //}
           
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

        private void dtpNgayNhapKho_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ThayDoiTT_Load(object sender, EventArgs e)
        {
            cmbLoaiTB.DataSource = D_QuanLyTB.LayLoaiTB();
            cmbLoaiTB.DisplayMember = "TenTT";
            cmbLoaiTB.ValueMember = "MaTT";
            txtTen.Text = QuanLyTB.TenTB;
        }

        private void btnCN_Click(object sender, EventArgs e)
        {
            D_QuanLyTB.CapNhatTTTB(QuanLyTB.MaTB, cmbLoaiTB.SelectedValue.ToString(), dtpTGBD.Value, txt_ghichu.Text);
            MessageBox.Show("Cập nhật thành công");
        }
    }
}