﻿namespace Project_CSap
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_TenTaiKhoan = new System.Windows.Forms.TextBox();
            this.tb_MatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_NutDangNhap = new System.Windows.Forms.Button();
            this.btn_DiTrangDangKy = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dăng Nhập Ứng Dụng Quản Lý Nhà Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Tài Khoản";
            // 
            // tb_TenTaiKhoan
            // 
            this.tb_TenTaiKhoan.Location = new System.Drawing.Point(219, 88);
            this.tb_TenTaiKhoan.Name = "tb_TenTaiKhoan";
            this.tb_TenTaiKhoan.Size = new System.Drawing.Size(350, 20);
            this.tb_TenTaiKhoan.TabIndex = 2;
            this.tb_TenTaiKhoan.Leave += new System.EventHandler(this.tb_TenTaiKhoan_Leave);
            // 
            // tb_MatKhau
            // 
            this.tb_MatKhau.Location = new System.Drawing.Point(219, 161);
            this.tb_MatKhau.Name = "tb_MatKhau";
            this.tb_MatKhau.PasswordChar = '*';
            this.tb_MatKhau.Size = new System.Drawing.Size(350, 20);
            this.tb_MatKhau.TabIndex = 3;
            this.tb_MatKhau.Leave += new System.EventHandler(this.tb_TenTaiKhoan_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật Khẩu";
            // 
            // btn_NutDangNhap
            // 
            this.btn_NutDangNhap.Location = new System.Drawing.Point(470, 210);
            this.btn_NutDangNhap.Name = "btn_NutDangNhap";
            this.btn_NutDangNhap.Size = new System.Drawing.Size(99, 46);
            this.btn_NutDangNhap.TabIndex = 5;
            this.btn_NutDangNhap.Text = "Đăng Nhập";
            this.btn_NutDangNhap.UseVisualStyleBackColor = true;
            this.btn_NutDangNhap.Click += new System.EventHandler(this.btn_NutDangNhap_Click);
            // 
            // btn_DiTrangDangKy
            // 
            this.btn_DiTrangDangKy.Location = new System.Drawing.Point(245, 263);
            this.btn_DiTrangDangKy.Name = "btn_DiTrangDangKy";
            this.btn_DiTrangDangKy.Size = new System.Drawing.Size(324, 21);
            this.btn_DiTrangDangKy.TabIndex = 6;
            this.btn_DiTrangDangKy.Text = "Đi Đến Trang Đăng Ký";
            this.btn_DiTrangDangKy.UseVisualStyleBackColor = true;
            this.btn_DiTrangDangKy.Click += new System.EventHandler(this.btn_DiTrangDangKy_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 365);
            this.Controls.Add(this.btn_DiTrangDangKy);
            this.Controls.Add(this.btn_NutDangNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_MatKhau);
            this.Controls.Add(this.tb_TenTaiKhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_TenTaiKhoan;
        private System.Windows.Forms.TextBox tb_MatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_NutDangNhap;
        public System.Windows.Forms.Button btn_DiTrangDangKy;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}