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
    public partial class BanGiaoLichTruc : DevExpress.XtraEditors.XtraForm
    {
        public BanGiaoLichTruc()
        {
            InitializeComponent();
        }

        private void BanGiaoLichTruc_Load(object sender, EventArgs e)
        {
            

            DataTable dt1 = new DataTable();
            dt1 = D_QLLichTruc.ThongTinCaTruc(QLLichTruc.MaCt);
            txtMaCongTac.Text = dt1.Rows[0][0].ToString();
            txtNgayTruc.Text = dt1.Rows[0][1].ToString();
            txtPhong.Text = dt1.Rows[0][3].ToString();


            DataTable dt2 = new DataTable();
            dt2 = D_QLLichTruc.ThongTinCanBo(dt1.Rows[0][2].ToString());
            txtMaCBBanGiao.Text = dt2.Rows[0][0].ToString();
            TxtTenCBBanGiao.Text = dt2.Rows[0][1].ToString();
            txtChucVuBanGiao.Text = dt2.Rows[0][2].ToString();

            DataTable dt3 = new DataTable();
            dt3 = D_QLLichTruc.ThongTinCanBo(QLLichTruc.MaCbNhanBanGiao);
            txtMaCBNhan.Text = dt3.Rows[0][0].ToString();
            TxtTenCBNhan.Text = dt3.Rows[0][1].ToString();
            txtChucVuNhan.Text = dt3.Rows[0][2].ToString();



            groupCBBanGiao.Enabled = false;
            groupCBNhan.Enabled = false;
            txtMaCongTac.Enabled = false;
            txtNgayTruc.Enabled = false;
            txtPhong.Enabled = false;
        }

        private void btnBanGiao_Click(object sender, EventArgs e)
        {
            D_QLLichTruc.UpdateCaTruc(txtGhiChu.Text, txtMaCBNhan.Text, txtMaCongTac.Text);
            MessageBox.Show("bàn giao thành công");
            this.Close();
        }
    }
}