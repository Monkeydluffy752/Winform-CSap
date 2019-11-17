using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Project_CSap
{
    class ConnectData
    {
        private static string _Connect = @"Data Source=DESKTOP-1AM41CJ\SQLEXPRESS001;Initial Catalog=NHASACH;Integrated Security=True";
        public DataTable TakeAllProducts()
        {
            SqlConnection connect = new SqlConnection(_Connect);
            DataTable table = new DataTable();
            SqlDataAdapter dapter = new SqlDataAdapter();
            string SQLCommand = "Select ID_Products,NameProducts,DescriptionProducts,PriceProducts,ID_TypeProducts,ID_ManufaceProducts,QuantityProduct from Products";   
            dapter.SelectCommand = new SqlCommand(SQLCommand, connect);
            dapter.Fill(table);
            return table;
        }
        public void ClientRegisteration(string NameManager,string PasswordManager,int NumberPhone)
        {
            SqlConnection connect = new SqlConnection(_Connect);
            connect.Open();
            DataTable table = new DataTable();
            string SQLCommand = "insert into Manager(NameManager,passwordManager,NumberPhone)values(N'"+ NameManager + "', N'"+ PasswordManager + "', "+ NumberPhone + ")";
            SqlCommand command = new SqlCommand(SQLCommand, connect);
            command.ExecuteNonQuery(); // thực thi câu lệnh
            
        }
        public int CheckAccount(string TK,string MK)
        {
            SqlConnection connect = new SqlConnection(_Connect);
            connect.Open();
            DataTable table = new DataTable();
            SqlDataAdapter dapter = new SqlDataAdapter();
            string SQLCommand = "select NameManager,passwordManager from Manager where NameManager = N'"+TK+"' and passwordManager = N'"+MK+"'";
            dapter.SelectCommand = new SqlCommand(SQLCommand, connect);
            dapter.Fill(table);
            return table.Rows.Count;
        }
        // Hàm lấy hình ảnh trong
        public string TakeImage(int i_ID)
        {
            SqlConnection connect = new SqlConnection(_Connect);
            connect.Open();
            DataTable table = new DataTable();
            SqlDataAdapter dapter = new SqlDataAdapter();
            try
            {
                    string SQLCommand = "Select  PicturesProducts from Products where ID_Products = " + i_ID;
                    dapter.SelectCommand = new SqlCommand(SQLCommand, connect);
                    dapter.Fill(table);
            }catch(Exception)
            {
                Console.WriteLine("Lỗi Thực Thi");
            }
            return table.Rows[0].ItemArray[0].ToString(); // Lấy dữ liệu từ bảng images VD 13.jpg
        }
        public void Xoa(int i_ID)
        {
            SqlConnection connect = new SqlConnection(_Connect);
            connect.Open();
            DataTable table = new DataTable();
            SqlDataAdapter dapter = new SqlDataAdapter();
            try
            {
                string SQLCommand = "delete from Products where ID_Products = " + i_ID;
                SqlCommand command = new SqlCommand(SQLCommand, connect);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                Console.WriteLine("Lỗi Thực Thi");
            }
        }
        public DataTable HangSanPham()
        {
            SqlConnection connect = new SqlConnection(_Connect);
            connect.Open();
            DataTable table = new DataTable();
            SqlDataAdapter dapter = new SqlDataAdapter();
            try
            {
                string SQLCommand = "Select Name_Type from ManufaceProducts";
                dapter.SelectCommand = new SqlCommand(SQLCommand, connect);
                dapter.Fill(table);
            }
            catch (Exception)
            {
                Console.WriteLine("Lỗi Thực Thi");
            }
            return table;
        }
        public DataTable LoaiSanPham()
        {
            SqlConnection connect = new SqlConnection(_Connect);
            connect.Open();
            DataTable table = new DataTable();
            SqlDataAdapter dapter = new SqlDataAdapter();
            try
            {
                string SQLCommand = "Select TypeProducts.Name_Type from TypeProducts";
                dapter.SelectCommand = new SqlCommand(SQLCommand, connect);
                dapter.Fill(table);
            }
            catch (Exception)
            {
                Console.WriteLine("Lỗi Thực Thi");
            }
            return table;
        }
        public string ChonHangSanPham(int i_ID)
        {
            SqlConnection connect = new SqlConnection(_Connect);
            connect.Open();
            DataTable table = new DataTable();
            SqlDataAdapter dapter = new SqlDataAdapter();
            try
            {
                string SQLCommand = "Select Name_Type from ManufaceProducts where ID_Manuface = " + i_ID;
                dapter.SelectCommand = new SqlCommand(SQLCommand, connect);
                dapter.Fill(table);
            }
            catch (Exception)
            {
                Console.WriteLine("Lỗi Thực Thi");
            }
            return table.Rows[0].ItemArray[0].ToString();
        }
        public string ChonLoaiSanPham(int i_ID)
        {
            SqlConnection connect = new SqlConnection(_Connect);
            connect.Open();
            DataTable table = new DataTable();
            SqlDataAdapter dapter = new SqlDataAdapter();
            try
            {
                string SQLCommand = "Select TypeProducts.Name_Type from TypeProducts where TypeProducts.ID_Type = " + i_ID;
                dapter.SelectCommand = new SqlCommand(SQLCommand, connect);
                dapter.Fill(table);
            }
            catch (Exception)
            {
                Console.WriteLine("Lỗi Thực Thi");
            }
            return table.Rows[0].ItemArray[0].ToString();
        }
        public void insert(string NameProducts,string DescriptionProducts,string PicturesProducts,int GiaSP , int ID_TypeProducts,int ID_ManufaceProducts, int QuantityProduct)
        {
            SqlConnection connect = new SqlConnection(_Connect);
            connect.Open();
            DataTable table = new DataTable();
            SqlDataAdapter dapter = new SqlDataAdapter();
            string SQLCommand = "insert into Products(NameProducts,DescriptionProducts,PicturesProducts,PriceProducts,ID_TypeProducts,ID_ManufaceProducts,QuantityProduct) values(N'" + NameProducts + "',N'" + DescriptionProducts + "',N'" + PicturesProducts + "'," + GiaSP + "," + ID_TypeProducts + "," + ID_ManufaceProducts + "," + QuantityProduct + ")";
            SqlCommand command = new SqlCommand(SQLCommand, connect);
            command.ExecuteNonQuery();
        }

    }
}
