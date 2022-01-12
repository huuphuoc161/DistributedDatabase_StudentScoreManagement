namespace WindowsFormsApp1
{
    partial class fPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPrint));
            this.btnPrintStudent = new System.Windows.Forms.Button();
            this.btnPrintScoreTable = new System.Windows.Forms.Button();
            this.btnPrintSheetScore = new System.Windows.Forms.Button();
            this.btnPrintTotalSroce = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrintStudent
            // 
            this.btnPrintStudent.Location = new System.Drawing.Point(30, 28);
            this.btnPrintStudent.Name = "btnPrintStudent";
            this.btnPrintStudent.Size = new System.Drawing.Size(132, 23);
            this.btnPrintStudent.TabIndex = 1;
            this.btnPrintStudent.Text = "In danh sách sinh viên";
            this.btnPrintStudent.UseVisualStyleBackColor = true;
            this.btnPrintStudent.Click += new System.EventHandler(this.btnPrintStudent_Click);
            // 
            // btnPrintScoreTable
            // 
            this.btnPrintScoreTable.Location = new System.Drawing.Point(30, 66);
            this.btnPrintScoreTable.Name = "btnPrintScoreTable";
            this.btnPrintScoreTable.Size = new System.Drawing.Size(132, 23);
            this.btnPrintScoreTable.TabIndex = 2;
            this.btnPrintScoreTable.Text = "In bảng điểm môn học";
            this.btnPrintScoreTable.UseVisualStyleBackColor = true;
            this.btnPrintScoreTable.Click += new System.EventHandler(this.btnPrintScoreTable_Click);
            // 
            // btnPrintSheetScore
            // 
            this.btnPrintSheetScore.Location = new System.Drawing.Point(30, 105);
            this.btnPrintSheetScore.Name = "btnPrintSheetScore";
            this.btnPrintSheetScore.Size = new System.Drawing.Size(132, 23);
            this.btnPrintSheetScore.TabIndex = 3;
            this.btnPrintSheetScore.Text = "In phiếu điểm";
            this.btnPrintSheetScore.UseVisualStyleBackColor = true;
            this.btnPrintSheetScore.Click += new System.EventHandler(this.btnPrintSheetScore_Click);
            // 
            // btnPrintTotalSroce
            // 
            this.btnPrintTotalSroce.Location = new System.Drawing.Point(30, 146);
            this.btnPrintTotalSroce.Name = "btnPrintTotalSroce";
            this.btnPrintTotalSroce.Size = new System.Drawing.Size(132, 23);
            this.btnPrintTotalSroce.TabIndex = 4;
            this.btnPrintTotalSroce.Text = "In bảng điểm tổng kết";
            this.btnPrintTotalSroce.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrintTotalSroce.UseVisualStyleBackColor = true;
            this.btnPrintTotalSroce.Click += new System.EventHandler(this.btnPrintTotalSroce_Click);
            // 
            // fPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 197);
            this.Controls.Add(this.btnPrintTotalSroce);
            this.Controls.Add(this.btnPrintSheetScore);
            this.Controls.Add(this.btnPrintScoreTable);
            this.Controls.Add(this.btnPrintStudent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In danh sách và phiếu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrintStudent;
        private System.Windows.Forms.Button btnPrintScoreTable;
        private System.Windows.Forms.Button btnPrintSheetScore;
        private System.Windows.Forms.Button btnPrintTotalSroce;
    }
}