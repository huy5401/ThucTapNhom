namespace VKTB
{
    partial class SuaThongTinCB
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
            this.label10 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenCB = new System.Windows.Forms.TextBox();
            this.txtMaCB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSuaCB = new DevExpress.XtraEditors.SimpleButton();
            this.cmbChucVu = new System.Windows.Forms.ComboBox();
            this.cmbBoMon = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(126, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Chức Vụ : ";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(218, 239);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(129, 21);
            this.txtSDT.TabIndex = 22;
            // 
            // txtTenCB
            // 
            this.txtTenCB.Location = new System.Drawing.Point(218, 108);
            this.txtTenCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenCB.Name = "txtTenCB";
            this.txtTenCB.Size = new System.Drawing.Size(129, 21);
            this.txtTenCB.TabIndex = 21;
            // 
            // txtMaCB
            // 
            this.txtMaCB.Location = new System.Drawing.Point(218, 59);
            this.txtMaCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaCB.Name = "txtMaCB";
            this.txtMaCB.Size = new System.Drawing.Size(129, 21);
            this.txtMaCB.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Số điện thoại : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mã Cán Bộ : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(126, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Bộ môn : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(126, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Họ Tên : ";
            // 
            // btnSuaCB
            // 
            this.btnSuaCB.Location = new System.Drawing.Point(187, 297);
            this.btnSuaCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaCB.Name = "btnSuaCB";
            this.btnSuaCB.Size = new System.Drawing.Size(128, 37);
            this.btnSuaCB.TabIndex = 26;
            this.btnSuaCB.Text = "Sửa";
            this.btnSuaCB.Click += new System.EventHandler(this.btnSuaCB_Click);
            // 
            // cmbChucVu
            // 
            this.cmbChucVu.FormattingEnabled = true;
            this.cmbChucVu.Location = new System.Drawing.Point(218, 148);
            this.cmbChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbChucVu.Name = "cmbChucVu";
            this.cmbChucVu.Size = new System.Drawing.Size(129, 21);
            this.cmbChucVu.TabIndex = 27;
            // 
            // cmbBoMon
            // 
            this.cmbBoMon.FormattingEnabled = true;
            this.cmbBoMon.Location = new System.Drawing.Point(218, 192);
            this.cmbBoMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBoMon.Name = "cmbBoMon";
            this.cmbBoMon.Size = new System.Drawing.Size(129, 21);
            this.cmbBoMon.TabIndex = 27;
            // 
            // SuaThongTinCB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 384);
            this.Controls.Add(this.cmbBoMon);
            this.Controls.Add(this.cmbChucVu);
            this.Controls.Add(this.btnSuaCB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtTenCB);
            this.Controls.Add(this.txtMaCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Name = "SuaThongTinCB";
            this.Text = "SuaThongTinCB";
            this.Load += new System.EventHandler(this.SuaThongTinCB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenCB;
        private System.Windows.Forms.TextBox txtMaCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SimpleButton btnSuaCB;
        private System.Windows.Forms.ComboBox cmbChucVu;
        private System.Windows.Forms.ComboBox cmbBoMon;
    }
}