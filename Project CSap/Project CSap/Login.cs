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
    }
}
