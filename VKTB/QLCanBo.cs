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
    public partial class QLCanBo : DevExpress.XtraEditors.XtraForm
    {
        public QLCanBo()
        {
            InitializeComponent();
        }

     public static   String MaCB;

        private void QuanLyCanBo_Load(object sender, EventArgs e)
        {
            DsCanBo.DataSource = D_QLCanBo.TatCaCanBo("CB01");
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            DataRow hang = gridView1.GetFocusedDataRow();
            MaCB = hang["MaCB"].ToString();

        }


    }
}