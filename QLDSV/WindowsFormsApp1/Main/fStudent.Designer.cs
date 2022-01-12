namespace WindowsFormsApp1
{
    partial class fStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStudent));
            this.dsSV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbPhai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cbNghiHoc = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsSV)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsSV
            // 
            this.dsSV.AllowUserToOrderColumns = true;
            this.dsSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsSV.Location = new System.Drawing.Point(2, 212);
            this.dsSV.Name = "dsSV";
            this.dsSV.Size = new System.Drawing.Size(569, 164);
            this.dsSV.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMaSV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(44, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 31);
            this.panel1.TabIndex = 1;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(97, 3);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(99, 20);
            this.txtMaSV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtHo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(44, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 31);
            this.panel2.TabIndex = 2;
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(97, 3);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(99, 20);
            this.txtHo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTen);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(44, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(202, 31);
            this.panel3.TabIndex = 3;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(97, 6);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(99, 20);
            this.txtTen.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtMaLop);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(43, 123);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(202, 31);
            this.panel4.TabIndex = 4;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(98, 3);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(99, 20);
            this.txtMaLop.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã lớp";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbPhai);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(43, 160);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(202, 31);
            this.panel5.TabIndex = 5;
            // 
            // cbPhai
            // 
            this.cbPhai.FormattingEnabled = true;
            this.cbPhai.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cbPhai.Location = new System.Drawing.Point(98, 3);
            this.cbPhai.Name = "cbPhai";
            this.cbPhai.Size = new System.Drawing.Size(99, 21);
            this.cbPhai.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phái";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dtNgaySinh);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(301, 11);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(202, 31);
            this.panel6.TabIndex = 6;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Location = new System.Drawing.Point(97, 3);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(100, 20);
            this.dtNgaySinh.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày sinh";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtNoiSinh);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(301, 49);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(202, 31);
            this.panel7.TabIndex = 7;
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Location = new System.Drawing.Point(97, 3);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(100, 20);
            this.txtNoiSinh.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nơi sinh";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtDiaChi);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(301, 86);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(202, 31);
            this.panel8.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(97, 6);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(100, 20);
            this.txtDiaChi.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Địa chỉ";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cbNghiHoc);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Location = new System.Drawing.Point(301, 123);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(202, 31);
            this.panel9.TabIndex = 9;
            // 
            // cbNghiHoc
            // 
            this.cbNghiHoc.FormattingEnabled = true;
            this.cbNghiHoc.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cbNghiHoc.Location = new System.Drawing.Point(97, 7);
            this.cbNghiHoc.Name = "cbNghiHoc";
            this.cbNghiHoc.Size = new System.Drawing.Size(100, 21);
            this.cbNghiHoc.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nghỉ học";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(301, 167);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(55, 23);
            this.btnAddStudent.TabIndex = 10;
            this.btnAddStudent.Text = "Thêm";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(443, 167);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(55, 23);
            this.btnDeleteStudent.TabIndex = 12;
            this.btnDeleteStudent.Text = "Xóa";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Location = new System.Drawing.Point(374, 167);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(55, 23);
            this.btnUpdateStudent.TabIndex = 11;
            this.btnUpdateStudent.Text = "Sửa";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // fStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 377);
            this.Controls.Add(this.btnUpdateStudent);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dsSV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách sinh viên";
            this.Load += new System.EventHandler(this.fStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dsSV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbPhai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtNoiSinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox cbNghiHoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
    }
}