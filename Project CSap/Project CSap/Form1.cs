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
        public static bool onAndoff = true;
        public static bool clickClear = false;
        public static string PathHoaDon = "";
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
            if(clickClear == true)
            {
                if (this.comboBox_ProductHang.Text.Length == 0 && this.comboBox_ProductLoai.Text.Length == 0 && this.textBox_productTen.Text.Length == 0 && this.textBox_productMota.Text.Length == 0 && this.textBox_productGiaSP.Text.Length == 0 && this.textBox_ProductSoLuong.Text.Length == 0)
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
                        catch (Exception)
                        {
                            MessageBox.Show("Lỗi Thêm Vào");
                        }
                        //Thêm Hình Ảnh Vào Source
                        try
                        {
                            File.Copy(pathName, Path.Combine(Application.StartupPath + "\\Resource", Path.GetFileName(pathName)), true);
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
                clickClear = false;
            }
            else
            {
                MessageBox.Show("Phải Làm Mới Trước khi thêm");
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
            int i = dgv_bangnoidung.CurrentRow.Index;
            ConnectData connect = new ConnectData();
            int convertID = int.Parse(dgv_bangnoidung.Rows[i].Cells[0].Value.ToString());
            string oldPathImg = dgv_bangnoidung.Rows[i].Cells[7].Value.ToString();
            if (this.textBox_productTen.Text.Length > 0 && this.textBox_productMota.Text.Length > 0 && this.textBox_productGiaSP.Text.Length > 0 && comboBox_ProductLoai.Text.Length > 0 && comboBox_ProductHang.Text.Length > 0&& textBox_ProductSoLuong.Text.Length > 0)
            {
                int convertGia = int.Parse(textBox_productGiaSP.Text);
                int convertLoai = comboBox_ProductLoai.SelectedIndex+1;
                int convertHang = comboBox_ProductHang.SelectedIndex+1;
                int convertSoLuong = int.Parse(textBox_ProductSoLuong.Text);
                string name = this.textBox_productTen.Text;
                string description = this.textBox_productMota.Text;
                string pathName = this.label_TenFileHinhAnh.Text;
                string LastNameofPath = "";
                if (this.label_TenFileHinhAnh.Text.Length > 0)
                {
                     LastNameofPath = pathName.Substring(pathName.LastIndexOf(@"\") + 1); // Lấy Tên Ảnh
                    try
                    {

                        File.Copy(pathName, Path.Combine(Application.StartupPath + "\\Resource", Path.GetFileName(pathName)), true);
                        load();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lỗi Đường Dẫn");
                    }
                    connect.update(convertID, name, description, LastNameofPath, convertGia, convertLoai, convertHang, convertSoLuong);
                }
                else
                {
                    connect.update(convertID, name, description, oldPathImg, convertGia, convertLoai, convertHang, convertSoLuong);
                    load();
                }

                MessageBox.Show("Sửa Thành Công", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Thiếu Thông Tin ");
            }
        }
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
            clickClear = true;
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

        private void btn_Timkiem_Click(object sender, EventArgs e)
        {
            if(this.textBox_TimKiem.Text.Length > 0)
            {
                try
                {

                    ConnectData connect = new ConnectData();
                    dgv_bangnoidung.DataSource = connect.Search(this.textBox_TimKiem.Text);

                }
                catch(Exception)
                {
                    MessageBox.Show("Dữ Liệu Nhập Bị Sai Hoặc Không Tồn Tại","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn Chưa Nhập Dữ Liệu Vào Khung Tìm Kiếm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Luuhoadon_Click(object sender, EventArgs e)
        {
            greenmove(btn_Luuhoadon);
            bool LuuSP = false;
            if (this.textBox_productTen.Text.Length > 0 && this.textBox_productMota.Text.Length > 0 && this.textBox_productGiaSP.Text.Length > 0 && this.comboBox_ProductLoai.Text.Length > 0 && this.comboBox_ProductHang.Text.Length > 0 && this.textBox_ProductSoLuong.Text.Length > 0)
            {
                if (File.Exists(PathHoaDon))
                {
                    try
                    {
                        FileStream file = new FileStream(PathHoaDon, FileMode.Append);
                        StreamWriter writeAppend = new StreamWriter(file);
                        DateTime aDateTime = DateTime.Now;
                        writeAppend.WriteLine("Tên Sản Phẩm: " + this.textBox_productTen.Text);
                        writeAppend.WriteLine("Tên Mô Tả: " + this.textBox_productMota.Text);
                        writeAppend.WriteLine("Giá SP: " + this.textBox_productGiaSP.Text);
                        writeAppend.WriteLine("Loại SP: " + this.comboBox_ProductLoai.Text);
                        writeAppend.WriteLine("Hãng SP: " + this.comboBox_ProductHang.Text);
                        writeAppend.WriteLine("Số Lượng: " + this.textBox_ProductSoLuong.Text);
                        writeAppend.WriteLine("Ngày Thanh Toán: " + aDateTime);
                        writeAppend.WriteLine("-----------------------------------------------");
                        writeAppend.Close();
                        file.Close();
                        string[] In = File.ReadAllLines(PathHoaDon);
                        int locationSelection = dgv_bangnoidung.CurrentRow.Index;
                        string strImg = dgv_bangnoidung.Rows[locationSelection].Cells[7].Value.ToString();
                        MessageBox.Show(strImg);
                        for (int i = 0; i < In.Length; i++)
                        {
                            if (In[i].Contains(dgv_bangnoidung.Rows[locationSelection].Cells[1].Value.ToString()))
                            {
                                MessageBox.Show(In[i].ToString());
                                this.textBox_TenSP.Text = In[i].ToString();
                                this.textBox_MoTaSP.Text = In[i + 1].ToString();
                                this.textBox_GiaSP.Text = In[i + 2].ToString();
                                this.textBox_LoaiSP.Text = In[i + 3].ToString();
                                this.textBox_HangSP.Text = In[i + 4].ToString();
                                this.textBox_LuongSP.Text = In[i + 5].ToString();
                                this.textBox_NgayVaGio.Text = In[i + 6].ToString();
                                try
                                {
                                    pictureBox_SP.Image = new Bitmap(Application.StartupPath + "\\Resource\\" + strImg);
                                }
                                catch (FileLoadException)
                                {
                                    MessageBox.Show("Không Thể Load File", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                this.panel_HoaDon.Visible = true;
                            }
                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Quá Trình Vẫn Đang Xử Lý");
                    }
                }
                else
                {
                    try
                    {
                        SaveFileDialog fileOpen = new SaveFileDialog();
                        fileOpen.Filter = "|*.txt";
                        if (fileOpen.ShowDialog() == DialogResult.OK)
                        {
                            Stream file = fileOpen.OpenFile();
                            StreamWriter write = new StreamWriter(file);
                            DateTime aDateTime = DateTime.Now;
                            write.WriteLine("Tên Sản Phẩm: " + this.textBox_productTen.Text);
                            write.WriteLine("Tên Mô Tả: " + this.textBox_productMota.Text);
                            write.WriteLine("Giá SP: " + this.textBox_productGiaSP.Text);
                            write.WriteLine("Loại SP: " + this.comboBox_ProductLoai.Text);
                            write.WriteLine("Hãng SP: " + this.comboBox_ProductHang.Text);
                            write.WriteLine("Số Lượng: " + this.textBox_ProductSoLuong.Text);
                            write.WriteLine("Ngày Thanh Toán: " + aDateTime);
                            write.WriteLine("-----------------------------------------------");
                            PathHoaDon = fileOpen.FileName.ToString();
                            this.Text = PathHoaDon;
                            if (File.Exists(PathHoaDon))
                            {
                                MessageBox.Show("Đã Lưu Hóa Đơn Thành Công");
                                LuuSP = true;
                            }
                            write.Close();
                            file.Close();
                            if (LuuSP == true)
                            {
                                int selectedLocationImg = dgv_bangnoidung.CurrentRow.Index;
                                string[] ShowAllProduct = File.ReadAllLines(fileOpen.FileName);
                                string strImg = dgv_bangnoidung.Rows[selectedLocationImg].Cells[7].Value.ToString();
                                for (int i = 0; i< ShowAllProduct.Length;i++)
                                {
                                    if(ShowAllProduct[i].Contains(this.textBox_productTen.Text))
                                    {
                                        this.panel_HoaDon.Visible = true;
                                        this.textBox_TenSP.Text = ShowAllProduct[i].ToString();
                                        this.textBox_MoTaSP.Text = ShowAllProduct[i+1].ToString();
                                        this.textBox_GiaSP.Text = ShowAllProduct[i + 2].ToString();
                                        this.textBox_LoaiSP.Text = ShowAllProduct[i + 3].ToString();
                                        this.textBox_HangSP.Text = ShowAllProduct[i + 4].ToString();
                                        this.textBox_LuongSP.Text = ShowAllProduct[i + 5].ToString();
                                        this.textBox_NgayVaGio.Text = ShowAllProduct[i + 6].ToString();
                                        try
                                        {
                                            pictureBox_SP.Image = new Bitmap(Application.StartupPath + "\\Resource\\" + strImg);
                                        }catch(FileLoadException)
                                        {
                                            MessageBox.Show("Không Thể Load File", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                            }
                        }                       
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Lỗi Đường Dẫn,Bạn Nên Xem Lại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn Chưa Chọn Sản Phẩm Để Thanh Toán", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.panel_HoaDon.Visible = false;
        }
    }
}
