
namespace VKTB
{
    partial class QuanLyTB
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
            this.DsVuKhi = new DevExpress.XtraGrid.GridControl();
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupHVSDVK = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ghichu = new System.Windows.Forms.RichTextBox();
            this.txtTGKT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTGBD = new System.Windows.Forms.TextBox();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.txtMaTB = new System.Windows.Forms.TextBox();
            this.txtTenTB = new System.Windows.Forms.TextBox();
            this.Anh = new System.Windows.Forms.PictureBox();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLoaiTB = new System.Windows.Forms.TextBox();
            this.txtNCC = new System.Windows.Forms.TextBox();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.btnThanhLy = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.DsVuKhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupHVSDVK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Anh)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DsVuKhi
            // 
            this.DsVuKhi.Dock = System.Windows.Forms.DockStyle.Top;
            this.DsVuKhi.Location = new System.Drawing.Point(0, 0);
            this.DsVuKhi.MainView = this.gridView1;
            this.DsVuKhi.Name = "DsVuKhi";
            this.DsVuKhi.Size = new System.Drawing.Size(1848, 431);
            this.DsVuKhi.TabIndex = 1;
            this.DsVuKhi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.DsVuKhi.Click += new System.EventHandler(this.DsVuKhi_Click);
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
            this.gridView1.GridControl = this.DsVuKhi;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Trang Bị";
            this.gridColumn1.FieldName = "MaTB";
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
            this.gridColumn2.Caption = "Tên Trang bị";
            this.gridColumn2.FieldName = "TenTB";
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
            this.NgayNhap1.Caption = "Ngày Sản Xuất";
            this.NgayNhap1.FieldName = "NgaySanXuat";
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
            this.gridColumn5.Caption = "Nhà Cung Cấp";
            this.gridColumn5.FieldName = "TenNCC";
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
            this.ngay.Caption = "Phòng";
            this.ngay.FieldName = "TenPhong";
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
            this.gridColumn3.FieldName = "TenTT";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 5;
            this.gridColumn3.Width = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Thiết bị: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 554);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Thiết bị : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Tên tình trạng: ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Thời gian bắt đầu: ";
            // 
            // groupHVSDVK
            // 
            this.groupHVSDVK.Controls.Add(this.label3);
            this.groupHVSDVK.Controls.Add(this.txt_ghichu);
            this.groupHVSDVK.Controls.Add(this.txtTGKT);
            this.groupHVSDVK.Controls.Add(this.label10);
            this.groupHVSDVK.Controls.Add(this.txtTGBD);
            this.groupHVSDVK.Controls.Add(this.txtTT);
            this.groupHVSDVK.Controls.Add(this.label9);
            this.groupHVSDVK.Controls.Add(this.label8);
            this.groupHVSDVK.Location = new System.Drawing.Point(1171, 458);
            this.groupHVSDVK.Name = "groupHVSDVK";
            this.groupHVSDVK.Size = new System.Drawing.Size(639, 273);
            this.groupHVSDVK.TabIndex = 11;
            this.groupHVSDVK.TabStop = false;
            this.groupHVSDVK.Text = "Tình trạng thiết bị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ghi chú : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(382, 39);
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(241, 132);
            this.txt_ghichu.TabIndex = 16;
            this.txt_ghichu.Text = "";
            // 
            // txtTGKT
            // 
            this.txtTGKT.Location = new System.Drawing.Point(140, 148);
            this.txtTGKT.Name = "txtTGKT";
            this.txtTGKT.Size = new System.Drawing.Size(150, 23);
            this.txtTGKT.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Thời gian kết thúc: ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtTGBD
            // 
            this.txtTGBD.Location = new System.Drawing.Point(140, 96);
            this.txtTGBD.Name = "txtTGBD";
            this.txtTGBD.Size = new System.Drawing.Size(150, 23);
            this.txtTGBD.TabIndex = 13;
            // 
            // txtTT
            // 
            this.txtTT.Location = new System.Drawing.Point(140, 41);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(150, 23);
            this.txtTT.TabIndex = 12;
            this.txtTT.TextChanged += new System.EventHandler(this.TxtTenHocVien_TextChanged);
            // 
            // txtMaTB
            // 
            this.txtMaTB.Location = new System.Drawing.Point(579, 493);
            this.txtMaTB.Name = "txtMaTB";
            this.txtMaTB.Size = new System.Drawing.Size(166, 23);
            this.txtMaTB.TabIndex = 16;
            this.txtMaTB.TextChanged += new System.EventHandler(this.txtMaVK_TextChanged);
            // 
            // txtTenTB
            // 
            this.txtTenTB.Location = new System.Drawing.Point(579, 551);
            this.txtTenTB.Name = "txtTenTB";
            this.txtTenTB.Size = new System.Drawing.Size(166, 23);
            this.txtTenTB.TabIndex = 17;
            // 
            // Anh
            // 
            this.Anh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Anh.Location = new System.Drawing.Point(138, 437);
            this.Anh.Name = "Anh";
            this.Anh.Size = new System.Drawing.Size(269, 294);
            this.Anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Anh.TabIndex = 19;
            this.Anh.TabStop = false;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.AccessibleName = "";
            this.btnCapNhat.Enabled = false;
            this.btnCapNhat.Location = new System.Drawing.Point(472, 683);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(150, 48);
            this.btnCapNhat.TabIndex = 20;
            this.btnCapNhat.Text = "  Cập nhật tình trạng";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLoaiTB);
            this.groupBox2.Controls.Add(this.txtNCC);
            this.groupBox2.Controls.Add(this.txtPhong);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label);
            this.groupBox2.Location = new System.Drawing.Point(802, 458);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 196);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết thông tin";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtLoaiTB
            // 
            this.txtLoaiTB.Location = new System.Drawing.Point(140, 145);
            this.txtLoaiTB.Name = "txtLoaiTB";
            this.txtLoaiTB.Size = new System.Drawing.Size(150, 23);
            this.txtLoaiTB.TabIndex = 13;
            // 
            // txtNCC
            // 
            this.txtNCC.Location = new System.Drawing.Point(140, 93);
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(150, 23);
            this.txtNCC.TabIndex = 12;
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(140, 36);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(150, 23);
            this.txtPhong.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Phòng: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "Loại Thiết bị : ";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(28, 96);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(106, 17);
            this.label.TabIndex = 9;
            this.label.Text = "Nhà cung cấp : ";
            // 
            // btnThanhLy
            // 
            this.btnThanhLy.Enabled = false;
            this.btnThanhLy.Location = new System.Drawing.Point(905, 683);
            this.btnThanhLy.Name = "btnThanhLy";
            this.btnThanhLy.Size = new System.Drawing.Size(150, 48);
            this.btnThanhLy.TabIndex = 24;
            this.btnThanhLy.Text = "Thanh lý";
            this.btnThanhLy.Click += new System.EventHandler(this.btnThanhLy_Click);
            // 
            // QuanLyTB
            // 
            this.ActiveGlowColor = System.Drawing.Color.White;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1848, 766);
            this.Controls.Add(this.btnThanhLy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.Anh);
            this.Controls.Add(this.txtTenTB);
            this.Controls.Add(this.txtMaTB);
            this.Controls.Add(this.groupHVSDVK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DsVuKhi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "QuanLyTB";
            this.Text = "Tìm Kiếm Vũ Khí";
            this.Load += new System.EventHandler(this.QuanLyVKTB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsVuKhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupHVSDVK.ResumeLayout(false);
            this.groupHVSDVK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Anh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl DsVuKhi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn NgayNhap1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupHVSDVK;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.TextBox txtTGBD;
        private System.Windows.Forms.TextBox txtMaTB;
        private System.Windows.Forms.TextBox txtTenTB;
        private System.Windows.Forms.PictureBox Anh;
        private System.Windows.Forms.TextBox txtTGKT;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraGrid.Columns.GridColumn ngay;
        private DevExpress.XtraGrid.Columns.GridColumn NgayXuat;
        private DevExpress.XtraGrid.Columns.GridColumn MaCB;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtLoaiTB;
        private System.Windows.Forms.TextBox txtNCC;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label;
        private DevExpress.XtraEditors.SimpleButton btnThanhLy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txt_ghichu;
        private System.Windows.Forms.Label label10;
    }
}