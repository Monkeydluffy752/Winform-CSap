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
            // Truyền Dữ Liệu lên DGV
            ConnectData connect = new ConnectData();
            this.dgv_bangnoidung.DataSource = connect.TakeAllProducts();



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
            int i = dgv_bangnoidung.CurrentRow.Index;
            DialogResult result = MessageBox.Show("Bạn Có Thật Sự Muốn Xóa Sản Phẩm Này Không","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question); // Thông Báo Xóa
            if(result == DialogResult.Yes)
            {
                ConnectData connect = new ConnectData();
                try
                {

                    int convert = int.Parse(dgv_bangnoidung.Rows[i].Cells[0].Value.ToString());
                    connect.Xoa(convert);
                    load();
                }
                catch(Exception)
                {
                    MessageBox.Show("Lỗi Sản Phẩm");
                }

            }
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
        public static bool onAndoff = true;
        private void btn_Hienbangtimkiem_Click(object sender, EventArgs e)
        {
            greenmove(btn_Hienbangtimkiem);
            if (onAndoff == true)
            {
                this.panel_bangnoidung1.Visible = true;
                onAndoff = false;
            }
            else
            {
                this.panel_bangnoidung1.Visible = false;
                onAndoff = true;
            }
        }

        private void dgv_bangnoidung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.panel_Bangnoidung2.Visible = true;
            //MessageBox.Show(s);
            try
            {
                int i = dgv_bangnoidung.CurrentRow.Index;
                try
                {
                    ConnectData connect = new ConnectData();
                    int convert = int.Parse(dgv_bangnoidung.Rows[i].Cells[0].Value.ToString()); //Đổi dữ liệu ID thành int
                    string strImage = connect.TakeImage(convert); // Lấy hình ảnh bằng ID
                    this.pic_product.Image = new Bitmap(Application.StartupPath + "\\Resource\\" + strImage);
                    this.comboBox_ProductHang.DataSource = connect.HangSanPham(convert);
                    this.comboBox_ProductHang.DisplayMember = "Name_Type";
                    this.comboBox_ProductLoai.DataSource = connect.LoaiSanPham(convert);
                    this.comboBox_ProductLoai.DisplayMember = "Name_Type";
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Hình Ảnh Không Tồn Tại");
                }
                this.textBox_productTen.Text = dgv_bangnoidung.Rows[i].Cells[1].Value.ToString();
                this.textBox_productMota.Text = dgv_bangnoidung.Rows[i].Cells[2].Value.ToString();
                this.textBox_productGiaSP.Text = dgv_bangnoidung.Rows[i].Cells[3].Value.ToString();
        }
            catch(Exception)
            {
                MessageBox.Show("Bạn Chưa Chọn Sản Phẩm");
            }
        }
        private void load()
        {
            ConnectData connect = new ConnectData();
            dgv_bangnoidung.DataSource = connect.TakeAllProducts();
        }
    }
}
