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
using DevExpress.Utils.Navigation;

namespace VKTB
{
    public partial class QLCanBo : DevExpress.XtraEditors.XtraForm
    {
        public QLCanBo()
        {
            InitializeComponent();
        }

     //public static String MaCB;

        private void QuanLyCanBo_Load(object sender, EventArgs e)

        {
            //string macb = "CB01";string mabm = "BM01";
            DsCanBo.DataSource = D_QLCanBo.TatCaCanBo(DangNhap.MaCB,DangNhap.MaBM);
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            DataRow hang = gridView1.GetFocusedDataRow();
            DangNhap.MaCB = hang["MaCB"].ToString();

            DataTable dt=new DataTable();
            dt = D_QLCanBo.ThongTinCB(DangNhap.MaCB);
            txtMaCB.Text = dt.Rows[0][0].ToString();
            txtTenCB.Text = dt.Rows[0][1].ToString();
            txtChucVu.Text= dt.Rows[0][2].ToString();
            txtBoMon.Text= dt.Rows[0][3].ToString();
            txtSDT.Text= dt.Rows[0][4].ToString();

            groupThongTinCB.Enabled= false;
        }

        void loadThongTinCB()
        {
            //string macb = "CB01"; string mabm = "BM01";
            DsCanBo.DataSource = D_QLCanBo.TatCaCanBo(DangNhap.MaCB,DangNhap.MaBM);
        }

        private void btnSuaCB_Click(object sender, EventArgs e)
        {
            SuaThongTinCB suatt=new SuaThongTinCB();
            suatt.ShowDialog();
            loadThongTinCB();
        }

        private void btnThemCB_Click(object sender, EventArgs e)
        {
            ThemCB themcb=new ThemCB();
            themcb.ShowDialog();
            loadThongTinCB();
        }
    }
}