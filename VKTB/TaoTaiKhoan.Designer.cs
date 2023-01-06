namespace VKTB
{
    partial class TaoTaiKhoan
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
            this.DsTaiKhoan = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThemTT = new DevExpress.XtraEditors.SimpleButton();
            this.groupThongTinTK = new System.Windows.Forms.GroupBox();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQuyen = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtMaCB = new System.Windows.Forms.TextBox();
            this.txtMaTK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DsTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupThongTinTK.SuspendLayout();
            this.SuspendLayout();
            // 
            // DsTaiKhoan
            // 
            this.DsTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.DsTaiKhoan.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DsTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.DsTaiKhoan.MainView = this.gridView1;
            this.DsTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DsTaiKhoan.Name = "DsTaiKhoan";
            this.DsTaiKhoan.Size = new System.Drawing.Size(1273, 435);
            this.DsTaiKhoan.TabIndex = 2;
            this.DsTaiKhoan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn5,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.DsTaiKhoan;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Tài Khoản";
            this.gridColumn1.FieldName = "MaTK";
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
            this.gridColumn2.Caption = "Mã Cán Bộ";
            this.gridColumn2.FieldName = "MaCB";
            this.gridColumn2.MinWidth = 21;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 81;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Quyền";
            this.gridColumn5.FieldName = "Quyen";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên tài khoản";
            this.gridColumn3.FieldName = "TenTK";
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
            this.gridColumn4.Caption = "Mật khẩu";
            this.gridColumn4.FieldName = "MatKhau";
            this.gridColumn4.MinWidth = 21;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 81;
            // 
            // btnThemTT
            // 
            this.btnThemTT.Location = new System.Drawing.Point(734, 549);
            this.btnThemTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemTT.Name = "btnThemTT";
            this.btnThemTT.Size = new System.Drawing.Size(148, 40);
            this.btnThemTT.TabIndex = 18;
            this.btnThemTT.Text = "Thêm";
            this.btnThemTT.Click += new System.EventHandler(this.btnThemTT_Click);
            // 
            // groupThongTinTK
            // 
            this.groupThongTinTK.Controls.Add(this.txtTenTK);
            this.groupThongTinTK.Controls.Add(this.label10);
            this.groupThongTinTK.Controls.Add(this.txtQuyen);
            this.groupThongTinTK.Controls.Add(this.txtMatKhau);
            this.groupThongTinTK.Controls.Add(this.txtMaCB);
            this.groupThongTinTK.Controls.Add(this.txtMaTK);
            this.groupThongTinTK.Controls.Add(this.label1);
            this.groupThongTinTK.Controls.Add(this.label7);
            this.groupThongTinTK.Controls.Add(this.label9);
            this.groupThongTinTK.Controls.Add(this.label8);
            this.groupThongTinTK.Location = new System.Drawing.Point(383, 447);
            this.groupThongTinTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupThongTinTK.Name = "groupThongTinTK";
            this.groupThongTinTK.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupThongTinTK.Size = new System.Drawing.Size(291, 254);
            this.groupThongTinTK.TabIndex = 17;
            this.groupThongTinTK.TabStop = false;
            this.groupThongTinTK.Text = "Thông tin Tài khoản";
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(120, 121);
            this.txtTenTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(129, 21);
            this.txtTenTK.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Tên Tài khoản: ";
            // 
            // txtQuyen
            // 
            this.txtQuyen.Location = new System.Drawing.Point(120, 209);
            this.txtQuyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuyen.Name = "txtQuyen";
            this.txtQuyen.Size = new System.Drawing.Size(129, 21);
            this.txtQuyen.TabIndex = 13;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(120, 165);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(129, 21);
            this.txtMatKhau.TabIndex = 13;
            // 
            // txtMaCB
            // 
            this.txtMaCB.Location = new System.Drawing.Point(120, 78);
            this.txtMaCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaCB.Name = "txtMaCB";
            this.txtMaCB.Size = new System.Drawing.Size(129, 21);
            this.txtMaCB.TabIndex = 12;
            // 
            // txtMaTK
            // 
            this.txtMaTK.Location = new System.Drawing.Point(120, 29);
            this.txtMaTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaTK.Name = "txtMaTK";
            this.txtMaTK.Size = new System.Drawing.Size(129, 21);
            this.txtMaTK.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Quyền: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mã Tài khoản: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Mật khẩu: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Mã Cán bộ: ";
            // 
            // TaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 712);
            this.Controls.Add(this.btnThemTT);
            this.Controls.Add(this.groupThongTinTK);
            this.Controls.Add(this.DsTaiKhoan);
            this.Name = "TaoTaiKhoan";
            this.Text = "TaoTaiKhoan";
            this.Load += new System.EventHandler(this.TaoTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupThongTinTK.ResumeLayout(false);
            this.groupThongTinTK.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl DsTaiKhoan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.SimpleButton btnThemTT;
        private System.Windows.Forms.GroupBox groupThongTinTK;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtQuyen;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtMaCB;
        private System.Windows.Forms.TextBox txtMaTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}