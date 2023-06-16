using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data;

namespace QLDeTai
{
    internal class modify
    {
        public modify()
        {

        }
        SqlCommand sqlCommand;//dùng để truy vấn các câu lệnh insert. update,delete,...
        SqlDataReader dataReader;// dùng để đọc dữ liệu trong bảng sql
        SqlDataAdapter dataAdapter;// dùng để truy xuất dữ liệu vào bảng

        public DataTable Table(string query)
        {
            DataTable dataTable = new DataTable();
            using(SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
      
        public List<Taikhoan> Taikhoans(string query)//dùng để check tài khoản
        {
            List<Taikhoan> taikhoans = new List<Taikhoan>();
            using(SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    taikhoans.Add(new Taikhoan(dataReader.GetString(0), dataReader.GetString(1)));
                }
                sqlConnection.Close();
            }
            return taikhoans;
        }
        public void Command(string query) // dùng để đăng ký tài khoản
        {
            using(SqlConnection sqlConnection =Connection.GetSqlConnection()) 
            { 
                sqlConnection.Open();
                sqlCommand = new SqlCommand (query, sqlConnection);
                sqlCommand.ExecuteNonQuery();// thực thi câu truy vấn
                sqlConnection.Close();
            }

        }
        
        
        
    }
}
