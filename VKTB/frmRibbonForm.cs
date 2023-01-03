﻿using System;
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


    }
}
