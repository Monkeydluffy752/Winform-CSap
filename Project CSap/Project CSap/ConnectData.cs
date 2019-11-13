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
            string SQLCommand = "Select * from Products";   
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
    }
}
