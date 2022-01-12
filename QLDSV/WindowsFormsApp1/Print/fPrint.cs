using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class fPrint : Form
    {
        public fPrint()
        {
            InitializeComponent();
        }

        private void btnPrintStudent_Click(object sender, EventArgs e)
        {
            fPrintStudent f = new fPrintStudent();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnPrintScoreTable_Click(object sender, EventArgs e)
        {
            fPrintSCoreTable f = new fPrintSCoreTable();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnPrintSheetScore_Click(object sender, EventArgs e)
        {
            fSheetSroce f = new fSheetSroce();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnPrintTotalSroce_Click(object sender, EventArgs e)
        {
            fTotalSroce f = new fTotalSroce();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
