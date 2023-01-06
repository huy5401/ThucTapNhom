
namespace VKTB
{
    partial class QuanLyTK_CBBM
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
            this.DsTK = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayNhap1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaCB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtQuyen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoMon = new System.Windows.Forms.TextBox();
            this.txtTenCB = new System.Windows.Forms.TextBox();
            this.txtMaCB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.btnXuatKho = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.DsTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DsTK
            // 
            this.DsTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.DsTK.Location = new System.Drawing.Point(0, 0);
            this.DsTK.MainView = this.gridView1;
            this.DsTK.Name = "DsTK";
            this.DsTK.Size = new System.Drawing.Size(1848, 431);
            this.DsTK.TabIndex = 1;
            this.DsTK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.DsTK.Load += new System.EventHandler(this.DsTK_Load);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.NgayNhap1,
            this.gridColumn5,
            this.ngay,
            this.NgayXuat,
            this.MaCB,
            this.gridColumn3});
            this.gridView1.GridControl = this.DsTK;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã tài khoản";
            this.gridColumn1.FieldName = "MaTK";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên cán bộ ";
            this.gridColumn2.FieldName = "TenCB";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 94;
            // 
            // NgayNhap1
            // 
            this.NgayNhap1.Caption = "Tài khoản";
            this.NgayNhap1.FieldName = "TenTK";
            this.NgayNhap1.MinWidth = 25;
            this.NgayNhap1.Name = "NgayNhap1";
            this.NgayNhap1.OptionsColumn.AllowEdit = false;
            this.NgayNhap1.OptionsColumn.AllowFocus = false;
            this.NgayNhap1.Visible = true;
            this.NgayNhap1.VisibleIndex = 2;
            this.NgayNhap1.Width = 94;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Mật khẩu";
            this.gridColumn5.FieldName = "MatKhau";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowFocus = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 94;
            // 
            // ngay
            // 
            this.ngay.Caption = "Quyền";
            this.ngay.FieldName = "Quyen";
            this.ngay.MinWidth = 25;
            this.ngay.Name = "ngay";
            this.ngay.OptionsColumn.AllowEdit = false;
            this.ngay.OptionsColumn.AllowFocus = false;
            this.ngay.Visible = true;
            this.ngay.VisibleIndex = 4;
            this.ngay.Width = 94;
            // 
            // NgayXuat
            // 
            this.NgayXuat.Caption = "Cán Bộ Xuất";
            this.NgayXuat.FieldName = "CBXuat";
            this.NgayXuat.MinWidth = 25;
            this.NgayXuat.Name = "NgayXuat";
            this.NgayXuat.OptionsColumn.AllowEdit = false;
            this.NgayXuat.OptionsColumn.AllowFocus = false;
            this.NgayXuat.Width = 94;
            // 
            // MaCB
            // 
            this.MaCB.Caption = "Tình Trạng Mượn";
            this.MaCB.FieldName = "TinhTrangMuon";
            this.MaCB.MinWidth = 25;
            this.MaCB.Name = "MaCB";
            this.MaCB.OptionsColumn.AllowEdit = false;
            this.MaCB.OptionsColumn.AllowFocus = false;
            this.MaCB.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tình Trạng Sử Dụng";
            this.gridColumn3.FieldName = "TinhTrangSuDung";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.Width = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tài khoản : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 556);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(409, 477);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(166, 23);
            this.txtTaiKhoan.TabIndex = 16;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(409, 550);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(166, 23);
            this.txtMatKhau.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtQuyen);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSDT);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtChucVu);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtBoMon);
            this.groupBox2.Controls.Add(this.txtTenCB);
            this.groupBox2.Controls.Add(this.txtMaCB);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label);
            this.groupBox2.Location = new System.Drawing.Point(840, 460);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(686, 201);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin cán bộ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtQuyen
            // 
            this.txtQuyen.Location = new System.Drawing.Point(472, 145);
            this.txtQuyen.Name = "txtQuyen";
            this.txtQuyen.Size = new System.Drawing.Size(150, 23);
            this.txtQuyen.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Quyền : ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(140, 148);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(150, 23);
            this.txtSDT.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "SĐT : ";
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(472, 39);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(150, 23);
            this.txtChucVu.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Chức vụ : ";
            // 
            // txtBoMon
            // 
            this.txtBoMon.Location = new System.Drawing.Point(472, 93);
            this.txtBoMon.Name = "txtBoMon";
            this.txtBoMon.Size = new System.Drawing.Size(150, 23);
            this.txtBoMon.TabIndex = 13;
            this.txtBoMon.TextChanged += new System.EventHandler(this.txtDonViCBNhap_TextChanged);
            // 
            // txtTenCB
            // 
            this.txtTenCB.Location = new System.Drawing.Point(140, 96);
            this.txtTenCB.Name = "txtTenCB";
            this.txtTenCB.Size = new System.Drawing.Size(150, 23);
            this.txtTenCB.TabIndex = 12;
            // 
            // txtMaCB
            // 
            this.txtMaCB.Location = new System.Drawing.Point(140, 36);
            this.txtMaCB.Name = "txtMaCB";
            this.txtMaCB.Size = new System.Drawing.Size(150, 23);
            this.txtMaCB.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Mã Cán Bộ: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(370, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "Bộ môn : ";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(33, 96);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(92, 17);
            this.label.TabIndex = 9;
            this.label.Text = "Tên Cán Bộ : ";
            // 
            // btnXuatKho
            // 
            this.btnXuatKho.Enabled = false;
            this.btnXuatKho.Location = new System.Drawing.Point(714, 682);
            this.btnXuatKho.Name = "btnXuatKho";
            this.btnXuatKho.Size = new System.Drawing.Size(150, 48);
            this.btnXuatKho.TabIndex = 24;
            this.btnXuatKho.Text = "Xuất Kho";
            // 
            // QuanLyTK_CBBM
            // 
            this.ActiveGlowColor = System.Drawing.Color.White;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1848, 766);
            this.Controls.Add(this.btnXuatKho);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DsTK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "QuanLyTK_CBBM";
            this.Text = "Tìm Kiếm Vũ Khí";
            this.Load += new System.EventHandler(this.QuanLyTK_CBBM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl DsTK;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn NgayNhap1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private DevExpress.XtraGrid.Columns.GridColumn ngay;
        private DevExpress.XtraGrid.Columns.GridColumn NgayXuat;
        private DevExpress.XtraGrid.Columns.GridColumn MaCB;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBoMon;
        private System.Windows.Forms.TextBox txtTenCB;
        private System.Windows.Forms.TextBox txtMaCB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label;
        private DevExpress.XtraEditors.SimpleButton btnXuatKho;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuyen;
        private System.Windows.Forms.Label label5;
    }
}