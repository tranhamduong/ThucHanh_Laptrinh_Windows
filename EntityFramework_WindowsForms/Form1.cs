using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EntityFramework_WindowsForms.NhanVienModel;

namespace EntityFramework_WindowsForms
{
    public partial class Form1 : Form
    {
        private NhanVienModel dbContext = new NhanVienModel();
        private FormThemNhanVien formThemNhanVien;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataGridView.DataSource = dbContext.NHANVIENs.ToList();
            //dataGridView.DataSource = dbContext.NHANVIENs.Select(x => new {x.HOTEN}).ToList();
        }

        public void refreshDataGridView()
        {
            this.dataGridView.DataSource = dbContext.NHANVIENs.ToList();
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                formThemNhanVien = new FormThemNhanVien(this);
                formThemNhanVien.Show();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
