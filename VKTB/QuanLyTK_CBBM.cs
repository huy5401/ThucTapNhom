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
using System.IO;

namespace VKTB
{
    public partial class QuanLyTK_CBBM : DevExpress.XtraEditors.XtraForm
    {
       public static string MaTK;
        public static string maCB;
        public QuanLyTK_CBBM()
        {
            InitializeComponent();
        }

        
        void LoadDsTK()
        {
            DsTK.DataSource = D_QuanLyTK.DanhSachTK();

        }

            private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            DataRow hang = gridView1.GetFocusedDataRow();
            MaTK = hang["MaTK"].ToString();
            DataTable dt1 = new DataTable();
            dt1 = D_QuanLyTK.LayThongTinTK(MaTK);
            txtTaiKhoan.Text = dt1.Rows[0][1].ToString();
            txtMatKhau.Text = dt1.Rows[0][2].ToString();
            txtMaCB.Text = dt1.Rows[0][4].ToString();
            txtMaCB.Enabled = false;
            txtTenCB.Text = dt1.Rows[0][0].ToString();
            txtTenCB.Enabled = false;
            txtQuyen.Text = dt1.Rows[0][3].ToString();
            txtQuyen.Enabled = false;
            txtChucVu.Text = dt1.Rows[0][6].ToString();
            txtChucVu.Enabled = false;
            txtSDT.Text = dt1.Rows[0][5].ToString();
            txtSDT.Enabled = false;
            txtBoMon.Text = dt1.Rows[0][7].ToString();
            txtBoMon.Enabled = false;

            btnSuaTT.Enabled = true;
            btnXoa.Enabled = true;
        }

        //private void btnChiTiet_Click(object sender, EventArgs e)
        //{
        //   MaVk  = txtTaiKhoan.Text;
        //    ChiTietVuKhi chitiet = new ChiTietVuKhi();
            
        //    chitiet.ShowDialog();
        //    LoadDsVuKhi();
        //}

        //private void btnNhapKho_Click(object sender, EventArgs e)
        //{
        //    NhapVuKhi nhapvukhi = new NhapVuKhi();
        //    nhapvukhi.ShowDialog();
        //    LoadDsVuKhi();
        //}

        //private void btnXuatKho_Click(object sender, EventArgs e)
        //{
        //    XuatVuKhi xuatvk = new XuatVuKhi();
        //    xuatvk.ShowDialog();
        //    LoadDsVuKhi();
        //}

        private void txtDonViCBNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void DsTK_Load(object sender, EventArgs e)
        {

        }

        private void QuanLyTK_CBBM_Load(object sender, EventArgs e)
        {
            LoadDsTK();
        }

        private void btnSuaTT_Click(object sender, EventArgs e)
        {
            D_QuanLyTK.ThayTK(MaTK, txtTaiKhoan.Text, txtMatKhau.Text);
            MessageBox.Show("Thay đổi thông tin thành công");
            LoadDsTK();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ThayDoiQuyen td1 = new ThayDoiQuyen();
            td1.ShowDialog();
            txtQuyen.Text = ThayDoiQuyen.Quyen;
            LoadDsTK();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            maCB = txtMaCB.Text;
            SuaThongTinCB.fcheck = 1;
            SuaThongTinCB sd1 = new SuaThongTinCB();
            sd1.ShowDialog();
            LoadDsTK();
        }
        //void OpenForm(Type typeForm)
        //{
        //    foreach (Form frm in MdiChildren)
        //    {
        //        if (frm.GetType() == typeForm)
        //        {
        //            frm.Activate();
        //            return;
        //        }
        //    }
        //    Form f = (Form)Activator.CreateInstance(typeForm);
        //    f.MdiParent = frmRibbonForm.frmchinh;
        //    f.Show();



    }
}