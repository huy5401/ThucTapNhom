
namespace VKTB
{
    partial class QLLichTruc
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
            this.DsLichTruc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupCBTruc = new System.Windows.Forms.GroupBox();
            this.txtChucVuTruc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtTenCBTruc = new System.Windows.Forms.TextBox();
            this.txtMaCBTruc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupCBBanGiao = new System.Windows.Forms.GroupBox();
            this.txtChucVuBanGiao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTenCBBanGiao = new System.Windows.Forms.TextBox();
            this.txtMaCBBanGiao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupCBPhanCong = new System.Windows.Forms.GroupBox();
            this.txtChucVuPhanCong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTenCBPhanCong = new System.Windows.Forms.TextBox();
            this.txtMaCBPhanCong = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DsLichTruc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupCBTruc.SuspendLayout();
            this.groupCBBanGiao.SuspendLayout();
            this.groupCBPhanCong.SuspendLayout();
            this.SuspendLayout();
            // 
            // DsLichTruc
            // 
            this.DsLichTruc.Dock = System.Windows.Forms.DockStyle.Top;
            this.DsLichTruc.Location = new System.Drawing.Point(0, 0);
            this.DsLichTruc.MainView = this.gridView1;
            this.DsLichTruc.Name = "DsLichTruc";
            this.DsLichTruc.Size = new System.Drawing.Size(1813, 414);
            this.DsLichTruc.TabIndex = 4;
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
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gridView1.GridControl = this.DsLichTruc;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
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
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tình Trạng";
            this.gridColumn5.FieldName = "TrangThai";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowFocus = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 94;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Cán Bộ Nhận Bàn Giao";
            this.gridColumn6.FieldName = "MaCBNBG";
            this.gridColumn6.MinWidth = 25;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowFocus = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 94;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "gridColumn7";
            this.gridColumn7.FieldName = "GhiChu";
            this.gridColumn7.MinWidth = 25;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Width = 94;
            // 
            // groupCBTruc
            // 
            this.groupCBTruc.Controls.Add(this.txtChucVuTruc);
            this.groupCBTruc.Controls.Add(this.label10);
            this.groupCBTruc.Controls.Add(this.TxtTenCBTruc);
            this.groupCBTruc.Controls.Add(this.txtMaCBTruc);
            this.groupCBTruc.Controls.Add(this.label7);
            this.groupCBTruc.Controls.Add(this.label8);
            this.groupCBTruc.Location = new System.Drawing.Point(25, 485);
            this.groupCBTruc.Name = "groupCBTruc";
            this.groupCBTruc.Size = new System.Drawing.Size(339, 226);
            this.groupCBTruc.TabIndex = 13;
            this.groupCBTruc.TabStop = false;
            this.groupCBTruc.Text = "Cán Bộ Trực";
            // 
            // txtChucVuTruc
            // 
            this.txtChucVuTruc.Location = new System.Drawing.Point(140, 148);
            this.txtChucVuTruc.Name = "txtChucVuTruc";
            this.txtChucVuTruc.Size = new System.Drawing.Size(150, 23);
            this.txtChucVuTruc.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Chức Vụ : ";
            // 
            // TxtTenCBTruc
            // 
            this.TxtTenCBTruc.Location = new System.Drawing.Point(140, 96);
            this.TxtTenCBTruc.Name = "TxtTenCBTruc";
            this.TxtTenCBTruc.Size = new System.Drawing.Size(150, 23);
            this.TxtTenCBTruc.TabIndex = 12;
            // 
            // txtMaCBTruc
            // 
            this.txtMaCBTruc.Location = new System.Drawing.Point(140, 36);
            this.txtMaCBTruc.Name = "txtMaCBTruc";
            this.txtMaCBTruc.Size = new System.Drawing.Size(150, 23);
            this.txtMaCBTruc.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mã Cán Bộ : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Họ Tên : ";
            // 
            // groupCBBanGiao
            // 
            this.groupCBBanGiao.Controls.Add(this.txtChucVuBanGiao);
            this.groupCBBanGiao.Controls.Add(this.label1);
            this.groupCBBanGiao.Controls.Add(this.TxtTenCBBanGiao);
            this.groupCBBanGiao.Controls.Add(this.txtMaCBBanGiao);
            this.groupCBBanGiao.Controls.Add(this.label2);
            this.groupCBBanGiao.Controls.Add(this.label3);
            this.groupCBBanGiao.Location = new System.Drawing.Point(441, 485);
            this.groupCBBanGiao.Name = "groupCBBanGiao";
            this.groupCBBanGiao.Size = new System.Drawing.Size(339, 226);
            this.groupCBBanGiao.TabIndex = 16;
            this.groupCBBanGiao.TabStop = false;
            this.groupCBBanGiao.Text = "Cán Bộ Nhận Bàn Giao";
            // 
            // txtChucVuBanGiao
            // 
            this.txtChucVuBanGiao.Location = new System.Drawing.Point(140, 148);
            this.txtChucVuBanGiao.Name = "txtChucVuBanGiao";
            this.txtChucVuBanGiao.Size = new System.Drawing.Size(150, 23);
            this.txtChucVuBanGiao.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Chức Vụ : ";
            // 
            // TxtTenCBBanGiao
            // 
            this.TxtTenCBBanGiao.Location = new System.Drawing.Point(140, 96);
            this.TxtTenCBBanGiao.Name = "TxtTenCBBanGiao";
            this.TxtTenCBBanGiao.Size = new System.Drawing.Size(150, 23);
            this.TxtTenCBBanGiao.TabIndex = 12;
            // 
            // txtMaCBBanGiao
            // 
            this.txtMaCBBanGiao.Location = new System.Drawing.Point(140, 36);
            this.txtMaCBBanGiao.Name = "txtMaCBBanGiao";
            this.txtMaCBBanGiao.Size = new System.Drawing.Size(150, 23);
            this.txtMaCBBanGiao.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã Cán Bộ : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Họ Tên : ";
            // 
            // groupCBPhanCong
            // 
            this.groupCBPhanCong.Controls.Add(this.txtChucVuPhanCong);
            this.groupCBPhanCong.Controls.Add(this.label4);
            this.groupCBPhanCong.Controls.Add(this.TxtTenCBPhanCong);
            this.groupCBPhanCong.Controls.Add(this.txtMaCBPhanCong);
            this.groupCBPhanCong.Controls.Add(this.label12);
            this.groupCBPhanCong.Controls.Add(this.label6);
            this.groupCBPhanCong.Location = new System.Drawing.Point(1417, 473);
            this.groupCBPhanCong.Name = "groupCBPhanCong";
            this.groupCBPhanCong.Size = new System.Drawing.Size(339, 226);
            this.groupCBPhanCong.TabIndex = 17;
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
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(1015, 682);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(254, 23);
            this.txtGhiChu.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(904, 682);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ghi Chú : ";
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Phòng Trực";
            this.gridColumn8.FieldName = "MaPhong";
            this.gridColumn8.MinWidth = 25;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 6;
            this.gridColumn8.Width = 94;
            // 
            // QLLichTruc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1813, 772);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.groupCBPhanCong);
            this.Controls.Add(this.groupCBBanGiao);
            this.Controls.Add(this.groupCBTruc);
            this.Controls.Add(this.DsLichTruc);
            this.Name = "QLLichTruc";
            this.Text = "QLLichTruc";
            this.Load += new System.EventHandler(this.QLLichTruc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsLichTruc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupCBTruc.ResumeLayout(false);
            this.groupCBTruc.PerformLayout();
            this.groupCBBanGiao.ResumeLayout(false);
            this.groupCBBanGiao.PerformLayout();
            this.groupCBPhanCong.ResumeLayout(false);
            this.groupCBPhanCong.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl DsLichTruc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private System.Windows.Forms.GroupBox groupCBTruc;
        private System.Windows.Forms.TextBox txtChucVuTruc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtTenCBTruc;
        private System.Windows.Forms.TextBox txtMaCBTruc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupCBBanGiao;
        private System.Windows.Forms.TextBox txtChucVuBanGiao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTenCBBanGiao;
        private System.Windows.Forms.TextBox txtMaCBBanGiao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupCBPhanCong;
        private System.Windows.Forms.TextBox txtChucVuPhanCong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtTenCBPhanCong;
        private System.Windows.Forms.TextBox txtMaCBPhanCong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}