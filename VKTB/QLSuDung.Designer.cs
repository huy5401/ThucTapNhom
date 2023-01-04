
namespace VKTB
{
    partial class QLSuDung
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
            this.LichSD = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CBPT_col = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ND_col = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Phong_col = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CaSD_col = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaSD_col = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgaySD = new DevExpress.XtraEditors.DateEdit();
            this.cb_Phong = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_MaSD = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cb_CaSD = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cb_edit_Phong = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_CBPT = new System.Windows.Forms.TextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_NoiDung = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LichSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgaySD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgaySD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Phong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_CaSD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_edit_Phong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LichSD
            // 
            this.LichSD.Location = new System.Drawing.Point(44, 72);
            this.LichSD.MainView = this.gridView1;
            this.LichSD.Name = "LichSD";
            this.LichSD.Size = new System.Drawing.Size(932, 377);
            this.LichSD.TabIndex = 0;
            this.LichSD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CBPT_col,
            this.ND_col,
            this.Phong_col,
            this.CaSD_col,
            this.MaSD_col});
            this.gridView1.GridControl = this.LichSD;
            this.gridView1.Name = "gridView1";
            // 
            // CBPT_col
            // 
            this.CBPT_col.Caption = "Cán bộ PT";
            this.CBPT_col.FieldName = "CBPTrach";
            this.CBPT_col.MinWidth = 25;
            this.CBPT_col.Name = "CBPT_col";
            this.CBPT_col.OptionsColumn.AllowEdit = false;
            this.CBPT_col.Visible = true;
            this.CBPT_col.VisibleIndex = 4;
            this.CBPT_col.Width = 94;
            // 
            // ND_col
            // 
            this.ND_col.Caption = "Nội dung";
            this.ND_col.FieldName = "NoiDungSD";
            this.ND_col.MinWidth = 25;
            this.ND_col.Name = "ND_col";
            this.ND_col.OptionsColumn.AllowEdit = false;
            this.ND_col.Visible = true;
            this.ND_col.VisibleIndex = 3;
            this.ND_col.Width = 94;
            // 
            // Phong_col
            // 
            this.Phong_col.Caption = "Phòng";
            this.Phong_col.FieldName = "MaPhong";
            this.Phong_col.MinWidth = 25;
            this.Phong_col.Name = "Phong_col";
            this.Phong_col.OptionsColumn.AllowEdit = false;
            this.Phong_col.Visible = true;
            this.Phong_col.VisibleIndex = 2;
            this.Phong_col.Width = 94;
            // 
            // CaSD_col
            // 
            this.CaSD_col.Caption = "Ca sử dụng";
            this.CaSD_col.FieldName = "CaSD";
            this.CaSD_col.MinWidth = 25;
            this.CaSD_col.Name = "CaSD_col";
            this.CaSD_col.OptionsColumn.AllowEdit = false;
            this.CaSD_col.Visible = true;
            this.CaSD_col.VisibleIndex = 1;
            this.CaSD_col.Width = 94;
            // 
            // MaSD_col
            // 
            this.MaSD_col.Caption = "Mã sử dụng";
            this.MaSD_col.FieldName = "MaSD";
            this.MaSD_col.MinWidth = 25;
            this.MaSD_col.Name = "MaSD_col";
            this.MaSD_col.OptionsColumn.AllowEdit = false;
            this.MaSD_col.Visible = true;
            this.MaSD_col.VisibleIndex = 0;
            this.MaSD_col.Width = 94;
            // 
            // NgaySD
            // 
            this.NgaySD.EditValue = null;
            this.NgaySD.Location = new System.Drawing.Point(98, 29);
            this.NgaySD.Name = "NgaySD";
            this.NgaySD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NgaySD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NgaySD.Properties.DisplayFormat.FormatString = "MM-dd-yyyy";
            this.NgaySD.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgaySD.Properties.EditFormat.FormatString = "MM-dd-yyyy";
            this.NgaySD.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.NgaySD.Properties.MaskSettings.Set("mask", "MM - dd- yyyy");
            this.NgaySD.Properties.UseMaskAsDisplayFormat = true;
            this.NgaySD.Size = new System.Drawing.Size(125, 22);
            this.NgaySD.TabIndex = 1;
            this.NgaySD.EditValueChanged += new System.EventHandler(this.NgaySD_EditValueChanged);
            // 
            // cb_Phong
            // 
            this.cb_Phong.Location = new System.Drawing.Point(399, 27);
            this.cb_Phong.Name = "cb_Phong";
            this.cb_Phong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_Phong.Size = new System.Drawing.Size(125, 22);
            this.cb_Phong.TabIndex = 2;
            this.cb_Phong.SelectedIndexChanged += new System.EventHandler(this.cb_Phong_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(44, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 21);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Ngày";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(339, 28);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 21);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Phòng";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(1082, 72);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 21);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Mã SD";
            // 
            // txt_MaSD
            // 
            this.txt_MaSD.Location = new System.Drawing.Point(1149, 69);
            this.txt_MaSD.Name = "txt_MaSD";
            this.txt_MaSD.Size = new System.Drawing.Size(100, 23);
            this.txt_MaSD.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(1326, 68);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(83, 21);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Ca sử dụng";
            // 
            // cb_CaSD
            // 
            this.cb_CaSD.Location = new System.Drawing.Point(1440, 69);
            this.cb_CaSD.Name = "cb_CaSD";
            this.cb_CaSD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_CaSD.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cb_CaSD.Size = new System.Drawing.Size(125, 22);
            this.cb_CaSD.TabIndex = 8;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(1082, 136);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 21);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Phòng";
            // 
            // cb_edit_Phong
            // 
            this.cb_edit_Phong.Location = new System.Drawing.Point(1149, 137);
            this.cb_edit_Phong.Name = "cb_edit_Phong";
            this.cb_edit_Phong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_edit_Phong.Size = new System.Drawing.Size(100, 22);
            this.cb_edit_Phong.TabIndex = 10;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(1334, 138);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(75, 21);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Cán bộ PT";
            // 
            // txt_CBPT
            // 
            this.txt_CBPT.Location = new System.Drawing.Point(1440, 140);
            this.txt_CBPT.Name = "txt_CBPT";
            this.txt_CBPT.Size = new System.Drawing.Size(166, 23);
            this.txt_CBPT.TabIndex = 12;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(1082, 203);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(65, 21);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Nội dung";
            // 
            // txt_NoiDung
            // 
            this.txt_NoiDung.Location = new System.Drawing.Point(1083, 242);
            this.txt_NoiDung.Multiline = true;
            this.txt_NoiDung.Name = "txt_NoiDung";
            this.txt_NoiDung.Size = new System.Drawing.Size(523, 72);
            this.txt_NoiDung.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1083, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 41);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1525, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 42);
            this.button2.TabIndex = 16;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1378, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 41);
            this.button3.TabIndex = 17;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1234, 406);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 41);
            this.button4.TabIndex = 18;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // QLSuDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1708, 622);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_NoiDung);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txt_CBPT);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.cb_edit_Phong);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.cb_CaSD);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txt_MaSD);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cb_Phong);
            this.Controls.Add(this.NgaySD);
            this.Controls.Add(this.LichSD);
            this.Name = "QLSuDung";
            this.Text = "Xem lịch sử dụng";
            this.Load += new System.EventHandler(this.QLSuDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LichSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgaySD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgaySD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Phong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_CaSD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_edit_Phong.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl LichSD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn CBPT_col;
        private DevExpress.XtraGrid.Columns.GridColumn ND_col;
        private DevExpress.XtraGrid.Columns.GridColumn Phong_col;
        private DevExpress.XtraGrid.Columns.GridColumn CaSD_col;
        private DevExpress.XtraGrid.Columns.GridColumn MaSD_col;
        private DevExpress.XtraEditors.DateEdit NgaySD;
        private DevExpress.XtraEditors.ComboBoxEdit cb_Phong;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txt_MaSD;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cb_CaSD;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit cb_edit_Phong;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.TextBox txt_CBPT;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.TextBox txt_NoiDung;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}