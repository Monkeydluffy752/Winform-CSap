namespace Project_CSap
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mt_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Login = new System.Windows.Forms.Panel();
            this.panel_Bangnoidung2 = new System.Windows.Forms.Panel();
            this.textBox_productGiaSP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_productMota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_productTen = new System.Windows.Forms.TextBox();
            this.pic_product = new System.Windows.Forms.PictureBox();
            this.panel_bangnoidung1 = new System.Windows.Forms.Panel();
            this.dgv_Bangtimkiem = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Timkiem = new System.Windows.Forms.Button();
            this.textBox_TimKiem = new System.Windows.Forms.TextBox();
            this.panel_chuanoidung = new System.Windows.Forms.Panel();
            this.dgv_bangnoidung = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btn_Hienbangtimkiem = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btn_Capnhat = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Inhoadon = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.panel_green = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label_ProductLoai = new System.Windows.Forms.Label();
            this.label_ = new System.Windows.Forms.Label();
            this.comboBox_ProductLoai = new System.Windows.Forms.ComboBox();
            this.comboBox_ProductHang = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.panel_Login.SuspendLayout();
            this.panel_Bangnoidung2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_product)).BeginInit();
            this.panel_bangnoidung1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bangtimkiem)).BeginInit();
            this.panel_chuanoidung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bangnoidung)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mt_DangXuat});
            this.settingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingToolStripMenuItem.Image")));
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // mt_DangXuat
            // 
            this.mt_DangXuat.Image = ((System.Drawing.Image)(resources.GetObject("mt_DangXuat.Image")));
            this.mt_DangXuat.Name = "mt_DangXuat";
            this.mt_DangXuat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D4)));
            this.mt_DangXuat.Size = new System.Drawing.Size(165, 22);
            this.mt_DangXuat.Text = "Đăng Xuất";
            this.mt_DangXuat.Click += new System.EventHandler(this.mt_DangXuat_Click);
            // 
            // panel_Login
            // 
            this.panel_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panel_Login.Controls.Add(this.panel_Bangnoidung2);
            this.panel_Login.Controls.Add(this.panel_bangnoidung1);
            this.panel_Login.Controls.Add(this.panel_chuanoidung);
            this.panel_Login.Controls.Add(this.panel1);
            this.panel_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Login.Location = new System.Drawing.Point(0, 49);
            this.panel_Login.Name = "panel_Login";
            this.panel_Login.Size = new System.Drawing.Size(1924, 1012);
            this.panel_Login.TabIndex = 4;
            // 
            // panel_Bangnoidung2
            // 
            this.panel_Bangnoidung2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.panel_Bangnoidung2.Controls.Add(this.comboBox_ProductHang);
            this.panel_Bangnoidung2.Controls.Add(this.comboBox_ProductLoai);
            this.panel_Bangnoidung2.Controls.Add(this.label_);
            this.panel_Bangnoidung2.Controls.Add(this.label_ProductLoai);
            this.panel_Bangnoidung2.Controls.Add(this.textBox_productGiaSP);
            this.panel_Bangnoidung2.Controls.Add(this.label4);
            this.panel_Bangnoidung2.Controls.Add(this.textBox_productMota);
            this.panel_Bangnoidung2.Controls.Add(this.label3);
            this.panel_Bangnoidung2.Controls.Add(this.label2);
            this.panel_Bangnoidung2.Controls.Add(this.textBox_productTen);
            this.panel_Bangnoidung2.Controls.Add(this.pic_product);
            this.panel_Bangnoidung2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Bangnoidung2.Location = new System.Drawing.Point(200, 571);
            this.panel_Bangnoidung2.Name = "panel_Bangnoidung2";
            this.panel_Bangnoidung2.Size = new System.Drawing.Size(1724, 441);
            this.panel_Bangnoidung2.TabIndex = 2;
            this.panel_Bangnoidung2.Visible = false;
            // 
            // textBox_productGiaSP
            // 
            this.textBox_productGiaSP.Location = new System.Drawing.Point(393, 345);
            this.textBox_productGiaSP.Name = "textBox_productGiaSP";
            this.textBox_productGiaSP.Size = new System.Drawing.Size(422, 21);
            this.textBox_productGiaSP.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(266, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giá Sản Phẩm";
            // 
            // textBox_productMota
            // 
            this.textBox_productMota.Location = new System.Drawing.Point(393, 79);
            this.textBox_productMota.Multiline = true;
            this.textBox_productMota.Name = "textBox_productMota";
            this.textBox_productMota.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_productMota.Size = new System.Drawing.Size(422, 223);
            this.textBox_productMota.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(266, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mô Tả Chi Tiết";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(262, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Sản Phẩm";
            // 
            // textBox_productTen
            // 
            this.textBox_productTen.Location = new System.Drawing.Point(393, 12);
            this.textBox_productTen.Multiline = true;
            this.textBox_productTen.Name = "textBox_productTen";
            this.textBox_productTen.Size = new System.Drawing.Size(422, 20);
            this.textBox_productTen.TabIndex = 1;
            // 
            // pic_product
            // 
            this.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_product.Location = new System.Drawing.Point(0, 0);
            this.pic_product.Name = "pic_product";
            this.pic_product.Size = new System.Drawing.Size(260, 265);
            this.pic_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_product.TabIndex = 0;
            this.pic_product.TabStop = false;
            // 
            // panel_bangnoidung1
            // 
            this.panel_bangnoidung1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.panel_bangnoidung1.Controls.Add(this.dgv_Bangtimkiem);
            this.panel_bangnoidung1.Controls.Add(this.label1);
            this.panel_bangnoidung1.Controls.Add(this.btn_Timkiem);
            this.panel_bangnoidung1.Controls.Add(this.textBox_TimKiem);
            this.panel_bangnoidung1.Location = new System.Drawing.Point(1161, 12);
            this.panel_bangnoidung1.Name = "panel_bangnoidung1";
            this.panel_bangnoidung1.Size = new System.Drawing.Size(937, 506);
            this.panel_bangnoidung1.TabIndex = 1;
            this.panel_bangnoidung1.Visible = false;
            // 
            // dgv_Bangtimkiem
            // 
            this.dgv_Bangtimkiem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.dgv_Bangtimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Bangtimkiem.Location = new System.Drawing.Point(3, 54);
            this.dgv_Bangtimkiem.Name = "dgv_Bangtimkiem";
            this.dgv_Bangtimkiem.Size = new System.Drawing.Size(760, 449);
            this.dgv_Bangtimkiem.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(112, 16);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(106, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm Kiếm";
            // 
            // btn_Timkiem
            // 
            this.btn_Timkiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Timkiem.BackgroundImage")));
            this.btn_Timkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Timkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Timkiem.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_Timkiem.Location = new System.Drawing.Point(472, 15);
            this.btn_Timkiem.Name = "btn_Timkiem";
            this.btn_Timkiem.Size = new System.Drawing.Size(54, 33);
            this.btn_Timkiem.TabIndex = 1;
            this.btn_Timkiem.UseVisualStyleBackColor = true;
            // 
            // textBox_TimKiem
            // 
            this.textBox_TimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_TimKiem.Location = new System.Drawing.Point(224, 15);
            this.textBox_TimKiem.Multiline = true;
            this.textBox_TimKiem.Name = "textBox_TimKiem";
            this.textBox_TimKiem.Size = new System.Drawing.Size(248, 33);
            this.textBox_TimKiem.TabIndex = 0;
            // 
            // panel_chuanoidung
            // 
            this.panel_chuanoidung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.panel_chuanoidung.Controls.Add(this.dgv_bangnoidung);
            this.panel_chuanoidung.Location = new System.Drawing.Point(234, 12);
            this.panel_chuanoidung.Name = "panel_chuanoidung";
            this.panel_chuanoidung.Size = new System.Drawing.Size(929, 506);
            this.panel_chuanoidung.TabIndex = 1;
            // 
            // dgv_bangnoidung
            // 
            this.dgv_bangnoidung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_bangnoidung.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.dgv_bangnoidung.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgv_bangnoidung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bangnoidung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_bangnoidung.GridColor = System.Drawing.Color.Gray;
            this.dgv_bangnoidung.Location = new System.Drawing.Point(0, 0);
            this.dgv_bangnoidung.Name = "dgv_bangnoidung";
            this.dgv_bangnoidung.RowHeadersWidth = 44;
            this.dgv_bangnoidung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_bangnoidung.Size = new System.Drawing.Size(929, 506);
            this.dgv_bangnoidung.StandardTab = true;
            this.dgv_bangnoidung.TabIndex = 0;
            this.dgv_bangnoidung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bangnoidung_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.btn_Hienbangtimkiem);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.btn_Capnhat);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.btn_Luu);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btn_Inhoadon);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Controls.Add(this.panel_green);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1012);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(15, 230);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(25, 25);
            this.pictureBox7.TabIndex = 14;
            this.pictureBox7.TabStop = false;
            // 
            // btn_Hienbangtimkiem
            // 
            this.btn_Hienbangtimkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btn_Hienbangtimkiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Hienbangtimkiem.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hienbangtimkiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Hienbangtimkiem.ImageIndex = 0;
            this.btn_Hienbangtimkiem.Location = new System.Drawing.Point(12, 227);
            this.btn_Hienbangtimkiem.Name = "btn_Hienbangtimkiem";
            this.btn_Hienbangtimkiem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Hienbangtimkiem.Size = new System.Drawing.Size(185, 32);
            this.btn_Hienbangtimkiem.TabIndex = 13;
            this.btn_Hienbangtimkiem.Text = "On/Off Tìm Kiếm";
            this.btn_Hienbangtimkiem.UseVisualStyleBackColor = false;
            this.btn_Hienbangtimkiem.Click += new System.EventHandler(this.btn_Hienbangtimkiem_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(15, 154);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(25, 25);
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // btn_Capnhat
            // 
            this.btn_Capnhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btn_Capnhat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Capnhat.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Capnhat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Capnhat.ImageIndex = 0;
            this.btn_Capnhat.Location = new System.Drawing.Point(12, 151);
            this.btn_Capnhat.Name = "btn_Capnhat";
            this.btn_Capnhat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Capnhat.Size = new System.Drawing.Size(185, 32);
            this.btn_Capnhat.TabIndex = 11;
            this.btn_Capnhat.Text = "Cập Nhật";
            this.btn_Capnhat.UseVisualStyleBackColor = false;
            this.btn_Capnhat.Click += new System.EventHandler(this.btn_Capnhat_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(15, 116);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btn_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Luu.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Luu.ImageIndex = 0;
            this.btn_Luu.Location = new System.Drawing.Point(12, 113);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Luu.Size = new System.Drawing.Size(185, 32);
            this.btn_Luu.TabIndex = 9;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(15, 78);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Sua.ImageIndex = 0;
            this.btn_Sua.Location = new System.Drawing.Point(12, 75);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Sua.Size = new System.Drawing.Size(185, 32);
            this.btn_Sua.TabIndex = 7;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(15, 40);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Xoa.ImageIndex = 0;
            this.btn_Xoa.Location = new System.Drawing.Point(12, 37);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Xoa.Size = new System.Drawing.Size(185, 32);
            this.btn_Xoa.TabIndex = 5;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(15, 192);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Inhoadon
            // 
            this.btn_Inhoadon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btn_Inhoadon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Inhoadon.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inhoadon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Inhoadon.ImageIndex = 0;
            this.btn_Inhoadon.Location = new System.Drawing.Point(12, 189);
            this.btn_Inhoadon.Name = "btn_Inhoadon";
            this.btn_Inhoadon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Inhoadon.Size = new System.Drawing.Size(185, 32);
            this.btn_Inhoadon.TabIndex = 3;
            this.btn_Inhoadon.Text = "In Hóa Đơn";
            this.btn_Inhoadon.UseVisualStyleBackColor = false;
            this.btn_Inhoadon.Click += new System.EventHandler(this.btn_Inhoadon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(15, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Them.ImageIndex = 0;
            this.btn_Them.Location = new System.Drawing.Point(12, 3);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Them.Size = new System.Drawing.Size(185, 32);
            this.btn_Them.TabIndex = 2;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // panel_green
            // 
            this.panel_green.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.panel_green.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_green.Location = new System.Drawing.Point(3, 3);
            this.panel_green.Name = "panel_green";
            this.panel_green.Size = new System.Drawing.Size(6, 32);
            this.panel_green.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1924, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label_ProductLoai
            // 
            this.label_ProductLoai.AutoSize = true;
            this.label_ProductLoai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ProductLoai.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_ProductLoai.Location = new System.Drawing.Point(836, 14);
            this.label_ProductLoai.Name = "label_ProductLoai";
            this.label_ProductLoai.Size = new System.Drawing.Size(131, 21);
            this.label_ProductLoai.TabIndex = 8;
            this.label_ProductLoai.Text = "Loại Sản Phẩm";
            // 
            // label_
            // 
            this.label_.AutoSize = true;
            this.label_.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_.Location = new System.Drawing.Point(836, 79);
            this.label_.Name = "label_";
            this.label_.Size = new System.Drawing.Size(140, 21);
            this.label_.TabIndex = 11;
            this.label_.Text = "Hãng Sản Phẩm";
            // 
            // comboBox_ProductLoai
            // 
            this.comboBox_ProductLoai.FormattingEnabled = true;
            this.comboBox_ProductLoai.Location = new System.Drawing.Point(974, 13);
            this.comboBox_ProductLoai.Name = "comboBox_ProductLoai";
            this.comboBox_ProductLoai.Size = new System.Drawing.Size(263, 23);
            this.comboBox_ProductLoai.TabIndex = 12;
            // 
            // comboBox_ProductHang
            // 
            this.comboBox_ProductHang.FormattingEnabled = true;
            this.comboBox_ProductHang.Location = new System.Drawing.Point(974, 79);
            this.comboBox_ProductHang.Name = "comboBox_ProductHang";
            this.comboBox_ProductHang.Size = new System.Drawing.Size(263, 23);
            this.comboBox_ProductHang.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.panel_Login);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_Login.ResumeLayout(false);
            this.panel_Bangnoidung2.ResumeLayout(false);
            this.panel_Bangnoidung2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_product)).EndInit();
            this.panel_bangnoidung1.ResumeLayout(false);
            this.panel_bangnoidung1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bangtimkiem)).EndInit();
            this.panel_chuanoidung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bangnoidung)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mt_DangXuat;
        public System.Windows.Forms.Panel panel_Login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_Inhoadon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Panel panel_green;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btn_Capnhat;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel_chuanoidung;
        private System.Windows.Forms.DataGridView dgv_bangnoidung;
        private System.Windows.Forms.Panel panel_bangnoidung1;
        private System.Windows.Forms.TextBox textBox_TimKiem;
        private System.Windows.Forms.Button btn_Timkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Bangtimkiem;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button btn_Hienbangtimkiem;
        private System.Windows.Forms.TextBox textBox_productMota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_productTen;
        private System.Windows.Forms.PictureBox pic_product;
        private System.Windows.Forms.TextBox textBox_productGiaSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_Bangnoidung2;
        private System.Windows.Forms.Label label_;
        private System.Windows.Forms.Label label_ProductLoai;
        private System.Windows.Forms.ComboBox comboBox_ProductHang;
        private System.Windows.Forms.ComboBox comboBox_ProductLoai;
    }
}

