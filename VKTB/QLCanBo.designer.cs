
namespace VKTB
{
    partial class QLCanBo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DsCanBo = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupThongTinCB = new System.Windows.Forms.GroupBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtBoMon = new System.Windows.Forms.TextBox();
            this.txtTenCB = new System.Windows.Forms.TextBox();
            this.txtMaCB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSuaCB = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemCB = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.DsCanBo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupThongTinCB.SuspendLayout();
            this.SuspendLayout();
            // 
            // DsCanBo
            // 
            this.DsCanBo.Dock = System.Windows.Forms.DockStyle.Top;
            this.DsCanBo.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DsCanBo.Location = new System.Drawing.Point(0, 0);
            this.DsCanBo.MainView = this.gridView1;
            this.DsCanBo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DsCanBo.Name = "DsCanBo";
            this.DsCanBo.Size = new System.Drawing.Size(1156, 435);
            this.DsCanBo.TabIndex = 1;
            this.DsCanBo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn6});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.DsCanBo;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Cán Bộ";
            this.gridColumn1.FieldName = "MaCB";
            this.gridColumn1.MinWidth = 21;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 81;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên Cán Bộ";
            this.gridColumn2.FieldName = "TenCB";
            this.gridColumn2.MinWidth = 21;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 81;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Chức Vụ";
            this.gridColumn3.FieldName = "TenCVu";
            this.gridColumn3.MinWidth = 21;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 81;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Số điện thoại";
            this.gridColumn4.FieldName = "SĐT";
            this.gridColumn4.MinWidth = 21;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 81;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Bộ Môn";
            this.gridColumn6.FieldName = "TenBM";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Quyền";
            this.gridColumn5.FieldName = "TenNhomQuyen";
            this.gridColumn5.MinWidth = 21;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowFocus = false;
            this.gridColumn5.Width = 81;
            // 
            // groupThongTinCB
            // 
            this.groupThongTinCB.Controls.Add(this.txtChucVu);
            this.groupThongTinCB.Controls.Add(this.label10);
            this.groupThongTinCB.Controls.Add(this.txtSDT);
            this.groupThongTinCB.Controls.Add(this.txtBoMon);
            this.groupThongTinCB.Controls.Add(this.txtTenCB);
            this.groupThongTinCB.Controls.Add(this.txtMaCB);
            this.groupThongTinCB.Controls.Add(this.label1);
            this.groupThongTinCB.Controls.Add(this.label7);
            this.groupThongTinCB.Controls.Add(this.label9);
            this.groupThongTinCB.Controls.Add(this.label8);
            this.groupThongTinCB.Location = new System.Drawing.Point(156, 449);
            this.groupThongTinCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupThongTinCB.Name = "groupThongTinCB";
            this.groupThongTinCB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupThongTinCB.Size = new System.Drawing.Size(291, 254);
            this.groupThongTinCB.TabIndex = 13;
            this.groupThongTinCB.TabStop = false;
            this.groupThongTinCB.Text = "Thông tin Cán bộ";
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(120, 121);
            this.txtChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(129, 21);
            this.txtChucVu.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Chức Vụ : ";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(120, 209);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(129, 21);
            this.txtSDT.TabIndex = 13;
            // 
            // txtBoMon
            // 
            this.txtBoMon.Location = new System.Drawing.Point(120, 165);
            this.txtBoMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoMon.Name = "txtBoMon";
            this.txtBoMon.Size = new System.Drawing.Size(129, 21);
            this.txtBoMon.TabIndex = 13;
            // 
            // txtTenCB
            // 
            this.txtTenCB.Location = new System.Drawing.Point(120, 78);
            this.txtTenCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenCB.Name = "txtTenCB";
            this.txtTenCB.Size = new System.Drawing.Size(129, 21);
            this.txtTenCB.TabIndex = 12;
            // 
            // txtMaCB
            // 
            this.txtMaCB.Location = new System.Drawing.Point(120, 29);
            this.txtMaCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaCB.Name = "txtMaCB";
            this.txtMaCB.Size = new System.Drawing.Size(129, 21);
            this.txtMaCB.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Số điện thoại : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mã Cán Bộ : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Bộ môn : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Họ Tên : ";
            // 
            // btnSuaCB
            // 
            this.btnSuaCB.Location = new System.Drawing.Point(707, 535);
            this.btnSuaCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaCB.Name = "btnSuaCB";
            this.btnSuaCB.Size = new System.Drawing.Size(128, 37);
            this.btnSuaCB.TabIndex = 17;
            this.btnSuaCB.Text = "Sửa";
            this.btnSuaCB.Click += new System.EventHandler(this.btnSuaCB_Click);
            // 
            // btnThemCB
            // 
            this.btnThemCB.Location = new System.Drawing.Point(511, 532);
            this.btnThemCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemCB.Name = "btnThemCB";
            this.btnThemCB.Size = new System.Drawing.Size(148, 40);
            this.btnThemCB.TabIndex = 16;
            this.btnThemCB.Text = "Thêm";
            this.btnThemCB.Click += new System.EventHandler(this.btnThemCB_Click);
            // 
            // QLCanBo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 723);
            this.Controls.Add(this.btnSuaCB);
            this.Controls.Add(this.btnThemCB);
            this.Controls.Add(this.groupThongTinCB);
            this.Controls.Add(this.DsCanBo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QLCanBo";
            this.Text = "QuanLyCanBo";
            this.Load += new System.EventHandler(this.QuanLyCanBo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsCanBo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupThongTinCB.ResumeLayout(false);
            this.groupThongTinCB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl DsCanBo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private System.Windows.Forms.GroupBox groupThongTinCB;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtBoMon;
        private System.Windows.Forms.TextBox txtTenCB;
        private System.Windows.Forms.TextBox txtMaCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SimpleButton btnSuaCB;
        private DevExpress.XtraEditors.SimpleButton btnThemCB;
    }
}