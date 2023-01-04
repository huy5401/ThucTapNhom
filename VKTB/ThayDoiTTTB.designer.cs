
namespace VKTB
{
    partial class ThayDoiTTTB
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbLoaiTB = new System.Windows.Forms.ComboBox();
            this.btnQuayLai = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.dtpTGBD = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ghichu = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tình trạng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ngày bắt đầu";
            // 
            // cmbLoaiTB
            // 
            this.cmbLoaiTB.FormattingEnabled = true;
            this.cmbLoaiTB.Location = new System.Drawing.Point(501, 124);
            this.cmbLoaiTB.Name = "cmbLoaiTB";
            this.cmbLoaiTB.Size = new System.Drawing.Size(185, 24);
            this.cmbLoaiTB.TabIndex = 10;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(569, 422);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(149, 45);
            this.btnQuayLai.TabIndex = 17;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(322, 418);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(173, 49);
            this.btnCapNhat.TabIndex = 16;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCN_Click);
            // 
            // dtpTGBD
            // 
            this.dtpTGBD.CustomFormat = "dd/MM/yyyy";
            this.dtpTGBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTGBD.Location = new System.Drawing.Point(501, 189);
            this.dtpTGBD.Name = "dtpTGBD";
            this.dtpTGBD.Size = new System.Drawing.Size(199, 23);
            this.dtpTGBD.TabIndex = 18;
            this.dtpTGBD.ValueChanged += new System.EventHandler(this.dtpNgayNhapKho_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ghi chú : ";
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(501, 255);
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(241, 132);
            this.txt_ghichu.TabIndex = 19;
            this.txt_ghichu.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 40);
            this.label1.TabIndex = 21;
            this.label1.Text = "Cập nhật tình trạng thiết bị";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(500, 66);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(185, 23);
            this.txtTen.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên thiết bị";
            // 
            // ThayDoiTTTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 612);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ghichu);
            this.Controls.Add(this.dtpTGBD);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbLoaiTB);
            this.Name = "ThayDoiTTTB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhapVuKhi";
            this.Load += new System.EventHandler(this.ThayDoiTT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbLoaiTB;
        private DevExpress.XtraEditors.SimpleButton btnQuayLai;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private System.Windows.Forms.DateTimePicker dtpTGBD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txt_ghichu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label2;
    }
}