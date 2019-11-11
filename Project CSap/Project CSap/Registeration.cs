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
    public partial class Registeration : Form
    {
        public Registeration()
        {
            InitializeComponent();
        }

        private void btn_NutDangKy_Click(object sender, EventArgs e)    // Hàm kiểm tra text không null và lưu vào DATABASE
        {
           
            if (this.tb_TenDangKy.Text != null && this.tb_MatKhauDangKy.Text != null && this.tb_Phone.Text != null)
            {
             
            }
        }

        private void btn_NutDangKy_Leave(object sender, EventArgs e)    // Nếu các text null thì báo lỗi
        {
            TextBox checkTextboxNull = sender as TextBox;
            if (checkTextboxNull.Text.Length <= 0)
            {
                errorProvider1.SetError(checkTextboxNull, "Chưa Có Phần Tử");
            }

        }

        private void tb_Phone_TextChanged(object sender, EventArgs e)   // Hàm Chặn không cho nhập số vào trong Phone
        {
            int num = 0;
            if (!Int32.TryParse(this.tb_Phone.Text, out num))
            {
                this.tb_Phone.Clear();
            }
        }
    }
}
