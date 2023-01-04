
namespace VKTB
{
    partial class LenLichTruc
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayThucHien = new System.Windows.Forms.DateTimePicker();
            this.groupCBPhanCong = new System.Windows.Forms.GroupBox();
            this.txtChucVuPhanCong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTenCBPhanCong = new System.Windows.Forms.TextBox();
            this.txtMaCBPhanCong = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoMonPhanCong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCanBoTruc = new System.Windows.Forms.ComboBox();
            this.cmbMaPhong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThemLichTruc = new DevExpress.XtraEditors.SimpleButton();
            this.DsLichTruc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupCBPhanCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DsLichTruc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thời Gian Thực Hiện";
            // 
            // dtpNgayThucHien
            // 
            this.dtpNgayThucHien.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayThucHien.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayThucHien.Location = new System.Drawing.Point(653, 19);
            this.dtpNgayThucHien.Name = "dtpNgayThucHien";
            this.dtpNgayThucHien.Size = new System.Drawing.Size(132, 23);
            this.dtpNgayThucHien.TabIndex = 4;
            this.dtpNgayThucHien.ValueChanged += new System.EventHandler(this.dtpNgayThucHien_ValueChanged);
            // 
            // groupCBPhanCong
            // 
            this.groupCBPhanCong.Controls.Add(this.txtChucVuPhanCong);
            this.groupCBPhanCong.Controls.Add(this.label4);
            this.groupCBPhanCong.Controls.Add(this.TxtTenCBPhanCong);
            this.groupCBPhanCong.Controls.Add(this.txtMaCBPhanCong);
            this.groupCBPhanCong.Controls.Add(this.label12);
            this.groupCBPhanCong.Controls.Add(this.label6);
            this.groupCBPhanCong.Location = new System.Drawing.Point(36, 12);
            this.groupCBPhanCong.Name = "groupCBPhanCong";
            this.groupCBPhanCong.Size = new System.Drawing.Size(339, 217);
            this.groupCBPhanCong.TabIndex = 18;
            this.groupCBPhanCong.TabStop = false;
            this.groupCBPhanCong.Text = "Cán Bộ Phân Công";
            // 
            // txtChucVuPhanCong
            // 
            this.txtChucVuPhanCong.Location = new System.Drawing.Point(140, 148);
            this.txtChucVuPhanCong.Name = "txtChucVuPhanCong";
            this.txtChucVuPhanCong.Size = new System.Drawing.Size(150, 23);
            this.txtChucVuPhanCong.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Chức Vụ : ";
            // 
            // TxtTenCBPhanCong
            // 
            this.TxtTenCBPhanCong.Location = new System.Drawing.Point(140, 96);
            this.TxtTenCBPhanCong.Name = "TxtTenCBPhanCong";
            this.TxtTenCBPhanCong.Size = new System.Drawing.Size(150, 23);
            this.TxtTenCBPhanCong.TabIndex = 12;
            // 
            // txtMaCBPhanCong
            // 
            this.txtMaCBPhanCong.Location = new System.Drawing.Point(140, 36);
            this.txtMaCBPhanCong.Name = "txtMaCBPhanCong";
            this.txtMaCBPhanCong.Size = new System.Drawing.Size(150, 23);
            this.txtMaCBPhanCong.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Mã Cán Bộ : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Họ Tên : ";
            // 
            // txtBoMonPhanCong
            // 
            this.txtBoMonPhanCong.Location = new System.Drawing.Point(1054, 12);
            this.txtBoMonPhanCong.Name = "txtBoMonPhanCong";
            this.txtBoMonPhanCong.Size = new System.Drawing.Size(180, 23);
            this.txtBoMonPhanCong.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(977, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Bộ Môn : ";
            // 
            // cmbCanBoTruc
            // 
            this.cmbCanBoTruc.FormattingEnabled = true;
            this.cmbCanBoTruc.Location = new System.Drawing.Point(619, 92);
            this.cmbCanBoTruc.Name = "cmbCanBoTruc";
            this.cmbCanBoTruc.Size = new System.Drawing.Size(180, 24);
            this.cmbCanBoTruc.TabIndex = 19;
            // 
            // cmbMaPhong
            // 
            this.cmbMaPhong.FormattingEnabled = true;
            this.cmbMaPhong.Location = new System.Drawing.Point(1054, 91);
            this.cmbMaPhong.Name = "cmbMaPhong";
            this.cmbMaPhong.Size = new System.Drawing.Size(180, 24);
            this.cmbMaPhong.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = " Cán Bộ Trực";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(941, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Phòng Trực ";
            // 
            // btnThemLichTruc
            // 
            this.btnThemLichTruc.Location = new System.Drawing.Point(831, 151);
            this.btnThemLichTruc.Name = "btnThemLichTruc";
            this.btnThemLichTruc.Size = new System.Drawing.Size(112, 63);
            this.btnThemLichTruc.TabIndex = 23;
            this.btnThemLichTruc.Text = "Thêm Lịch Trực";
            this.btnThemLichTruc.Click += new System.EventHandler(this.btnThemLichTruc_Click);
            // 
            // DsLichTruc
            // 
            this.DsLichTruc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DsLichTruc.Location = new System.Drawing.Point(0, 302);
            this.DsLichTruc.MainView = this.gridView1;
            this.DsLichTruc.Name = "DsLichTruc";
            this.DsLichTruc.Size = new System.Drawing.Size(1748, 483);
            this.DsLichTruc.TabIndex = 24;
            this.DsLichTruc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn6,
            this.gridColumn5});
            this.gridView1.GridControl = this.DsLichTruc;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Công Tác";
            this.gridColumn1.FieldName = "MaCT";
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
            this.gridColumn2.Caption = "Cán Bộ Trực";
            this.gridColumn2.FieldName = "MaCB";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Bộ Môn";
            this.gridColumn3.FieldName = "TenBM";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Thời Gian Trực";
            this.gridColumn4.FieldName = "TGTruc";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 94;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Phòng Trực";
            this.gridColumn6.FieldName = "MaPhong";
            this.gridColumn6.MinWidth = 25;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 94;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tình Trạng";
            this.gridColumn5.FieldName = "TrangThai";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowFocus = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 94;
            // 
            // LenLichTruc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1748, 785);
            this.Controls.Add(this.DsLichTruc);
            this.Controls.Add(this.btnThemLichTruc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoMonPhanCong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMaPhong);
            this.Controls.Add(this.cmbCanBoTruc);
            this.Controls.Add(this.groupCBPhanCong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpNgayThucHien);
            this.Name = "LenLichTruc";
            this.Text = "LenLichTruc";
            this.Load += new System.EventHandler(this.LenLichTruc_Load);
            this.groupCBPhanCong.ResumeLayout(false);
            this.groupCBPhanCong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DsLichTruc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayThucHien;
        private System.Windows.Forms.GroupBox groupCBPhanCong;
        private System.Windows.Forms.TextBox txtBoMonPhanCong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChucVuPhanCong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtTenCBPhanCong;
        private System.Windows.Forms.TextBox txtMaCBPhanCong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCanBoTruc;
        private System.Windows.Forms.ComboBox cmbMaPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btnThemLichTruc;
        private DevExpress.XtraGrid.GridControl DsLichTruc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}