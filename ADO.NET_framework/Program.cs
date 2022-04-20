using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace ADO_NET_framework
{
    class ADO_NET_framework
    {
        static int Main(string[] args)
        {
            string connectionString = @"Data Source=DESKTOP-JF3MRK4\SQLEXPRESS;Initial Catalog=QUANLYSINHVIEN;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            connection.Close();
            return 1;
        }
    }
}


