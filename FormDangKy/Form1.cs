using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace FormDangKy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {

            string outputPath = @"C:\Users\PC\Desktop\" + txtBox_SDT.Text + ".txt";
            StreamWriter outputFile = new StreamWriter(outputPath, true);

            outputFile.WriteLine("Họ và tên: {0}", txtBox_HoVaTen.Text);
            outputFile.WriteLine("SĐT: {0}", txtBox_SDT.Text);
            outputFile.WriteLine("Email: {0}", txtBox_SDT.Text);
            outputFile.WriteLine("NTNS: {0}", dateTimePicker.Text);

            if (radioBtn_Nam.Checked == true)
            {
                outputFile.WriteLine("Nam");
            }
            else
            {
                outputFile.WriteLine("Nữ");
            }
            outputFile.Close();
        }

        private void chkBox_Iagree_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_Iagree.Checked == true)
            {
                btn_DangKy.Enabled = true;
            }
            else
            {
                btn_DangKy.Enabled = false;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtBox_HoVaTen.Text = "";
            txtBox_email.Text = "";
            txtBox_SDT.Text = "";
            radioBtn_Nam.Checked = false;
            radioBtn_Nu.Checked = false;
            chkBox_Iagree.Checked = false;  
        }
    }
}
