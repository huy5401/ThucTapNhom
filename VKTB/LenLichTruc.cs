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
    public partial class LenLichTruc : DevExpress.XtraEditors.XtraForm
    {
        public LenLichTruc()
        {
            InitializeComponent();
        }
        string MaBm;
        string MaCBPhanCong;
        private void LenLichTruc_Load(object sender, EventArgs e)
        {
             MaCBPhanCong = "CB01";
            MaBm = "BM01";
            DataTable dt1 = new DataTable();
            dt1 = D_QLLichTruc.ThongTinCanBo(MaCBPhanCong);
            txtMaCBPhanCong.Text = dt1.Rows[0][0].ToString();
            TxtTenCBPhanCong.Text = dt1.Rows[0][1].ToString();
            txtChucVuPhanCong.Text = dt1.Rows[0][2].ToString();
            txtBoMonPhanCong.Text = dt1.Rows[0][4].ToString();
            MaBm = dt1.Rows[0][3].ToString();
            txtBoMonPhanCong.Enabled = false;
            LoadCanBoTruc();
            LoadPhongTruc();
            LoadDsLichTruc();

        }
        void LoadDsLichTruc()
        {
            DsLichTruc.DataSource = D_QLLichTruc.LichTruc(MaBm);
        }
        void LoadCanBoTruc()
        {
            cmbCanBoTruc.DataSource = D_QLLichTruc.CanBoHopLe(MaCBPhanCong, MaBm, dtpNgayThucHien.Value);
            cmbCanBoTruc.DisplayMember = "TenCB";
            cmbCanBoTruc.ValueMember = "MaCB";
        }
        void LoadPhongTruc()
        {
            cmbMaPhong.DataSource = D_QLLichTruc.MaPhongHopLe(MaBm, dtpNgayThucHien.Value);
            cmbMaPhong.DisplayMember = "MaPhong";
        }

        private void btnThemLichTruc_Click(object sender, EventArgs e)
        {
            if(dtpNgayThucHien.Value < DateTime.Today)
            {
                MessageBox.Show("Ngày thực hiện không hợp lệ");
            }
            else
            {
               
                string MaCaTruc = D_QLLichTruc.LayMaCaTruc();
                int maphong = Int32.Parse(cmbMaPhong.Text);
               
                D_QLLichTruc.ThemVaoBangCaTruc(MaCaTruc, dtpNgayThucHien.Value, cmbCanBoTruc.SelectedValue.ToString(), maphong);
                MessageBox.Show("Thêm Thành Công");
                LoadCanBoTruc();
                LoadPhongTruc();
                LoadDsLichTruc();

            }
        }

        private void dtpNgayThucHien_ValueChanged(object sender, EventArgs e)
        {
            LoadPhongTruc();
            LoadCanBoTruc();
        }
    }
}