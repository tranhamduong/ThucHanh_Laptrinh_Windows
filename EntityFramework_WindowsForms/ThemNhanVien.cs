using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework_WindowsForms
{
    public partial class FormThemNhanVien : Form
    {
        private NhanVienModel dbContext = new NhanVienModel();
        private Form1 formCha;
        public FormThemNhanVien()
        {
            InitializeComponent();
        }

        public FormThemNhanVien(Form1 formCha)
        {
            InitializeComponent();
            this.formCha = formCha;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            NHANVIEN nhanVienMoi = new NHANVIEN();
            nhanVienMoi.MANV = "NV0099";
            nhanVienMoi.HOTEN = txtHoTen.Text;
            nhanVienMoi.NGAYSINH = dateTimePicker1.Value;
            dbContext.NHANVIENs.Add(nhanVienMoi);
            dbContext.SaveChanges();

            //this.formCha.refreshDataGridView(); //Su dung customized function 

            this.formCha.dataGridView.DataSource = dbContext.NHANVIENs.ToList(); // set datagridview ve public

            this.Close();
        }

        private void formThemNhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
