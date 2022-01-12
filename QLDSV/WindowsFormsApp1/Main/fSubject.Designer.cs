namespace WindowsFormsApp1
{
    partial class fSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSubject));
            this.dsMH = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.btnUpdateSuject = new System.Windows.Forms.Button();
            this.btnDeleteSubject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsMH)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsMH
            // 
            this.dsMH.AllowUserToOrderColumns = true;
            this.dsMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsMH.Location = new System.Drawing.Point(0, 124);
            this.dsMH.Name = "dsMH";
            this.dsMH.Size = new System.Drawing.Size(254, 139);
            this.dsMH.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMaMH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(27, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 31);
            this.panel1.TabIndex = 1;
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(84, 4);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(100, 20);
            this.txtMaMH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã môn học";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTenMH);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(27, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 31);
            this.panel2.TabIndex = 2;
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(84, 4);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(100, 20);
            this.txtTenMH.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên môn học";
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Location = new System.Drawing.Point(33, 95);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(48, 23);
            this.btnAddSubject.TabIndex = 3;
            this.btnAddSubject.Text = "Thêm";
            this.btnAddSubject.UseVisualStyleBackColor = true;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // btnUpdateSuject
            // 
            this.btnUpdateSuject.Location = new System.Drawing.Point(98, 95);
            this.btnUpdateSuject.Name = "btnUpdateSuject";
            this.btnUpdateSuject.Size = new System.Drawing.Size(48, 23);
            this.btnUpdateSuject.TabIndex = 4;
            this.btnUpdateSuject.Text = "Sửa";
            this.btnUpdateSuject.UseVisualStyleBackColor = true;
            this.btnUpdateSuject.Click += new System.EventHandler(this.btnUpdateSuject_Click);
            // 
            // btnDeleteSubject
            // 
            this.btnDeleteSubject.Location = new System.Drawing.Point(163, 95);
            this.btnDeleteSubject.Name = "btnDeleteSubject";
            this.btnDeleteSubject.Size = new System.Drawing.Size(48, 23);
            this.btnDeleteSubject.TabIndex = 5;
            this.btnDeleteSubject.Text = "Xóa";
            this.btnDeleteSubject.UseVisualStyleBackColor = true;
            this.btnDeleteSubject.Click += new System.EventHandler(this.btnDeleteSubject_Click);
            // 
            // fSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 268);
            this.Controls.Add(this.btnDeleteSubject);
            this.Controls.Add(this.btnUpdateSuject);
            this.Controls.Add(this.btnAddSubject);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dsMH);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách môn học";
            this.Load += new System.EventHandler(this.fSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsMH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dsMH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Button btnUpdateSuject;
        private System.Windows.Forms.Button btnDeleteSubject;
    }
}