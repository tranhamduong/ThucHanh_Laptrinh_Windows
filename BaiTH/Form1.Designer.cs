namespace BaiTH
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTenChuongTrinh = new System.Windows.Forms.Label();
            this.labelMotDongChuKhac = new System.Windows.Forms.Label();
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTenChuongTrinh
            // 
            this.labelTenChuongTrinh.AutoEllipsis = true;
            this.labelTenChuongTrinh.AutoSize = true;
            this.labelTenChuongTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenChuongTrinh.ForeColor = System.Drawing.Color.Red;
            this.labelTenChuongTrinh.Location = new System.Drawing.Point(61, 110);
            this.labelTenChuongTrinh.MaximumSize = new System.Drawing.Size(300, 0);
            this.labelTenChuongTrinh.Name = "labelTenChuongTrinh";
            this.labelTenChuongTrinh.Size = new System.Drawing.Size(292, 219);
            this.labelTenChuongTrinh.TabIndex = 0;
            this.labelTenChuongTrinh.Text = "Lớp Lập trình Windows";
            // 
            // labelMotDongChuKhac
            // 
            this.labelMotDongChuKhac.AutoSize = true;
            this.labelMotDongChuKhac.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotDongChuKhac.ForeColor = System.Drawing.Color.Green;
            this.labelMotDongChuKhac.Location = new System.Drawing.Point(239, 259);
            this.labelMotDongChuKhac.Name = "labelMotDongChuKhac";
            this.labelMotDongChuKhac.Size = new System.Drawing.Size(236, 26);
            this.labelMotDongChuKhac.TabIndex = 1;
            this.labelMotDongChuKhac.Text = "Đây là dòng chữ số 2";
            // 
            // textBox_Input
            // 
            this.textBox_Input.Location = new System.Drawing.Point(98, 341);
            this.textBox_Input.Multiline = true;
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(558, 34);
            this.textBox_Input.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(365, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Input);
            this.Controls.Add(this.labelMotDongChuKhac);
            this.Controls.Add(this.labelTenChuongTrinh);
            this.Name = "Form1";
            this.Text = "Đây là chương trình của tôi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTenChuongTrinh;
        private System.Windows.Forms.Label labelMotDongChuKhac;
        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.Button button1;
    }
}

