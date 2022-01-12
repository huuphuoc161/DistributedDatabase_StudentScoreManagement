namespace WindowsFormsApp1
{
    partial class fSroce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSroce));
            this.dsDiem = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtLanThi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveScore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsDiem)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsDiem
            // 
            this.dsDiem.AllowUserToOrderColumns = true;
            this.dsDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsDiem.Location = new System.Drawing.Point(0, 148);
            this.dsDiem.Name = "dsDiem";
            this.dsDiem.Size = new System.Drawing.Size(439, 150);
            this.dsDiem.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMaSV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 33);
            this.panel1.TabIndex = 1;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(77, 7);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(114, 20);
            this.txtMaSV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtMaMH);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 33);
            this.panel2.TabIndex = 2;
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(77, 7);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(114, 20);
            this.txtMaMH.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã môn học";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtLanThi);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(246, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(193, 33);
            this.panel3.TabIndex = 3;
            // 
            // txtLanThi
            // 
            this.txtLanThi.Location = new System.Drawing.Point(77, 7);
            this.txtLanThi.Name = "txtLanThi";
            this.txtLanThi.Size = new System.Drawing.Size(102, 20);
            this.txtLanThi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lần thi";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtDiem);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(246, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(193, 33);
            this.panel4.TabIndex = 4;
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(65, 7);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(114, 20);
            this.txtDiem.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Điểm";
            // 
            // btnSaveScore
            // 
            this.btnSaveScore.Location = new System.Drawing.Point(197, 119);
            this.btnSaveScore.Name = "btnSaveScore";
            this.btnSaveScore.Size = new System.Drawing.Size(75, 23);
            this.btnSaveScore.TabIndex = 5;
            this.btnSaveScore.Text = "Lưu";
            this.btnSaveScore.UseVisualStyleBackColor = true;
            this.btnSaveScore.Click += new System.EventHandler(this.btnSaveScore_Click);
            // 
            // fSroce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 299);
            this.Controls.Add(this.btnSaveScore);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dsDiem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fSroce";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điểm";
            this.Load += new System.EventHandler(this.fSroce_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsDiem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dsDiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtLanThi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveScore;
    }
}