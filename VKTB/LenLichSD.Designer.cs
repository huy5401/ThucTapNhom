
namespace VKTB
{
    partial class LenLichSD
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cb_Phong = new DevExpress.XtraEditors.ComboBoxEdit();
            this.NgaySD = new DevExpress.XtraEditors.DateEdit();
            this.cb_CaSD = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cb_CBPT = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_NoiDung = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Phong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgaySD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgaySD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_CaSD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_CBPT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(556, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 21);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Phòng";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(95, 54);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 21);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Ngày";
            // 
            // cb_Phong
            // 
            this.cb_Phong.Location = new System.Drawing.Point(716, 51);
            this.cb_Phong.Name = "cb_Phong";
            this.cb_Phong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_Phong.Size = new System.Drawing.Size(159, 22);
            this.cb_Phong.TabIndex = 6;
            // 
            // NgaySD
            // 
            this.NgaySD.EditValue = null;
            this.NgaySD.Location = new System.Drawing.Point(209, 53);
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
            this.NgaySD.TabIndex = 5;
            this.NgaySD.EditValueChanged += new System.EventHandler(this.NgaySD_EditValueChanged);
            // 
            // cb_CaSD
            // 
            this.cb_CaSD.Location = new System.Drawing.Point(209, 131);
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
            this.cb_CaSD.TabIndex = 10;
            this.cb_CaSD.SelectedIndexChanged += new System.EventHandler(this.cb_CaSD_SelectedIndexChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(95, 130);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(83, 21);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Ca sử dụng";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(556, 130);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(126, 21);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Cán bộ phụ trách";
            // 
            // cb_CBPT
            // 
            this.cb_CBPT.Location = new System.Drawing.Point(716, 131);
            this.cb_CBPT.Name = "cb_CBPT";
            this.cb_CBPT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_CBPT.Size = new System.Drawing.Size(159, 22);
            this.cb_CBPT.TabIndex = 12;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(95, 216);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(63, 21);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "nội dung";
            // 
            // txt_NoiDung
            // 
            this.txt_NoiDung.Location = new System.Drawing.Point(95, 267);
            this.txt_NoiDung.Multiline = true;
            this.txt_NoiDung.Name = "txt_NoiDung";
            this.txt_NoiDung.Size = new System.Drawing.Size(780, 92);
            this.txt_NoiDung.TabIndex = 15;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(750, 426);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(125, 41);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // LenLichSD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 704);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txt_NoiDung);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.cb_CBPT);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cb_CaSD);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cb_Phong);
            this.Controls.Add(this.NgaySD);
            this.Name = "LenLichSD";
            this.Text = "Lên lịch sử dụng";
            ((System.ComponentModel.ISupportInitialize)(this.cb_Phong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgaySD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgaySD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_CaSD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_CBPT.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cb_Phong;
        private DevExpress.XtraEditors.DateEdit NgaySD;
        private DevExpress.XtraEditors.ComboBoxEdit cb_CaSD;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cb_CBPT;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox txt_NoiDung;
        private System.Windows.Forms.Button btnThem;
    }
}