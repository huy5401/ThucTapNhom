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
    
    public partial class QuanLyDanhMuc : DevExpress.XtraEditors.XtraForm
    {
        public static String MaLoaiTB;
        public QuanLyDanhMuc()
        {
            InitializeComponent();
        }

        private void QuanLyDanhMuc_Load(object sender, EventArgs e)
        {
            DanhMucVK.DataSource = D_QuanLyTB.LayDanhMucTB();
            DataTable dt = new DataTable();
            btnThemDanhMuc.Enabled = true;
        }
              

            private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            DataRow hang = gridView1.GetFocusedDataRow();
            MaLoaiTB = hang["MaLoai"].ToString();
            DataTable dt = new DataTable();
            dt = D_QuanLyTB.LayAnhTB(MaLoaiTB);
            MemoryStream mrs = new MemoryStream((Byte[])dt.Rows[0][0]);
            AnhDs.Image = Image.FromStream(mrs);
        }

        private void btnThemDanhMuc_Click(object sender, EventArgs e)
        {
            DataRow hang = gridView1.GetFocusedDataRow();
            MaLoaiTB = hang["MaLoai"].ToString();
            ThemDanhMuc themdanhmuc = new ThemDanhMuc();
            themdanhmuc.ShowDialog();
            DanhMucVK.DataSource = D_QuanLyTB.LayDanhMucTB();
        }

        private void DanhMucVK_Click(object sender, EventArgs e)
        {

        }
    }
}