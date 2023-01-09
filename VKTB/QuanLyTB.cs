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
using System.Globalization;

namespace VKTB
{
    public partial class QuanLyTB : DevExpress.XtraEditors.XtraForm
    {
        public static string MaTB;
        public static string TenTB;
        public static string GhiChu;
        public static string TinhTrang;
        public static DataTable dt1 = new DataTable();
        public QuanLyTB()
        {
            InitializeComponent();
        }

        private void QuanLyVKTB_Load(object sender, EventArgs e)
        {
            LoadDsTB();
            //DataTable dt = new DataTable();
            //dt = D_QuanLyTB.LayQuyenHan(DangNhap.MaNhomQuyen);
            //foreach (DataRow hang in dt.Rows)
            //{
            //    if (hang["QuyenHan"].ToString() == "Xem Thêm")
            //    {
            //        btnChiTiet.Enabled = true;
            //    }
            //    else if (hang["QuyenHan"].ToString() == "Nhập Kho")
            //    {
            //        btnNhapKho.Enabled = true;
            //    }
            //    else if (hang["QuyenHan"].ToString() == "Xuất Kho")
            //    {
            //        btnXuatKho.Enabled = true;
            //    }

            //}
        }
        void LoadDsTB()
        {
            
            DsVuKhi.DataSource = D_QuanLyTB.DanhSachTB();

        }

            private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            DataRow hang = gridView1.GetFocusedDataRow();
            string MaTB = hang["MaTB"].ToString();
            string tgbd = hang["TGBatDau"].ToString();
            //DateTime TG = DateTime.ParseExact(tgbd, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime TG = DateTime.Parse(tgbd);
            dt1 = D_QuanLyTB.LayThongTinTB(MaTB, TG);
            txtMaTB.Text = dt1.Rows[0][0].ToString();
            txtTenTB.Text = dt1.Rows[0][1].ToString();
            txtPhong.Text = dt1.Rows[0][4].ToString();
            txtNCC.Text = dt1.Rows[0][3].ToString();
            txtTT.Text = dt1.Rows[0][5].ToString();
            txtTGBD.Text = dt1.Rows[0][8].ToString();
            txtTGKT.Text = dt1.Rows[0][9].ToString();
            txt_ghichu.Text = dt1.Rows[0][6].ToString();
            Console.WriteLine("haha",dt1.Rows[0][6].ToString());
            txtLoaiTB.Text = dt1.Rows[0][7].ToString();
            MemoryStream mrs = new MemoryStream((Byte[])dt1.Rows[0][10]);
            Anh.Image = Image.FromStream(mrs);
            btnCapNhat.Enabled = true;
            //btnNhap.Enabled = true;
            btnThanhLy.Enabled = true;
            btnLSTT.Enabled = true;
            //DataRow hang = gridView1.GetFocusedDataRow();
            //String MaVK = hang["MaVK"].ToString();         
            //string TinhTang = hang["TinhTrangMuon"].ToString();
            //String MaCBNhap = hang["CBNhap"].ToString();
            //String MaCBXuat = hang["CBXuat"].ToString();
            //if (TinhTang == "Đang Mượn")  // vũ khí đang mượn
            //{
            //   // groupHVSDVK.Visible = true;
            //    DataTable dt = new DataTable();
            //    dt = D_QuanLyVK.VuKhiDangMuon(MaVK);
            //    txtMaVK.Text = dt.Rows[0][0].ToString();
            //    txtTenVuKhi.Text = dt.Rows[0][1].ToString();           
            //    MemoryStream mrs = new MemoryStream((Byte[])dt.Rows[0][6]);
            //    Anh.Image = Image.FromStream(mrs);
            //    txtMaHV.Text = dt.Rows[0][7].ToString();
            //    TxtTenHocVien.Text = dt.Rows[0][8].ToString();
            //    txtDonVi.Text = dt.Rows[0][9].ToString(); 
            //    txtNgayMuon.Text = dt.Rows[0][10].ToString();


            //    DataTable dt1 = new DataTable();
            //    dt1 = D_QuanLyVK.LayThongTinCB(MaCBNhap);

            //    txtMaCBNhap.Text = dt1.Rows[0][0].ToString();
            //    txtTenCBNhap.Text= dt1.Rows[0][1].ToString();
            //    txtDonViCBNhap.Text = dt1.Rows[0][2].ToString();

            //    txtMaCBXuat.Text = "";
            //    txtTenCBXuat.Text = "";
            //    txtDonViCBXuat.Text = "";
            //}
            //else if(TinhTang == "Chưa Mượn")  // vũ khí chưa mượn 
            //{
            //   // groupHVSDVK.Visible = false;
            //    DataTable dt = new DataTable();
            //    dt = D_QuanLyVK.VuKhiChuaMuon(MaVK);
            //    txtMaVK.Text = dt.Rows[0][0].ToString();
            //    txtTenVuKhi.Text = dt.Rows[0][1].ToString();

            //    MemoryStream mrs = new MemoryStream((Byte[])dt.Rows[0][2]);
            //    Anh.Image = Image.FromStream(mrs);

            //    txtMaHV.Text = "";
            //    TxtTenHocVien.Text = "";
            //    txtDonVi.Text = "";
            //    txtNgayMuon.Text = "";

            //    DataTable dt1 = new DataTable();
            //    dt1 = D_QuanLyVK.LayThongTinCB(MaCBNhap);

            //    txtMaCBNhap.Text = dt1.Rows[0][0].ToString();
            //    txtTenCBNhap.Text = dt1.Rows[0][1].ToString();
            //    txtDonViCBNhap.Text = dt1.Rows[0][2].ToString();

            //    txtMaCBXuat.Text = "";
            //    txtTenCBXuat.Text = "";
            //    txtDonViCBXuat.Text = "";

            //}
            //else
            //{
            //    DataTable dt = new DataTable();
            //    dt = D_QuanLyVK.VuKhiChuaMuon(MaVK);
            //    txtMaVK.Text = dt.Rows[0][0].ToString();
            //    txtTenVuKhi.Text = dt.Rows[0][1].ToString();

            //    MemoryStream mrs = new MemoryStream((Byte[])dt.Rows[0][2]);
            //    Anh.Image = Image.FromStream(mrs);
            //    txtMaHV.Text = "";
            //    TxtTenHocVien.Text = "";
            //    txtDonVi.Text = "";
            //    txtNgayMuon.Text = "";
            //    DataTable dt1 = new DataTable();
            //    dt1 = D_QuanLyVK.LayThongTinCB(MaCBNhap);

            //    txtMaCBNhap.Text = dt1.Rows[0][0].ToString();
            //    txtTenCBNhap.Text = dt1.Rows[0][1].ToString();
            //    txtDonViCBNhap.Text = dt1.Rows[0][2].ToString();

            //    DataTable dt2 = new DataTable();
            //    dt2 = D_QuanLyVK.LayThongTinCB(MaCBXuat);

            //    txtMaCBXuat.Text = dt2.Rows[0][0].ToString();
            //    txtTenCBXuat.Text = dt2.Rows[0][1].ToString();
            //    txtDonViCBXuat.Text = dt2.Rows[0][2].ToString();

            //}

        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
           //MaVk  = txtMaVK.Text;
           // ChiTietVuKhi chitiet = new ChiTietVuKhi();
            
           // chitiet.ShowDialog();
           // LoadDsVuKhi();
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            ThayDoiTTTB nhapvukhi = new ThayDoiTTTB();
            nhapvukhi.ShowDialog();
            LoadDsTB();
        }

        private void btnXuatKho_Click(object sender, EventArgs e)
        {
            //XuatVuKhi xuatvk = new XuatVuKhi();
            //xuatvk.ShowDialog();
            //LoadDsVuKhi();
        }

        private void DsVuKhi_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TxtTenHocVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtMaVK_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            MaTB = txtMaTB.Text;
            TenTB = txtTenTB.Text;
            TinhTrang = txtTT.Text;
            GhiChu = txt_ghichu.Text;
            ThayDoiTTTB td1 = new ThayDoiTTTB();
            td1.ShowDialog();
            LoadDsTB();
        }

        private void btnThanhLy_Click(object sender, EventArgs e)
        {
            D_QuanLyTB.ThanhLyTB(txtMaTB.Text);
            MessageBox.Show("Thanh lý thành công");
            LoadDsTB();
        }

        private void btnLSTT_Click(object sender, EventArgs e)
        {
            btnReturn.Visible = true;
            btnReturn.Enabled = true;
            DsVuKhi.DataSource = D_QuanLyTB.LichSuTT(txtMaTB.Text);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            
            LoadDsTB();
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