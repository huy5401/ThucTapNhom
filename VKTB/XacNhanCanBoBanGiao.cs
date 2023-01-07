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
    public partial class XacNhanCanBoBanGiao : DevExpress.XtraEditors.XtraForm
    {
        public XacNhanCanBoBanGiao()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            
            int xacnhan = D_QLLichTruc.XacNhan(QLLichTruc.MaCbNhanBanGiao, txtTenDangNhap.Text, txtMatKhau.Text);
           if(xacnhan == 1)
            {
                BanGiaoLichTruc bangiao = new BanGiaoLichTruc();
                bangiao.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản không chính xác");
            }
        
        }
    }
}