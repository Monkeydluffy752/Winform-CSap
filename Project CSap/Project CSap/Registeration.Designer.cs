namespace Project_CSap
{
    partial class Registeration
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
            this.tb_TenDangKy = new System.Windows.Forms.TextBox();
            this.tb_MatKhauDangKy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_NutDangKy = new System.Windows.Forms.Button();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Ký Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Đăng Ký";
            // 
            // tb_TenDangKy
            // 
            this.tb_TenDangKy.Location = new System.Drawing.Point(205, 77);
            this.tb_TenDangKy.Name = "tb_TenDangKy";
            this.tb_TenDangKy.Size = new System.Drawing.Size(372, 20);
            this.tb_TenDangKy.TabIndex = 2;
            this.tb_TenDangKy.Leave += new System.EventHandler(this.btn_NutDangKy_Leave);
            // 
            // tb_MatKhauDangKy
            // 
            this.tb_MatKhauDangKy.Location = new System.Drawing.Point(205, 138);
            this.tb_MatKhauDangKy.Name = "tb_MatKhauDangKy";
            this.tb_MatKhauDangKy.Size = new System.Drawing.Size(372, 20);
            this.tb_MatKhauDangKy.TabIndex = 3;
            this.tb_MatKhauDangKy.Leave += new System.EventHandler(this.btn_NutDangKy_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật Khẩu";
            // 
            // btn_NutDangKy
            // 
            this.btn_NutDangKy.Location = new System.Drawing.Point(485, 241);
            this.btn_NutDangKy.Name = "btn_NutDangKy";
            this.btn_NutDangKy.Size = new System.Drawing.Size(92, 53);
            this.btn_NutDangKy.TabIndex = 5;
            this.btn_NutDangKy.Text = "Đăng Ký";
            this.btn_NutDangKy.UseVisualStyleBackColor = true;
            this.btn_NutDangKy.Click += new System.EventHandler(this.btn_NutDangKy_Click);
            this.btn_NutDangKy.Leave += new System.EventHandler(this.btn_NutDangKy_Leave);
            // 
            // tb_Phone
            // 
            this.tb_Phone.Location = new System.Drawing.Point(205, 201);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(372, 20);
            this.tb_Phone.TabIndex = 6;
            this.tb_Phone.TextChanged += new System.EventHandler(this.tb_Phone_TextChanged);
            this.tb_Phone.Leave += new System.EventHandler(this.btn_NutDangKy_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số Điện Thoại";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Registeration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 352);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Phone);
            this.Controls.Add(this.btn_NutDangKy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_MatKhauDangKy);
            this.Controls.Add(this.tb_TenDangKy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registeration";
            this.Text = "Registeration";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_TenDangKy;
        private System.Windows.Forms.TextBox tb_MatKhauDangKy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_NutDangKy;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}