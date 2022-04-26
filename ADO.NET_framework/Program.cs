using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace ADO_NET_framework
{
    class ADO_NET_framework
    {
        static int Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Đặt connectionString với các thông tin của DB: host, username, password,... 
            string connectionString = @"Data Source=DESKTOP-JF3MRK4\SQLEXPRESS;
                                        Initial Catalog=QUANLYSINHVIEN;
                                        Integrated Security=True";


            // Tạo connectionString sử dụng SqlConnectionStringBuilder
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder["Server"] = @"localhost\SQLEXPRESS"; 
            builder["Database"] = "QUANLYSINHVIEN";
            builder["Integrated Security"] = "True";
            string connectionStringFromBuilder = builder.ToString();

            // Khởi tạo đối tượng SqlConnection sử dụng connectionString nêu trên. 
            SqlConnection connection = new SqlConnection(connectionString);
            // Mở kết nối
            connection.Open();


            // Thực hiện thao tác trên CSDL
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "Select * from NHANVIEN";
               DbDataReader reader = command.ExecuteReader();

                Console.WriteLine("Kết quả truy vấn");

                while (reader.Read())
                {
                    // Truy vấn dữ liệu bằng số thứ tự của cột dữ liệu
                    Console.WriteLine("{0}, {1}", reader.GetString(0), reader.GetString(1));
            
            //        // Truy vấn dữ liệu bằng tên của column
                    Console.WriteLine(reader["LUONG"]);
                }
                reader.Close();
            }


            using (DbCommand command2 = connection.CreateCommand())
            {
                string maNV = "NV0011";
                string hoTenNV = "Dong Nhi";
                command2.CommandText = $"INSERT INTO NHANVIEN(MANV, HOTEN) " +
                                      $"VALUES ('{maNV}', '{hoTenNV}')";

                command2.ExecuteNonQuery();
            }

            // Luôn luôn phải đóng kết nối sau khi đã sử dụng 
            connection.Close();
            return 1;
        }
    }
}


