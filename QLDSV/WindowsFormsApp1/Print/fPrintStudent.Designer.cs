namespace WindowsFormsApp1
{
    partial class fPrintStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPrintStudent));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbMK = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbMaLop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrintStuList = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbMK);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(51, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 32);
            this.panel1.TabIndex = 0;
            // 
            // cbMK
            // 
            this.cbMK.FormattingEnabled = true;
            this.cbMK.Location = new System.Drawing.Point(57, 4);
            this.cbMK.Name = "cbMK";
            this.cbMK.Size = new System.Drawing.Size(121, 21);
            this.cbMK.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khoa";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbMaLop);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(51, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 32);
            this.panel2.TabIndex = 1;
            // 
            // cbMaLop
            // 
            this.cbMaLop.FormattingEnabled = true;
            this.cbMaLop.Location = new System.Drawing.Point(57, 4);
            this.cbMaLop.Name = "cbMaLop";
            this.cbMaLop.Size = new System.Drawing.Size(121, 21);
            this.cbMaLop.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã lớp";
            // 
            // btnPrintStuList
            // 
            this.btnPrintStuList.Location = new System.Drawing.Point(108, 132);
            this.btnPrintStuList.Name = "btnPrintStuList";
            this.btnPrintStuList.Size = new System.Drawing.Size(89, 23);
            this.btnPrintStuList.TabIndex = 3;
            this.btnPrintStuList.Text = "In danh sách";
            this.btnPrintStuList.UseVisualStyleBackColor = true;
            this.btnPrintStuList.Click += new System.EventHandler(this.btnPrintStuList_Click);
            // 
            // fPrintStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 179);
            this.Controls.Add(this.btnPrintStuList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fPrintStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In danh sách sinh viên";
            this.Load += new System.EventHandler(this.fPrintStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbMK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbMaLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrintStuList;
    }
}