using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_TH_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextBox txtBox = new TextBox(); //Khởi tạo đối tượng TextBox
            txtBox.Text = "This is a cool textbox \n This is a very cool textbox"; //Thay đổi TxtBox

            // Đặt lại vị trí của TextBox
            //txtBox.Location = new Point(this.Width / 2, this.Height / 2);
            
            txtBox.BackColor = Color.Blue; // Đặt màu background của txtBox thành màu xanh 
            txtBox.ForeColor = Color.Red; // Đặt màu chữ của txtBox thành màu đỏ.
            
            // Giao txtBox cho Form1 quản lý
            this.Controls.Add(txtBox);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "Click Me!";
            button1.BackColor = Color.Yellow;

            

        }
    }
}
