using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace ADO.NET_WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-JF3MRK4\SQLEXPRESS;
                                        Initial Catalog=QUANLYSINHVIEN;
                                        Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            

            List<string> dsTenPhongBan = new List<string>();
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "Select * from PHONGBAN";
                DbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    dsTenPhongBan.Add(reader.GetString(1) + " - " + reader.GetString(0));
                }
                reader.Close();
            }

            this.comboBoxDSPhongBan.DataSource = dsTenPhongBan;

            List<string> comboBoxDataNQL = new List<string>();
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "Select HOTEN from NHANVIEN";
                DbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxDataNQL.Add(reader.GetString(0));
                }
                reader.Close();
            }

            this.myDataNQL.DataSource = comboBoxDataNQL;


            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "Select * from NHANVIEN";
                DbDataReader reader = command.ExecuteReader();

                Console.WriteLine("Kết quả truy vấn");

                DataTable dt = new DataTable();
                dt.Load(reader);

                this.myDataGridView.DataSource = dt;
                reader.Close();
            }

            connection.Close();
        }

        private void comboBoxDSPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-JF3MRK4\SQLEXPRESS;
                                        Initial Catalog=QUANLYSINHVIEN;
                                        Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string tenPhongBanCanTim = comboBoxDSPhongBan.Text;
            Console.WriteLine(tenPhongBanCanTim);

            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = $"Select * from NHANVIEN nv, PHONGBAN pb" +
                                       $" where nv.MAPH = pb.MAPH AND pb.TENPH=N'{tenPhongBanCanTim}'";
                                       
                DbDataReader reader = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                this.myDataGridView.DataSource = dt;
                reader.Close();
            }

            connection.Close();
        }

        private void myDataNQL_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-JF3MRK4\SQLEXPRESS;
                                        Initial Catalog=QUANLYSINHVIEN;
                                        Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string tenNQLCanTim = myDataNQL.Text;

            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = $"Select * from NHANVIEN nv1, NHANVIEN nv2 " +
                    $"where nv1.MANQL = nv2.MANV and nv2.HOTEN = N'{tenNQLCanTim}'";
                DbDataReader reader = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                this.myDataGridView.DataSource = dt;
                reader.Close();
            }

            connection.Close();
        }
    }
}
