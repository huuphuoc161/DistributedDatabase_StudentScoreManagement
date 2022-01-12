using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        //tạo biến kết nối với sql
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LRF7KCL;Initial Catalog=QL_DiemSinhVien1s;Integrated Security=True");


        // sự kiện form closing
        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                
                e.Cancel = true;
            }
        }

        //đóng form
        private void btnExit_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //tạo biến kết nối với sql
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LRF7KCL;Initial Catalog=QL_DiemSinhVien;Integrated Security=True");

            //kết nối với sql
            conn.Open();
            String tk = txtUser.Text;
            String mk = txtPass.Text;
            String sql = "select taiKhoan,matKhau from TaiKhoan where taiKhoan='" + tk + "' and matKhau='" + mk + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dta = cmd.ExecuteReader();
            fMain.username = tk;
            
            //So sánh dữ liệu tài khoản và mật khẩu từ sql với dữ liệu người dùng nhập
            if (dta.Read() == true)
            {
                fMain f = new fMain();
                txtUser.Text = "";
                txtPass.Text = "";
                this.Hide();
                f.ShowDialog();
                this.Show();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng tài khoản và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
