using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_CSap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.panel_Login.Width = this.Width / 2;
        }

        private void mt_DangXuat_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            DialogResult result = MessageBox.Show("Bạn Muốn Đăng Xuất", "Thông Báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Close();
                login.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PictureBox a = new PictureBox();
            Button btn = new Button() { Text = "a",Location = new Point(222,213)};
            this.Controls.Add(btn);
            //a.Image = new Bitmap(Application.StartupPath + "\\Resource\\1.jpg");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PictureBox a = new PictureBox();
            Random rand = new Random();
            Button btn = new Button() {Text = "a", Location = new Point(rand.Next(0,100),rand.Next(0,100))};
            btn.Visible = true;
            btn.Name = "ad";
            this.panel_Login.Controls.Add(btn);
            
            //a.Image = new Bitmap(Application.StartupPath + "\\Resource\\1.jpg");
        }
        private void greenmove(Control c)
        {
            this.panel_green.Height = c.Height;
            this.panel_green.Top = c.Top;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            greenmove(btn_Them);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            greenmove(btn_Xoa);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            greenmove(btn_Sua);
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            greenmove(btn_Luu);
        }

        private void btn_Capnhat_Click(object sender, EventArgs e)
        {
            greenmove(btn_Capnhat);
        }

        private void btn_Inhoadon_Click(object sender, EventArgs e)
        {
            greenmove(btn_Inhoadon);
        }
    }
}
