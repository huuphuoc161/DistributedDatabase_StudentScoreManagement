namespace WindowsFormsApp1
{
    partial class fTotalSroce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTotalSroce));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbTenLop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrintSroceTable = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbTenLop);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(30, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 32);
            this.panel1.TabIndex = 1;
            // 
            // cbTenLop
            // 
            this.cbTenLop.FormattingEnabled = true;
            this.cbTenLop.Location = new System.Drawing.Point(79, 4);
            this.cbTenLop.Name = "cbTenLop";
            this.cbTenLop.Size = new System.Drawing.Size(175, 21);
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
            // btnPrintSroceTable
            // 
            this.btnPrintSroceTable.Location = new System.Drawing.Point(97, 76);
            this.btnPrintSroceTable.Name = "btnPrintSroceTable";
            this.btnPrintSroceTable.Size = new System.Drawing.Size(127, 23);
            this.btnPrintSroceTable.TabIndex = 2;
            this.btnPrintSroceTable.Text = "In bảng điểm tổng kết";
            this.btnPrintSroceTable.UseVisualStyleBackColor = true;
            this.btnPrintSroceTable.Click += new System.EventHandler(this.btnPrintSroceTable_Click);
            // 
            // fTotalSroce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 111);
            this.Controls.Add(this.btnPrintSroceTable);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fTotalSroce";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fTotalSroce";
            this.Load += new System.EventHandler(this.fTotalSroce_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbTenLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrintSroceTable;
    }
}