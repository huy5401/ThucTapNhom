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
    public partial class QLLichTruc : DevExpress.XtraEditors.XtraForm
    {
        public QLLichTruc()
        {
            InitializeComponent();
        }

        private void QLLichTruc_Load(object sender, EventArgs e)
        {
            LoadDsLichTruc();
        }
        void LoadDsLichTruc()
        {
            DsLichTruc.DataSource = D_QLLichTruc.TatCaLichTruc();
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            
            DataRow hang = gridView1.GetFocusedDataRow();
            String MaCBPhanCong = "CB01";
            String MaCBTruc = hang["MaCB"].ToString();
            String MaCBNhanBanGiao = hang["MaCBNBG"].ToString();
            
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

            DataTable dt2= new DataTable();
            dt2 = D_QLLichTruc.ThongTinCanBo(MaCBTruc);
           txtMaCBTruc.Text = dt2.Rows[0][0].ToString();
            TxtTenCBTruc.Text = dt2.Rows[0][1].ToString();
            txtChucVuTruc.Text = dt2.Rows[0][2].ToString();

            DataTable dt3 = new DataTable();
            dt3 = D_QLLichTruc.ThongTinCanBo(MaCBPhanCong);
           txtMaCBPhanCong.Text = dt3.Rows[0][0].ToString();
           TxtTenCBPhanCong.Text = dt3.Rows[0][1].ToString();
          txtChucVuPhanCong.Text = dt3.Rows[0][2].ToString();
            txtGhiChu.Text = hang["GhiChu"].ToString();

            groupCBTruc.Enabled = false;
            groupCBPhanCong.Enabled = false;
            groupCBBanGiao.Enabled = false;
            txtGhiChu.Enabled = false;
        }
    }
}