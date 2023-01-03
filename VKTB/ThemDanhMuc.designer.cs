
namespace VKTB
{
    partial class ThemDanhMuc
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
            this.btnChon = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.Anh = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenDanhMuc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Anh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(97, 365);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(158, 64);
            this.btnChon.TabIndex = 6;
            this.btnChon.Text = "Chọn ảnh";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(448, 363);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(161, 66);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // Anh
            // 
            this.Anh.Location = new System.Drawing.Point(61, 21);
            this.Anh.Name = "Anh";
            this.Anh.Size = new System.Drawing.Size(269, 294);
            this.Anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Anh.TabIndex = 4;
            this.Anh.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Tên Danh Mục Vũ Khí";
            // 
            // txtTenDanhMuc
            // 
            this.txtTenDanhMuc.Location = new System.Drawing.Point(555, 58);
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.Size = new System.Drawing.Size(185, 23);
            this.txtTenDanhMuc.TabIndex = 24;
            // 
            // ThemDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 629);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenDanhMuc);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.Anh);
            this.Name = "ThemDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemDanhMuc";
            ((System.ComponentModel.ISupportInitialize)(this.Anh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.PictureBox Anh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenDanhMuc;
    }
}