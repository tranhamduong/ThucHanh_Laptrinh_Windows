namespace ADO.NET_WindowsForm
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
            this.myDataGridView = new System.Windows.Forms.DataGridView();
            this.comboBoxDSPhongBan = new System.Windows.Forms.ComboBox();
            this.labelPhongBan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.myDataNQL = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // myDataGridView
            // 
            this.myDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDataGridView.Location = new System.Drawing.Point(49, 51);
            this.myDataGridView.Name = "myDataGridView";
            this.myDataGridView.ReadOnly = true;
            this.myDataGridView.Size = new System.Drawing.Size(714, 237);
            this.myDataGridView.TabIndex = 0;
            // 
            // comboBoxDSPhongBan
            // 
            this.comboBoxDSPhongBan.FormattingEnabled = true;
            this.comboBoxDSPhongBan.Location = new System.Drawing.Point(49, 330);
            this.comboBoxDSPhongBan.Name = "comboBoxDSPhongBan";
            this.comboBoxDSPhongBan.Size = new System.Drawing.Size(348, 21);
            this.comboBoxDSPhongBan.TabIndex = 1;
            this.comboBoxDSPhongBan.SelectedIndexChanged += new System.EventHandler(this.comboBoxDSPhongBan_SelectedIndexChanged);
            // 
            // labelPhongBan
            // 
            this.labelPhongBan.AutoSize = true;
            this.labelPhongBan.Location = new System.Drawing.Point(49, 311);
            this.labelPhongBan.Name = "labelPhongBan";
            this.labelPhongBan.Size = new System.Drawing.Size(129, 13);
            this.labelPhongBan.TabIndex = 2;
            this.labelPhongBan.Text = "Phân loại theo phòng ban";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Phân loại theo người quản lý";
            // 
            // myDataNQL
            // 
            this.myDataNQL.FormattingEnabled = true;
            this.myDataNQL.Location = new System.Drawing.Point(49, 409);
            this.myDataNQL.Name = "myDataNQL";
            this.myDataNQL.Size = new System.Drawing.Size(348, 21);
            this.myDataNQL.TabIndex = 3;
            this.myDataNQL.SelectedIndexChanged += new System.EventHandler(this.myDataNQL_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(162, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(467, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "PHẦN MỀM QUẢN LÝ NHÂN VIÊN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 587);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myDataNQL);
            this.Controls.Add(this.labelPhongBan);
            this.Controls.Add(this.comboBoxDSPhongBan);
            this.Controls.Add(this.myDataGridView);
            this.Name = "Form1";
            this.Text = "PHẦN MỀM QUẢN LÝ NHÂN VIÊN";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView myDataGridView;
        private System.Windows.Forms.ComboBox comboBoxDSPhongBan;
        private System.Windows.Forms.Label labelPhongBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox myDataNQL;
        private System.Windows.Forms.Label label2;
    }
}

