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

namespace WindowsFormsApp1
{
    public partial class fSubject : Form
    {
        public fSubject()
        {
            InitializeComponent();
        }

        private void fSubject_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }

        //tạo biến truy vấn tới sql sever
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LRF7KCL;Initial Catalog=QL_DiemSinhVien;Integrated Security=True");

        SqlCommand cmd;
        SqlDataAdapter adapt;

        //Xây dựng hàm truy xuất dữ liệu sql để hiện thị ra datagridView
        public void HienThiDuLieu()
        {
            conn.Open();
            String sqlSELECT = "SELECT *FROM MonHoc";
            cmd = new SqlCommand(sqlSELECT, conn);
            adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            conn.Close();
            dsMH.DataSource = dt;
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            if (txtMaMH.Text != "" && txtTenMH.Text != "")
            {
                cmd = new SqlCommand("insert into MonHoc(MAMH,TENMH) " +
                    "values(@MAMH,@TENMH)", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@MAMH", txtMaMH.Text);
                cmd.Parameters.AddWithValue("@TENMH", txtTenMH.Text);
              
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Thêm môn học thành công!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin môn học!");
            }
        }

        //Hiển thi dữ liệu khi thêm nhân viên 
        private void DisplayData()
        {
            conn.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from MonHoc", conn);
            adapt.Fill(dt);
            dsMH.DataSource = dt;
            conn.Close();
        }

        //hàm xóa dữ liệu
        private void ClearData()
        {
            txtMaMH.Text = "";
            txtTenMH.Text = "";
        }

        private void btnUpdateSuject_Click(object sender, EventArgs e)
        {
            if (txtMaMH.Text != "" && txtTenMH.Text != "")

            {
                cmd = new SqlCommand("update MonHoc set MAMH=@MAMH,TENMH=@TENMH where MAMH=@MAMH", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@MAMH", txtMaMH.Text);
                cmd.Parameters.AddWithValue("@TENMH", txtTenMH.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhập dữ liệu thành công!");
                conn.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Xin vui lòng nhập mã môn học và tên môn học muốn cập nhật!");
            }
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            if (txtMaMH.Text != "")
            {
                cmd = new SqlCommand("delete MonHoc where MAMH=@MAMH", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@MAMH", txtMaMH.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Dữ liệu đã được xóa!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Xin vui lòng nhập mã môn học muốn xóa!");
            }
        }
    }
}
