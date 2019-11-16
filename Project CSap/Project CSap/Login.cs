using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Project_CSap
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public bool clickDiTrangDangKy = false;
        private void btn_DiTrangDangKy_Click(object sender, EventArgs e)
        {
            Registeration re = new Registeration(); // Click vào nut btn_DiTrangDangKy_Click sẽ hiện Form Đăng Ký
            re.Show();
        }

        private void tb_TenTaiKhoan_Leave(object sender, EventArgs e)   // Hiện Thông Báo lỗi khi ng dùng bỏ qua 
        {
            TextBox errorText = sender as TextBox;
            if(errorText.Text.Length == 0)
            {
                errorProvider1.SetError(errorText, "Lỗi Để Trống Ô");
            }
        }

        private void btn_NutDangNhap_Click(object sender, EventArgs e) // Kiểm Tra đăng nhập tại đây
        {
            if(this.tb_TenTaiKhoan.Text.Length != 0 && this.tb_MatKhau.Text.Length != 0)
            {
                try
                {
                    MD5 md5hash = MD5.Create();
                    Registeration res = new Registeration();
                    string passwordHash = res.GetMd5Hash(md5hash, this.tb_MatKhau.Text);
                    ConnectData connectData = new ConnectData();
                    if (connectData.CheckAccount(this.tb_TenTaiKhoan.Text, passwordHash) > 0)
                    {
                        Form1 f = new Form1();
                        f.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Sai Mật Khẩu Hoặc Tài Khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }catch(Exception)
                {
                    MessageBox.Show("Lỗi Đường Truyền");
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
