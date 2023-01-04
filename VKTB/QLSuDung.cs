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

        private void QLSuDung_Load(object sender, EventArgs e)
        {
            //string current_date = NgaySD.Text;
            string current_date = "12-12-2022";
            string maPhong = cb_Phong.Text;
            LichSD.DataSource = D_QLSuDung.HienThiLichSD(current_date, maPhong);
        }
        
        private void setCurrentDate()
        {
            NgaySD.EditValue = DateTime.Now;
        }
        private void Load_Phong()
        {
            DataTable dt = new DataTable();
            dt = D_QLSuDung.LayDSPhong("310");
            foreach (DataRow row in dt.Rows)
            {
                cb_Phong.Properties.Items.Add(row["MaPhong"]);
            }
            cb_Phong.SelectedIndex = 0;
        }

        private void NgaySD_EditValueChanged(object sender, EventArgs e)
        {
            LichSD.DataSource = D_QLSuDung.HienThiLichSD(NgaySD.Text, cb_Phong.Text);
        }

        private void cb_Phong_SelectedIndexChanged(object sender, EventArgs e)
        {
            LichSD.DataSource = D_QLSuDung.HienThiLichSD(NgaySD.Text, cb_Phong.Text);
        }

        
    }
}