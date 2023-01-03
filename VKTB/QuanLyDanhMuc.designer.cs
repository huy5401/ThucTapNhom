
namespace VKTB
{
    partial class QuanLyDanhMuc
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
            this.DanhMucVK = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AnhDs = new System.Windows.Forms.PictureBox();
            this.btnThemDanhMuc = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.DanhMucVK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnhDs)).BeginInit();
            this.SuspendLayout();
            // 
            // DanhMucVK
            // 
            this.DanhMucVK.Location = new System.Drawing.Point(341, 66);
            this.DanhMucVK.MainView = this.gridView1;
            this.DanhMucVK.Name = "DanhMucVK";
            this.DanhMucVK.Size = new System.Drawing.Size(678, 458);
            this.DanhMucVK.TabIndex = 2;
            this.DanhMucVK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.DanhMucVK.Click += new System.EventHandler(this.DanhMucVK_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.DanhMucVK;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Danh mục thiết bị";
            this.gridColumn1.FieldName = "TenLoai";
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
            this.gridColumn2.Caption = "Mã Loại Vũ Khí";
            this.gridColumn2.FieldName = "MaLoai";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Width = 94;
            // 
            // AnhDs
            // 
            this.AnhDs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AnhDs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnhDs.Location = new System.Drawing.Point(1071, 127);
            this.AnhDs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AnhDs.Name = "AnhDs";
            this.AnhDs.Size = new System.Drawing.Size(366, 371);
            this.AnhDs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AnhDs.TabIndex = 41;
            this.AnhDs.TabStop = false;
            // 
            // btnThemDanhMuc
            // 
            this.btnThemDanhMuc.Enabled = false;
            this.btnThemDanhMuc.Location = new System.Drawing.Point(755, 605);
            this.btnThemDanhMuc.Name = "btnThemDanhMuc";
            this.btnThemDanhMuc.Size = new System.Drawing.Size(199, 56);
            this.btnThemDanhMuc.TabIndex = 42;
            this.btnThemDanhMuc.Text = "Thêm Danh Mục";
            this.btnThemDanhMuc.Click += new System.EventHandler(this.btnThemDanhMuc_Click);
            // 
            // QuanLyDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1773, 760);
            this.Controls.Add(this.btnThemDanhMuc);
            this.Controls.Add(this.AnhDs);
            this.Controls.Add(this.DanhMucVK);
            this.Name = "QuanLyDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyDanhMuc";
            this.Load += new System.EventHandler(this.QuanLyDanhMuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DanhMucVK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnhDs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl DanhMucVK;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.PictureBox AnhDs;
        private DevExpress.XtraEditors.SimpleButton btnThemDanhMuc;
    }
}