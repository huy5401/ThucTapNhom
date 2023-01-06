using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DAL;

namespace VKTB
{
    public partial class frmRibbonForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public frmRibbonForm()
        {
            InitializeComponent();
        }

        private void frmRibbonForm_Load(object sender, EventArgs e)
        {


        }

        void OpenForm(Type typeForm)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeForm)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typeForm);
            f.MdiParent = this;
            f.Show();

        }

        private void btnTinhTrang_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(QuanLyTB));
        }

        private void BtnVatChat_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(QuanLyDanhMuc));
        }

        private void btnQuanLyCB_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(QLCanBo));
        }

        private void btnXemLichTruc_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(QLLichTruc));
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(LenLichTruc));
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnXemLichSD_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(QLSuDung));
        }


        private void btnViPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(NhapTB));
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(QuanLyTK_CBBM));

            
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(TaoTaiKhoan));

        }


    }
}
