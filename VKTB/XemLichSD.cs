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
    public partial class XemLichSD : DevExpress.XtraEditors.XtraForm
    {
        public int dem = 0;
        public XemLichSD()
        {
            InitializeComponent();
            cmbThang.Items.Add(1);
            cmbThang.Items.Add(2);
            cmbThang.Items.Add(3);
            cmbThang.Items.Add(4);
            cmbThang.Items.Add(5);
            cmbThang.Items.Add(6);
            cmbThang.Items.Add(7);
            cmbThang.Items.Add(8);
            cmbThang.Items.Add(9);
            cmbThang.Items.Add(10);
            cmbThang.Items.Add(11);
            cmbThang.Items.Add(12);

            cmbNam.Items.Add(2019);
            cmbNam.Items.Add(2020);
            cmbNam.Items.Add(2021);
            cmbNam.Items.Add(2022);
            cmbNam.Items.Add(2023);

        }

        

        private void XemLichSD_Load(object sender, EventArgs e)
        {
         

        }

        private void cmbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string Thang = cmbThang.SelectedItem.ToString();
           
            if(dem != 0)
            {
                string Nam = cmbNam.SelectedItem.ToString();
                int ThangChon = Convert.ToInt32(Thang);
                int NamChon = Convert.ToInt32(Nam);
              LichSD.DataSource=  D_QLSuDung.LocLichSuDung(ThangChon, NamChon,DangNhap.MaCB);
            }
            

        }

        private void cmbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            dem++;
            string Thang = cmbThang.SelectedItem.ToString();
            string Nam = cmbNam.SelectedItem.ToString();
            int ThangChon = Convert.ToInt32(Thang);
            int NamChon = Convert.ToInt32(Nam);
            LichSD.DataSource = D_QLSuDung.LocLichSuDung(ThangChon, NamChon,DangNhap.MaCB);
        }
    }
}