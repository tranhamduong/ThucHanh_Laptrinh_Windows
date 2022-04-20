namespace FormTaoMatKhauNgauNhien
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
            this.label_FormName = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.btn_SinhMatKhau = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_FormName
            // 
            this.label_FormName.AutoSize = true;
            this.label_FormName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FormName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_FormName.Location = new System.Drawing.Point(266, 69);
            this.label_FormName.Name = "label_FormName";
            this.label_FormName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_FormName.Size = new System.Drawing.Size(263, 46);
            this.label_FormName.TabIndex = 1;
            this.label_FormName.Text = "Tạo Mật khẩu";
            this.label_FormName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.Location = new System.Drawing.Point(117, 164);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.ReadOnly = true;
            this.txtBoxPassword.Size = new System.Drawing.Size(572, 44);
            this.txtBoxPassword.TabIndex = 2;
            this.txtBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_SinhMatKhau
            // 
            this.btn_SinhMatKhau.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_SinhMatKhau.Location = new System.Drawing.Point(301, 244);
            this.btn_SinhMatKhau.Name = "btn_SinhMatKhau";
            this.btn_SinhMatKhau.Size = new System.Drawing.Size(172, 23);
            this.btn_SinhMatKhau.TabIndex = 3;
            this.btn_SinhMatKhau.Text = "Tạo mật khẩu";
            this.btn_SinhMatKhau.UseVisualStyleBackColor = false;
            this.btn_SinhMatKhau.Click += new System.EventHandler(this.btn_SinhMatKhau_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(117, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_SinhMatKhau);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.label_FormName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_FormName;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Button btn_SinhMatKhau;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

