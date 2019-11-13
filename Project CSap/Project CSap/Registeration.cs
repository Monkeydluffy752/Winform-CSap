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
                ConnectData connectData = new ConnectData(); // Khởi tao kết nối bằng class ConnectData
                using(MD5 md5Hash = MD5.Create())
                {
                    string getPasswordHash = GetMd5Hash(md5Hash, this.tb_MatKhauDangKy.Text.ToString());
                    connectData.ClientRegisteration(this.tb_TenDangKy.Text, getPasswordHash, int.Parse(this.tb_Phone.Text));
                    this.Close();
                    MessageBox.Show("Bạn Đã Tạo Thành Công", "Thông Báo");
                }
            }
        }
        //Hàm GetMd5Hash dùng để hash password, có bảng hash trả vào SQL ghi thực thi trong btn_NutDangKy_Click
        public string GetMd5Hash(MD5 md5Hash,string strHash)
        {
            byte[] data = md5Hash.ComputeHash(UnicodeEncoding.UTF8.GetBytes(strHash));//Hash nên chuyển thể UTF8
            StringBuilder stringBuilData = new StringBuilder(); // StringBuilder nối các ký tự byte thành chuỗi
            for (int i = 0; i < data.Length; i++)
            {
                stringBuilData.Append(data[i].ToString());
            }
            return stringBuilData.ToString();
        }
        private void btn_NutDangKy_Leave(object sender, EventArgs e)    // Nếu các text null thì báo lỗi
        {
            TextBox checkTextboxNull = sender as TextBox;
            try
            {
                if (checkTextboxNull.Text.Length == 0)
                {
                    errorProvider1.SetError(checkTextboxNull, "Chưa Có Phần Tử");
                }
            }catch(Exception)
            {
                MessageBox.Show("Bạn Nhập Thiếu Phần Tử");
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
