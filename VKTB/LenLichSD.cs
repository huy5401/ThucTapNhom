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
    public partial class LenLichSD : DevExpress.XtraEditors.XtraForm
    {
        public LenLichSD()
        {
            InitializeComponent();
            setCurrentDate();
            Load_Phong();
            Load_CaSD();
            load_cbpt();
        }
        public void load_cbpt()
        {
            cb_CBPT.Properties.Items.Clear();
            DataTable dt = new DataTable();
            dt = D_QLSuDung.LayDSCbptChuaSD(NgaySD.Text,cb_CaSD.Text);
            foreach (DataRow row in dt.Rows)
            {
                cb_CBPT.Properties.Items.Add(row["MaCB"] + " - " + row["TenCB"]);
            }
            cb_CBPT.SelectedIndex = 0;
        }
        private void setCurrentDate()
        {
            NgaySD.EditValue = DateTime.Now;
        }
        private void Load_Phong()
        {
            cb_Phong.Properties.Items.Clear();
            DataTable dt = new DataTable();
            dt = D_QLSuDung.LayDSPhong("BM01");
            dt = D_QLSuDung.LayDSPhong("CB01");
           string MaCb =  DangNhap.MaCB;
          string MaBm=  DangNhap.MaBM;
           string quyen =  DangNhap.Quyen;
            foreach (DataRow row in dt.Rows)
            {
                cb_Phong.Properties.Items.Add(row["MaPhong"]);
            }
            cb_Phong.SelectedIndex = 0;
        }
        private void Load_CaSD()
        {
            cb_CaSD.Properties.Items.Clear();
            DataTable dt = new DataTable();
            dt = D_QLSuDung.LayDSCaChuaSD(NgaySD.Text, cb_Phong.Text);
            foreach (DataRow row in dt.Rows)
            {
                cb_CaSD.Properties.Items.Add(row["MaCa"]);
            }
            cb_CaSD.SelectedIndex = 0;
        }

        private void NgaySD_EditValueChanged(object sender, EventArgs e)
        {
            Load_Phong();
            Load_CaSD();
            load_cbpt();
        }

        private void cb_CaSD_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Phong();
            load_cbpt();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string macbpt = cb_CBPT.Text.Split('-')[0];
            D_QLSuDung.ThemLichSD(NgaySD.Text, cb_CaSD.Text,cb_Phong.Text , macbpt, txt_NoiDung.Text);
            MessageBox.Show("Thêm lịch sử dụng thành công");
            Load_Phong();
            load_cbpt();
            txt_NoiDung.Text = "";
        }
    }
}