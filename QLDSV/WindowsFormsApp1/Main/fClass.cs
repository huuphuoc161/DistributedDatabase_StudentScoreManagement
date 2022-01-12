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
    public partial class fClass : Form
    {
        public fClass()
        {
            InitializeComponent();
        }


        //tạo biến truy vấn tới sql sever
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LRF7KCL;Initial Catalog=QL_DiemSinhVien1;Integrated Security=True");

        SqlCommand cmd;
        SqlDataAdapter adapt;

        //Xây dựng hàm truy xuất dữ liệu sql để hiện thị ra datagridView
        public void HienThiDuLieu()
        {
            String sqlSELECT = "SELECT *FROM Lop";
            cmd = new SqlCommand(sqlSELECT, conn);
            adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dsLop.DataSource = dt; 
        }

        //đưa dữ liệu vào cb mã khoa
        public void loadCombobox()
        {
            cmd = new SqlCommand("SELECT MAKH FROM KHOA", conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbMaKhoa.DisplayMember = "MAKH";
            cbMaKhoa.DataSource = dt;
        }

        private void fClass_Load(object sender, EventArgs e)
        {
            conn.Open();
            HienThiDuLieu();
            loadCombobox();
            conn.Close();
        }

        //sự kiện thêm lớp
        private void btnAddClass_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text != "" && txtTenLop.Text != "" && cbMaKhoa.Text != "")
            {
                cmd = new SqlCommand("insert into LOP(MALOP,TENLOP,MAKH) " +
                    "values(@MALOP,@TENLOP,@MAKH)", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@MALOP", txtMaLop.Text);
                cmd.Parameters.AddWithValue("@TENLOP", txtTenLop.Text);
                cmd.Parameters.AddWithValue("@MAKH", cbMaKhoa.Text);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Thêm thành công!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Xin vui lòng nhập đầy đủ thông tin của lớp!");
            }
        }


        //Hiển thi dữ liệu khi thêm nhân viên 
        private void DisplayData()
        {
            conn.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from LOP", conn);
            adapt.Fill(dt);
            dsLop.DataSource = dt;
            conn.Close();
        }

        //hàm xóa dữ liệu
        private void ClearData()
        {
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            cbMaKhoa.Text = "";
        }

        private void btnEditClass_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text != "" && txtTenLop.Text != "" && cbMaKhoa.Text != "")

            {
                cmd = new SqlCommand("update LOP set TENLOP=@TENLOP,MAKH=@MAKH WHERE MALOP = @MALOP", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@MALOP", txtMaLop.Text);
                cmd.Parameters.AddWithValue("@TENLOP", txtTenLop.Text);
                cmd.Parameters.AddWithValue("@MAKH", cbMaKhoa.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhập dữ liệu thành công!");
                conn.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Xin vui lòng nhập đầy đủ thông tin của lớp!");
            }
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text != "" && txtTenLop.Text != "" && cbMaKhoa.Text != "")
            {
                cmd = new SqlCommand("delete LOP where MALOP=@MALOP", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@MALOP", txtMaLop.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Dữ liệu đã được xóa!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Xin vui lòng điền thông tin của lớp muốn xóa!");
            }
        }

        
    }
}
