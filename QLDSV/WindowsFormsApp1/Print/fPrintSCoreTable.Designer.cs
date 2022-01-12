namespace WindowsFormsApp1
{
    partial class fPrintSCoreTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPrintSCoreTable));
            this.btnPrintSroceTable = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbMaMH = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbTenLop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbLanThi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrintSroceTable
            // 
            this.btnPrintSroceTable.Location = new System.Drawing.Point(119, 137);
            this.btnPrintSroceTable.Name = "btnPrintSroceTable";
            this.btnPrintSroceTable.Size = new System.Drawing.Size(89, 23);
            this.btnPrintSroceTable.TabIndex = 4;
            this.btnPrintSroceTable.Text = "In danh sách";
            this.btnPrintSroceTable.UseVisualStyleBackColor = true;
            this.btnPrintSroceTable.Click += new System.EventHandler(this.btnPrintSroceTable_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbMaMH);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(30, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 32);
            this.panel2.TabIndex = 2;
            // 
            // cbMaMH
            // 
            this.cbMaMH.FormattingEnabled = true;
            this.cbMaMH.Location = new System.Drawing.Point(79, 4);
            this.cbMaMH.Name = "cbMaMH";
            this.cbMaMH.Size = new System.Drawing.Size(77, 21);
            this.cbMaMH.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã môn học";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbTenLop);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(30, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 32);
            this.panel1.TabIndex = 1;
            // 
            // cbTenLop
            // 
            this.cbTenLop.FormattingEnabled = true;
            this.cbTenLop.Location = new System.Drawing.Point(79, 3);
            this.cbTenLop.Name = "cbTenLop";
            this.cbTenLop.Size = new System.Drawing.Size(188, 21);
            this.cbTenLop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên lớp";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbLanThi);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(195, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(105, 32);
            this.panel3.TabIndex = 3;
            // 
            // cbLanThi
            // 
            this.cbLanThi.FormattingEnabled = true;
            this.cbLanThi.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbLanThi.Location = new System.Drawing.Point(59, 4);
            this.cbLanThi.Name = "cbLanThi";
            this.cbLanThi.Size = new System.Drawing.Size(43, 21);
            this.cbLanThi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lần Thi";
            // 
            // fPrintSCoreTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 172);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnPrintSroceTable);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fPrintSCoreTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In bảng điểm môn học";
            this.Load += new System.EventHandler(this.fPrintSCoreTable_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrintSroceTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbMaMH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbTenLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbLanThi;
        private System.Windows.Forms.Label label3;
    }
}