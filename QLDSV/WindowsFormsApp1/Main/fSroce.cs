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
    public partial class fSroce : Form
    {
        public fSroce()
        {
            InitializeComponent();
        }

        //tạo biến truy vấn tới sql sever
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LRF7KCL;Initial Catalog=QL_DiemSinhVien;Integrated Security=True");

        SqlCommand cmd;
        SqlDataAdapter adapt;

        //Xây dựng hàm truy xuất dữ liệu sql để hiện thị ra datagridView
        public void HienThiDuLieu()
        {
            conn.Open();
            String sqlSELECT = "SELECT *FROM DIEM";
            cmd = new SqlCommand(sqlSELECT, conn);
            adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            conn.Close();
            dsDiem.DataSource = dt;
        }
        private void fSroce_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }

        private void btnSaveScore_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text != "" && txtMaMH.Text != "" && txtLanThi.Text != "" && txtDiem.Text != "")
            {
                cmd = new SqlCommand("insert into DIEM(MASV,MAMH,LAN,DIEM) " +
                    "values(@MASV,@MAMH,@LAN,@DIEM)", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@MASV", txtMaSV.Text);
                cmd.Parameters.AddWithValue("@MAMH", txtMaMH.Text);
                cmd.Parameters.AddWithValue("@LAN", txtLanThi.Text);
                cmd.Parameters.AddWithValue("@DIEM", txtDiem.Text);
                

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Lưu thành công!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }

        //Hiển thi dữ liệu khi thêm nhân viên 
        private void DisplayData()
        {
            conn.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from DIEM", conn);
            adapt.Fill(dt);
            dsDiem.DataSource = dt;
            conn.Close();
        }

        //hàm xóa dữ liệu
        private void ClearData()
        {
            txtMaSV.Text = "";
            txtMaMH.Text = "";
            txtLanThi.Text = "";
            txtDiem.Text = "";
        }
    }
}
