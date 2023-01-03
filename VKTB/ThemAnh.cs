using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL;

namespace VKTB
{
    public partial class ThemAnh : DevExpress.XtraEditors.XtraForm
    {
        
        public ThemAnh()
        {
            InitializeComponent();
        }

    
        private byte[] Chuyen_Image_Byte(PictureBox anh)
        {
            MemoryStream mrs = new MemoryStream();
            anh.Image.Save(mrs, anh.Image.RawFormat);
            return mrs.ToArray();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = @"ThemAnhTB @Anh , @maLoai";
            Dataprovider.ExecuteNonQuery(sql, new object[] { Chuyen_Image_Byte(Anh),QuanLyDanhMuc.MaLoaiTB});
        }

      

        private void btnChon_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Vui Lòng Chọn ảnh";
            ofd.Filter = "Image Files(*.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png)|*.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Anh.ImageLocation = ofd.FileName;
            }
        }
    }
}