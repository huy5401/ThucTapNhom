using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace VKTB
{
    public partial class QLSuDung : DevExpress.XtraEditors.XtraForm
    {
        public QLSuDung()
        {
            InitializeComponent();
            setCurrentDate();
            Load_Phong();
            
            
        }
        private void init()
        {
            btnHuy.Visible = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnXacNhan.Enabled = false;
            txt_MaSD.Enabled = false;
            txt_CBPT.Enabled = false;
            txt_NoiDung.Enabled = false;
            cb_CaSD.Enabled = false;
            cb_edit_Phong.Enabled = false;
            txt_MaSD.Text = "";
            txt_CBPT.Text = "";
            txt_NoiDung.Text = "";
            cb_CaSD.Text = "";
            cb_edit_Phong.Text = "";
        }

        private void QLSuDung_Load(object sender, EventArgs e)
        {
            //string current_date = NgaySD.Text;
            string current_date = "12-12-2022";
            string maPhong = cb_Phong.Text;
            LichSD.DataSource = D_QLSuDung.HienThiLichSD(current_date, maPhong);
            init();
        }
        
        private void setCurrentDate()
        {
            NgaySD.EditValue = DateTime.Now;
        }
        private void Load_Phong()
        {
            DataTable dt = new DataTable();
            dt = D_QLSuDung.LayDSPhong("BM01");
            foreach (DataRow row in dt.Rows)
            {
                cb_Phong.Properties.Items.Add(row["MaPhong"]);
            }
            cb_Phong.SelectedIndex = 0;
        }

        private void NgaySD_EditValueChanged(object sender, EventArgs e)
        {
            LichSD.DataSource = D_QLSuDung.HienThiLichSD(NgaySD.Text, cb_Phong.Text);
            init();
        }

        private void cb_Phong_SelectedIndexChanged(object sender, EventArgs e)
        {
            LichSD.DataSource = D_QLSuDung.HienThiLichSD(NgaySD.Text, cb_Phong.Text);
            init();
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            DataRow row = gridView1.GetFocusedDataRow();
            txt_MaSD.Text = row["MaSD"].ToString();
            txt_CBPT.Text = row["CBPTrach"].ToString();
            txt_NoiDung.Text = row["NoiDungSD"].ToString();
            cb_CaSD.Text = row["CaSD"].ToString();
            cb_CaSD.SelectedText = row["CaSD"].ToString();
            DataTable dt = new DataTable();
            dt = D_QLSuDung.LayDSPhong("BM01");
            foreach (DataRow row_phong in dt.Rows)
            {
                cb_edit_Phong.Properties.Items.Add(row_phong["MaPhong"]);
            }
            cb_edit_Phong.Text = row["MaPhong"].ToString();
            cb_edit_Phong.SelectedText = row["MaPhong"].ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txt_CBPT.Enabled = true;
            txt_NoiDung.Enabled = true;
            cb_CaSD.Enabled = true;
            cb_edit_Phong.Enabled = true;
            btnXacNhan.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            init();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txt_CBPT.Text);
            D_QLSuDung.SualichSD(txt_MaSD.Text, cb_CaSD.Text, cb_edit_Phong.Text, txt_NoiDung.Text,txt_CBPT.Text);
            MessageBox.Show("Sửa lịch sử dụng thành công");
            string current_date = "12-12-2022";
            string maPhong = cb_Phong.Text;
            LichSD.DataSource = D_QLSuDung.HienThiLichSD(current_date, maPhong);
            init();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                D_QLSuDung.XoaLichSD(txt_MaSD.Text);
                MessageBox.Show("Xóa lịch sử dụng thành công");
            }
        }
    }
}