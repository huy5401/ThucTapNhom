using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VKTB
{
    public partial class GiaoVien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public GiaoVien()
        {
            InitializeComponent();
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

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_QlLichTruc_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(QLLichTruc));
        }


        private void btn_QLSDung_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(XemLichSD));
        }
        private void bnt_TTCN_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(TongTinCN_GV));

        }
    }
}