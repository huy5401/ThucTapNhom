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
using System.Globalization;

namespace VKTB
{
    public partial class QLLichTruc : DevExpress.XtraEditors.XtraForm
    {
        public QLLichTruc()
        {
            InitializeComponent();
        }
      string MaBm;
      DateTime NgayTruc;
     public static string MaCt;
     public static string MaCbNhanBanGiao;
       

        private void QLLichTruc_Load(object sender, EventArgs e)
        {
            MaBm = "BM01";
            LoadDsLichTruc();
        }
        void LoadDsLichTruc()
        {
            DsLichTruc.DataSource = D_QLLichTruc.TatCaLichTruc(MaBm);
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
          
            
            DataRow hang = gridView1.GetFocusedDataRow();
            String MaCBPhanCong = "CB01";
            String MaCBTruc = hang["MaCB"].ToString();
            String MaCBNhanBanGiao = hang["MaCBNBG"].ToString();
            string TGTruc = hang["TGTruc"].ToString();
            MaCt = hang["MaCT"].ToString();
            dtpNgayTruc.Value = DateTime.ParseExact(TGTruc, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            NgayTruc = dtpNgayTruc.Value;
            string MaPhong = hang["MaPhong"].ToString();
            groupCBPhanCong.Enabled = false;
            groupCBBanGiao.Enabled = false;

            if (dtpNgayTruc.Value <= DateTime.Today)
            {
                dtpNgayTruc.Enabled = false;
                txtGhiChu.Visible = true;
            }
            else
            {
                dtpNgayTruc.Enabled = true;
                txtGhiChu.Visible = false;
           
            }
            
            
                if (MaCBNhanBanGiao != "")
                {
                    DataTable dt1 = new DataTable();
                    dt1 = D_QLLichTruc.ThongTinCanBo(MaCBNhanBanGiao);
                    txtMaCBBanGiao.Text = dt1.Rows[0][0].ToString();
                    TxtTenCBBanGiao.Text = dt1.Rows[0][1].ToString();
                    txtChucVuBanGiao.Text = dt1.Rows[0][2].ToString();
                }
                else
                {
                    txtMaCBBanGiao.Text = "";
                    TxtTenCBBanGiao.Text = "";
                    txtChucVuBanGiao.Text = "";
                }
            

            DataTable dt2 = new DataTable();
                dt2 = D_QLLichTruc.ThongTinCanBo(MaCBTruc);
                txtMaCBTruc.Text = dt2.Rows[0][0].ToString();
                txtChucVuTruc.Text = dt2.Rows[0][2].ToString();

            CmbHoTenCbTruc.DataSource = D_QLLichTruc.CanBoThuocBoMon(MaBm);
            CmbHoTenCbTruc.DisplayMember = "TenCB";
            CmbHoTenCbTruc.ValueMember = "MaCB";
       
            CmbHoTenCbTruc.Text = dt2.Rows[0][1].ToString();
                

            DataTable dt3 = new DataTable();
                dt3 = D_QLLichTruc.ThongTinCanBo(MaCBPhanCong);
                txtMaCBPhanCong.Text = dt3.Rows[0][0].ToString();
                TxtTenCBPhanCong.Text = dt3.Rows[0][1].ToString();
                txtChucVuPhanCong.Text = dt3.Rows[0][2].ToString();
                txtGhiChu.Text = hang["GhiChu"].ToString();
            cmbMaPhong.Text = MaPhong;

            if (dtpNgayTruc.Value == DateTime.Today && MaCBNhanBanGiao == "")
            {
                int phong = Int32.Parse(MaPhong);
                btnBanGiao.Enabled = true;
                MaCbNhanBanGiao = D_QLLichTruc.LayMaCbNhanBanGiao(phong, dtpNgayTruc.Value);
            }
            else
            {
                btnBanGiao.Enabled = false;
            }
        }

        private void btnSuaLichTruc_Click(object sender, EventArgs e)
        {
            if (NgayTruc < DateTime.Today)  //
            {
                int maphong = Int32.Parse(cmbMaPhong.Text);
                if (D_QLLichTruc.KiemTraSuaLichTruc(MaCt, maphong, txtMaCBTruc.Text, dtpNgayTruc.Value) == 0)
                {
                    D_QLLichTruc.KhongCapNhatNgay(txtMaCBTruc.Text, maphong, txtGhiChu.Text, MaCt);
                    MessageBox.Show("Cập nhật thành công");
                    LoadDsLichTruc();
                }
                else
                {
                    string ngay = dtpNgayTruc.Value.ToString("dd-MM-yyyy");
                    MessageBox.Show("Ngày " + ngay + " đã có cán bộ hoặc phòng trực rồi");
                }

            }
            else   //
            {
                if (dtpNgayTruc.Value < DateTime.Today)
                {
                    MessageBox.Show("Ngày Trực Không Hợp Lệ");
                }
                else
                {
                   
                    
                        int maphong = Int32.Parse(cmbMaPhong.Text);
                        if (D_QLLichTruc.KiemTraSuaLichTruc(MaCt, maphong, txtMaCBTruc.Text, dtpNgayTruc.Value) == 0)
                        {
                            D_QLLichTruc.CapNhatNgay(txtMaCBTruc.Text, maphong, dtpNgayTruc.Value, MaCt);
                            MessageBox.Show("Cập nhật thành công");
                            LoadDsLichTruc();
                        }
                        else
                        {
                            string ngay = dtpNgayTruc.Value.ToString("dd-MM-yyyy");
                            MessageBox.Show("Ngày " + ngay + " đã có cán bộ hoặc phòng trực rồi");
                        }
                    
                }
            }
        }
      

        private void cmbMaPhong_Click(object sender, EventArgs e)
        {
            cmbMaPhong.DataSource = D_QLLichTruc.MaPhongThuocBoMon(MaBm);
            cmbMaPhong.DisplayMember = "MaPhong";
          

        }
        private void CmbHoTenCbTruc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1 = D_QLLichTruc.ThongTinCanBo(CmbHoTenCbTruc.SelectedValue.ToString());
            txtMaCBTruc.Text = dt1.Rows[0][0].ToString();
            txtChucVuTruc.Text = dt1.Rows[0][2].ToString();
         
        }

        private void btnBanGiao_Click(object sender, EventArgs e)
        {
            XacNhanCanBoBanGiao xacnhan = new XacNhanCanBoBanGiao();
            xacnhan.ShowDialog();
            LoadDsLichTruc();

        }

     
    }
}