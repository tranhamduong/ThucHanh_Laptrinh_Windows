namespace FormDangKy
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
            this.label_HoVaTen = new System.Windows.Forms.Label();
            this.txtBox_HoVaTen = new System.Windows.Forms.TextBox();
            this.label_NTNS = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label_GioiTinh = new System.Windows.Forms.Label();
            this.radioBtn_Nam = new System.Windows.Forms.RadioButton();
            this.radioBtn_Nu = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_email = new System.Windows.Forms.TextBox();
            this.chkBox_Iagree = new System.Windows.Forms.CheckBox();
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.txtBox_SDT = new System.Windows.Forms.TextBox();
            this.label_SDT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_FormName
            // 
            this.label_FormName.AutoSize = true;
            this.label_FormName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FormName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_FormName.Location = new System.Drawing.Point(94, 82);
            this.label_FormName.Name = "label_FormName";
            this.label_FormName.Size = new System.Drawing.Size(580, 46);
            this.label_FormName.TabIndex = 0;
            this.label_FormName.Text = "FORM ĐĂNG KÝ THÀNH VIÊN";
            this.label_FormName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_HoVaTen
            // 
            this.label_HoVaTen.AutoSize = true;
            this.label_HoVaTen.Location = new System.Drawing.Point(109, 192);
            this.label_HoVaTen.Name = "label_HoVaTen";
            this.label_HoVaTen.Size = new System.Drawing.Size(58, 13);
            this.label_HoVaTen.TabIndex = 1;
            this.label_HoVaTen.Text = "Họ và Tên";
            // 
            // txtBox_HoVaTen
            // 
            this.txtBox_HoVaTen.Location = new System.Drawing.Point(190, 189);
            this.txtBox_HoVaTen.Name = "txtBox_HoVaTen";
            this.txtBox_HoVaTen.Size = new System.Drawing.Size(550, 20);
            this.txtBox_HoVaTen.TabIndex = 2;
            // 
            // label_NTNS
            // 
            this.label_NTNS.AutoSize = true;
            this.label_NTNS.Location = new System.Drawing.Point(58, 250);
            this.label_NTNS.Name = "label_NTNS";
            this.label_NTNS.Size = new System.Drawing.Size(107, 13);
            this.label_NTNS.TabIndex = 3;
            this.label_NTNS.Text = "Ngày tháng năm sinh";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(190, 250);
            this.dateTimePicker.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(550, 20);
            this.dateTimePicker.TabIndex = 4;
            // 
            // label_GioiTinh
            // 
            this.label_GioiTinh.AutoSize = true;
            this.label_GioiTinh.Location = new System.Drawing.Point(120, 280);
            this.label_GioiTinh.Name = "label_GioiTinh";
            this.label_GioiTinh.Size = new System.Drawing.Size(47, 13);
            this.label_GioiTinh.TabIndex = 5;
            this.label_GioiTinh.Text = "Giới tính";
            // 
            // radioBtn_Nam
            // 
            this.radioBtn_Nam.AutoSize = true;
            this.radioBtn_Nam.Location = new System.Drawing.Point(190, 276);
            this.radioBtn_Nam.Name = "radioBtn_Nam";
            this.radioBtn_Nam.Size = new System.Drawing.Size(47, 17);
            this.radioBtn_Nam.TabIndex = 6;
            this.radioBtn_Nam.TabStop = true;
            this.radioBtn_Nam.Text = "Nam";
            this.radioBtn_Nam.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Nu
            // 
            this.radioBtn_Nu.AutoSize = true;
            this.radioBtn_Nu.Location = new System.Drawing.Point(271, 276);
            this.radioBtn_Nu.Name = "radioBtn_Nu";
            this.radioBtn_Nu.Size = new System.Drawing.Size(39, 17);
            this.radioBtn_Nu.TabIndex = 7;
            this.radioBtn_Nu.TabStop = true;
            this.radioBtn_Nu.Text = "Nữ";
            this.radioBtn_Nu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Email";
            // 
            // txtBox_email
            // 
            this.txtBox_email.Location = new System.Drawing.Point(190, 310);
            this.txtBox_email.Name = "txtBox_email";
            this.txtBox_email.Size = new System.Drawing.Size(550, 20);
            this.txtBox_email.TabIndex = 9;
            // 
            // chkBox_Iagree
            // 
            this.chkBox_Iagree.AutoSize = true;
            this.chkBox_Iagree.Location = new System.Drawing.Point(190, 359);
            this.chkBox_Iagree.Name = "chkBox_Iagree";
            this.chkBox_Iagree.Size = new System.Drawing.Size(169, 17);
            this.chkBox_Iagree.TabIndex = 10;
            this.chkBox_Iagree.Text = "Tôi đã đọc kỹ điều lệ sử dụng";
            this.chkBox_Iagree.UseVisualStyleBackColor = true;
            this.chkBox_Iagree.CheckedChanged += new System.EventHandler(this.chkBox_Iagree_CheckedChanged);
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.BackColor = System.Drawing.Color.Green;
            this.btn_DangKy.Enabled = false;
            this.btn_DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangKy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_DangKy.Location = new System.Drawing.Point(430, 403);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(310, 23);
            this.btn_DangKy.TabIndex = 11;
            this.btn_DangKy.Text = "Đăng ký";
            this.btn_DangKy.UseVisualStyleBackColor = false;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(61, 403);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 12;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // txtBox_SDT
            // 
            this.txtBox_SDT.Location = new System.Drawing.Point(190, 217);
            this.txtBox_SDT.Name = "txtBox_SDT";
            this.txtBox_SDT.Size = new System.Drawing.Size(550, 20);
            this.txtBox_SDT.TabIndex = 14;
            // 
            // label_SDT
            // 
            this.label_SDT.AutoSize = true;
            this.label_SDT.Location = new System.Drawing.Point(109, 220);
            this.label_SDT.Name = "label_SDT";
            this.label_SDT.Size = new System.Drawing.Size(70, 13);
            this.label_SDT.TabIndex = 13;
            this.label_SDT.Text = "Số điện thoại";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBox_SDT);
            this.Controls.Add(this.label_SDT);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_DangKy);
            this.Controls.Add(this.chkBox_Iagree);
            this.Controls.Add(this.txtBox_email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioBtn_Nu);
            this.Controls.Add(this.radioBtn_Nam);
            this.Controls.Add(this.label_GioiTinh);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label_NTNS);
            this.Controls.Add(this.txtBox_HoVaTen);
            this.Controls.Add(this.label_HoVaTen);
            this.Controls.Add(this.label_FormName);
            this.Name = "Form1";
            this.Text = "Form đăng ký thành viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_FormName;
        private System.Windows.Forms.Label label_HoVaTen;
        private System.Windows.Forms.TextBox txtBox_HoVaTen;
        private System.Windows.Forms.Label label_NTNS;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label_GioiTinh;
        private System.Windows.Forms.RadioButton radioBtn_Nam;
        private System.Windows.Forms.RadioButton radioBtn_Nu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_email;
        private System.Windows.Forms.CheckBox chkBox_Iagree;
        private System.Windows.Forms.Button btn_DangKy;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.TextBox txtBox_SDT;
        private System.Windows.Forms.Label label_SDT;
    }
}

