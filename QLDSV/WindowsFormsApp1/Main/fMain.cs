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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        //khai baso biến static để kiểm tra tài khoản
        public static String username = String.Empty;

        private void fMain_Load(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnNhapDMLop_Click(object sender, EventArgs e)
        {
            if (username != "user1")
            {
                fClass f = new fClass();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnNhapDSSV_Click(object sender, EventArgs e)
        {
            fStudent f = new fStudent();
            this.Hide();
            f.ShowDialog();
            this.Show();
            
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            // xác nhận xem có phải user admin không?
            if (!String.IsNullOrEmpty(username))
            {
                if (username != "user1")
                {
                    fSroce f = new fSroce();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền truy cập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            
        }

        private void btnNhapMH_Click(object sender, EventArgs e)
        {
            // xác nhận xem có phải user admin không?
            if (!String.IsNullOrEmpty(username))
            {
                if (username != "user1")
                {
                    fSubject f = new fSubject();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền truy cập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            fPrint f = new fPrint();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
