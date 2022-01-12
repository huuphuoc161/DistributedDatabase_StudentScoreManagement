namespace WindowsFormsApp1
{
    partial class fSheetSroce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSheetSroce));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbMaSV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrintSheetSroce = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbMaSV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 32);
            this.panel1.TabIndex = 0;
            // 
            // cbMaSV
            // 
            this.cbMaSV.FormattingEnabled = true;
            this.cbMaSV.Location = new System.Drawing.Point(85, 4);
            this.cbMaSV.Name = "cbMaSV";
            this.cbMaSV.Size = new System.Drawing.Size(121, 21);
            this.cbMaSV.TabIndex = 0;
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
            // btnPrintSheetSroce
            // 
            this.btnPrintSheetSroce.Location = new System.Drawing.Point(85, 76);
            this.btnPrintSheetSroce.Name = "btnPrintSheetSroce";
            this.btnPrintSheetSroce.Size = new System.Drawing.Size(91, 23);
            this.btnPrintSheetSroce.TabIndex = 1;
            this.btnPrintSheetSroce.Text = "In phiếu điểm";
            this.btnPrintSheetSroce.UseVisualStyleBackColor = true;
            this.btnPrintSheetSroce.Click += new System.EventHandler(this.btnPrintSheetSroce_Click);
            // 
            // fSheetSroce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 120);
            this.Controls.Add(this.btnPrintSheetSroce);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fSheetSroce";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In phiếu điểm";
            this.Load += new System.EventHandler(this.fSheetSroce_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbMaSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrintSheetSroce;
    }
}