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
    public partial class fStudent : Form
    {
        public fStudent()
        {
            InitializeComponent();
        }

        //tạo biến truy vấn tới sql sever
        SqlConnection conn  = new SqlConnection(@"Data Source=DESKTOP-LRF7KCL;Initial Catalog=QL_DiemSinhVien;Integrated Security=True");

        SqlCommand cmd;
        SqlDataAdapter adapt;

        //Xây dựng hàm truy xuất dữ liệu sql để hiện thị ra datagridView
        public void HienThiDuLieu()
        {
            conn.Open();
            String sqlSELECT = "SELECT *FROM SinhVien";
            cmd = new SqlCommand(sqlSELECT, conn);
            adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            conn.Close();
            dsSV.DataSource = dt;
        }
      
        private void fStudent_Load(object sender, EventArgs e)
        {
            
            HienThiDuLieu();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text != "" && txtHo.Text != "" && txtTen.Text != "" && txtMaLop.Text != "" && txtNoiSinh.Text != "" && cbPhai.Text != "" && dtNgaySinh.Text != "" && txtDiaChi.Text != "" && cbNghiHoc.Text != "")
            {
                cmd = new SqlCommand("insert into SinhVien(MASV,HO,TEN,MALOP,PHAI,NGAYSINH,NOISINH,DIACHI,NGHIHOC) " +
                    "values(@MASV,@HO,@TEN,@MALOP,@PHAI,@NGAYSINH,@NOISINH,@DIACHI,@NGHIHOC)", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@MASV", txtMaSV.Text);
                cmd.Parameters.AddWithValue("@HO", txtHo.Text);
                cmd.Parameters.AddWithValue("@TEN", txtTen.Text);
                cmd.Parameters.AddWithValue("@MALOP", txtMaLop.Text);
                cmd.Parameters.AddWithValue("@PHAI", cbPhai.Text);
                cmd.Parameters.AddWithValue("@NGAYSINH", DateTime.Parse(dtNgaySinh.Text));
                cmd.Parameters.AddWithValue("@NOISINH", txtNoiSinh.Text);
                cmd.Parameters.AddWithValue("@DIACHI", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@NGHIHOC", cbNghiHoc.Text);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Thêm thành công!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin của sinh viên!");
            }
        }

        //Hiển thi dữ liệu khi thêm nhân viên 
        private void DisplayData()
        {
            conn.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from SinhVien", conn);
            adapt.Fill(dt);
            dsSV.DataSource = dt;
            conn.Close();
        }

        //hàm xóa dữ liệu
        private void ClearData()
        {
            txtMaSV.Text = "";
            txtHo.Text = "";
            txtTen.Text = "";
            txtMaLop.Text = "";
            txtDiaChi.Text = "";
            txtNoiSinh.Text = "";
            cbPhai.Text = "";
            cbNghiHoc.Text = "";
        }


        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text != ""   && txtMaLop.Text != "")
            {
                cmd = new SqlCommand("update SinhVien set MASV=@MASV,HO=@HO,TEN=@TEN,MALOP=@MALOP,PHAI=@PHAI,NGAYSINH=@NGAYSINH,NOISINH=@NOISINH,DIACHI=@DIACHI,NGHIHOC=@NGHIHOC where MASV=@MASV", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@MASV", txtMaSV.Text);
                cmd.Parameters.AddWithValue("@HO", txtHo.Text);
                cmd.Parameters.AddWithValue("@TEN", txtTen.Text);
                cmd.Parameters.AddWithValue("@MALOP", txtMaLop.Text);
                cmd.Parameters.AddWithValue("@PHAI", cbPhai.Text);
                cmd.Parameters.AddWithValue("@NGAYSINH", DateTime.Parse(dtNgaySinh.Text));
                cmd.Parameters.AddWithValue("@NOISINH", txtNoiSinh.Text);
                cmd.Parameters.AddWithValue("@DIACHI", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@NGHIHOC", cbNghiHoc.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhập dữ liệu thành công!");
                conn.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Xin vui lòng nhập mã sinh viên và mã lớp của sinh viên muốn cập nhật!");
            }
        }


        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text != "" && txtHo.Text != "" && txtTen.Text != "" && txtMaLop.Text != "" )
            {
                cmd = new SqlCommand("delete SinhVien where MASV=@MASV", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@MASV", txtMaSV.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Dữ liệu đã được xóa!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Xin vui lòng điền mã sinh viên, họ và tên và mã lớp của sinh viên muốn xóa!");
            }
        }

        
    }
}
