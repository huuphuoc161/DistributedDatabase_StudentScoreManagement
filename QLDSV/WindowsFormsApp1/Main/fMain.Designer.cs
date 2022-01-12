namespace WindowsFormsApp1
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.btnNhapDMLop = new System.Windows.Forms.Button();
            this.btnNhapDSSV = new System.Windows.Forms.Button();
            this.btnNhapMH = new System.Windows.Forms.Button();
            this.btnNhapDiem = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNhapDMLop
            // 
            this.btnNhapDMLop.Location = new System.Drawing.Point(28, 14);
            this.btnNhapDMLop.Name = "btnNhapDMLop";
            this.btnNhapDMLop.Size = new System.Drawing.Size(142, 23);
            this.btnNhapDMLop.TabIndex = 0;
            this.btnNhapDMLop.Text = "Nhập danh mục lớp";
            this.btnNhapDMLop.UseVisualStyleBackColor = true;
            this.btnNhapDMLop.Click += new System.EventHandler(this.btnNhapDMLop_Click);
            // 
            // btnNhapDSSV
            // 
            this.btnNhapDSSV.Location = new System.Drawing.Point(28, 53);
            this.btnNhapDSSV.Name = "btnNhapDSSV";
            this.btnNhapDSSV.Size = new System.Drawing.Size(142, 23);
            this.btnNhapDSSV.TabIndex = 1;
            this.btnNhapDSSV.Text = "Nhập danh sách sinh viên";
            this.btnNhapDSSV.UseVisualStyleBackColor = true;
            this.btnNhapDSSV.Click += new System.EventHandler(this.btnNhapDSSV_Click);
            // 
            // btnNhapMH
            // 
            this.btnNhapMH.Location = new System.Drawing.Point(28, 92);
            this.btnNhapMH.Name = "btnNhapMH";
            this.btnNhapMH.Size = new System.Drawing.Size(142, 23);
            this.btnNhapMH.TabIndex = 2;
            this.btnNhapMH.Text = "Nhập môn học";
            this.btnNhapMH.UseVisualStyleBackColor = true;
            this.btnNhapMH.Click += new System.EventHandler(this.btnNhapMH_Click);
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.Location = new System.Drawing.Point(28, 130);
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.Size = new System.Drawing.Size(142, 23);
            this.btnNhapDiem.TabIndex = 3;
            this.btnNhapDiem.Text = "Nhập điểm";
            this.btnNhapDiem.UseVisualStyleBackColor = true;
            this.btnNhapDiem.Click += new System.EventHandler(this.btnNhapDiem_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(28, 207);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(142, 23);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(28, 168);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(142, 23);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "In danh sách và phiếu";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 257);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnNhapDiem);
            this.Controls.Add(this.btnNhapMH);
            this.Controls.Add(this.btnNhapDSSV);
            this.Controls.Add(this.btnNhapDMLop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMain_FormClosing);
            this.Load += new System.EventHandler(this.fMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNhapDMLop;
        private System.Windows.Forms.Button btnNhapDSSV;
        private System.Windows.Forms.Button btnNhapMH;
        private System.Windows.Forms.Button btnNhapDiem;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnPrint;
    }
}