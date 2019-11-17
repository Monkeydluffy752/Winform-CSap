using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
            ConnectData connect = new ConnectData();
            if(this.comboBox_ProductHang.Text.Length == 0 && this.comboBox_ProductLoai.Text.Length == 0 && this.textBox_productTen.Text.Length == 0 && this.textBox_productMota.Text.Length == 0 && this.textBox_productGiaSP.Text.Length == 0 && this.textBox_ProductSoLuong.Text.Length == 0)
            {
                MessageBox.Show("Còn Ô Trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // ADD hình ảnh
                string pathName = this.label_TenFileHinhAnh.Text;
                string LastNameofPath = pathName.Substring(pathName.LastIndexOf(@"\") + 1); // Lấy Tên Ảnh
                int num = 0;
                if (Int32.TryParse(textBox_productGiaSP.Text, out num) && Int32.TryParse(this.textBox_ProductSoLuong.Text, out num))
                {     
                    int convertGiaSP = int.Parse(textBox_productGiaSP.Text);
                    int convertLoai = int.Parse(this.comboBox_ProductLoai.SelectedIndex.ToString());
                    int convertHang = int.Parse(this.comboBox_ProductHang.SelectedIndex.ToString());
                    int convertSoLuong = int.Parse(this.textBox_ProductSoLuong.Text);
                   try
                    {
                        connect.insert(textBox_productTen.Text, textBox_productMota.Text, LastNameofPath, convertGiaSP, convertLoai, convertHang, convertSoLuong);
                        load();
                        clear();
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("Lỗi Thêm Vào");
                    }
                    //Thêm Hình Ảnh Vào Source
                    try
                    {
                        File.Copy(pathName, Path.Combine(@"C:\Users\PC\source\repos\Winform-CSap\Project CSap\Project CSap\bin\Debug\Resource", Path.GetFileName(pathName)), true);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Đường Dẫn Hình Ảnh Sai");
                    }
                }
                else
                {
                    MessageBox.Show("Số Lượng và Giá SP Phải là kiểu số");
                }
            }
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
            this.pic_product.Visible = true;
            this.panel_Bangnoidung2.Visible = true;
            //MessageBox.Show(s);
            try
            {
                int i = dgv_bangnoidung.CurrentRow.Index;
                try
                {
                    ConnectData connect = new ConnectData();
                    int convert = int.Parse(dgv_bangnoidung.Rows[i].Cells[0].Value.ToString()); //Đổi dữ liệu ID thành int
                    int convertLoai = int.Parse(dgv_bangnoidung.Rows[i].Cells[4].Value.ToString()); //Đổi dữ liệu ID thành int
                    int convertHang = int.Parse(dgv_bangnoidung.Rows[i].Cells[5].Value.ToString()); //Đổi dữ liệu ID thành int
                    string strImage = connect.TakeImage(convert); // Lấy hình ảnh bằng ID
                    this.pic_product.Image = new Bitmap(Application.StartupPath + "\\Resource\\" + strImage);
                    // Thêm Tất cả hảng vào combox 
                    this.comboBox_ProductHang.DataSource = connect.HangSanPham();
                    this.comboBox_ProductHang.DisplayMember = "Name_Type";
                    this.comboBox_ProductHang.Text = connect.ChonHangSanPham(convertHang); 
                    // Thêm Tất cả Loại vào combox 
                    this.comboBox_ProductLoai.DataSource = connect.LoaiSanPham();
                    this.comboBox_ProductLoai.DisplayMember = "Name_Type";
                    this.comboBox_ProductLoai.Text = connect.ChonLoaiSanPham(convertLoai);
                    
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Hình Ảnh Không Tồn Tại");
                }
                try
                {
                    this.textBox_productTen.Text = dgv_bangnoidung.Rows[i].Cells[1].Value.ToString();
                    this.textBox_productMota.Text = dgv_bangnoidung.Rows[i].Cells[2].Value.ToString();
                    this.textBox_productGiaSP.Text = dgv_bangnoidung.Rows[i].Cells[3].Value.ToString();
                    this.textBox_ProductSoLuong.Text = dgv_bangnoidung.Rows[i].Cells[6].Value.ToString();
                }catch(Exception)
                {
                    MessageBox.Show("Lỗi Sản phẩm");
                }

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

        private void comboBox_ProductHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_productTen_Leave(object sender, EventArgs e)
        {
            TextBox AllProductText = sender as TextBox;
            if(AllProductText.Text.Length == 0)
            {
                errorProvider1.SetError(AllProductText, "Lỗi Nhập Thiếu");
            }
        }

        private void button_ThemHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "(File anh *.jpg)|*.jpg";
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                pic_product.Image = Image.FromFile(openFile.FileName);
                this.label_TenFileHinhAnh.Text = openFile.FileName.ToString();
                this.pic_product.Visible = true;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            this.label_TenFileHinhAnh.Text = "";
            this.pic_product.Visible = false;
            this.textBox_productTen.Text = "";
            this.textBox_productMota.Text = "";
            this.textBox_productGiaSP.Text = "";
            this.textBox_ProductSoLuong.Text = "";
            this.comboBox_ProductLoai.Text = "";
            this.comboBox_ProductHang.Text = "";
        }
    }
}
