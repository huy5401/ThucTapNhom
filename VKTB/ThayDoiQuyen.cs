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
    public partial class ThayDoiQuyen : DevExpress.XtraEditors.XtraForm
    {
        public static string Quyen;
        public ThayDoiQuyen()
        {
            InitializeComponent();
        }

        private void ThayDoiQuyen_Load(object sender, EventArgs e)
        {


            cmbQuyen.DataSource = D_QuanLyTK.LayQuyen();
            cmbQuyen.DisplayMember = "Quyen";
            cmbQuyen.ValueMember = "Quyen";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            D_QuanLyTK.ThayDoiQuyen(QuanLyTK_CBBM.MaTK, cmbQuyen.SelectedValue.ToString());
            MessageBox.Show("Thay đổi quyền thành công");
            Quyen = cmbQuyen.SelectedValue.ToString();
            this.Close();


        }
    }
}