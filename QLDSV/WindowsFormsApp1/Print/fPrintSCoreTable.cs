﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class fPrintSCoreTable : Form
    {
        public fPrintSCoreTable()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LRF7KCL;Initial Catalog=QL_DiemSinhVien1;Integrated Security=True");

        SqlCommand cmd;
        SqlDataAdapter adapt;

        //đưa dữ liệu vào cb Tên lớp
        public void loadComboboxTenLop()
        {
            conn.Open();
            cmd = new SqlCommand("SELECT TENLOP FROM Lop", conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbTenLop.DisplayMember = "TENLOP";
            cbTenLop.DataSource = dt;
            conn.Close();
        }

        //đưa dữ liệu vào cb tên môn học
        public void loadComboboxMaMH()
        {
            conn.Open();
            cmd = new SqlCommand("SELECT MaMH FROM MonHoc", conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbMaMH.DisplayMember = "MAMH";
            cbMaMH.DataSource = dt;
            conn.Close();
        }

        
        private void fPrintSCoreTable_Load(object sender, EventArgs e)
        {
            loadComboboxTenLop();
            loadComboboxMaMH();
        }

        DataTable MakeDataTable()
        {
          
            //tạo datatable
            conn.Open();
            String sqlSELECT = "SELECT d.MASV,s.HO,s.TEN,d.DIEM,d.MAMH FROM DIEM d,SinhVien s where s.MASV = d.MASV ";
            cmd = new SqlCommand(sqlSELECT, conn);
            adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            // thêm cột stt 
            DataColumn workCol = dt.Columns.Add("STT", typeof(int));

            adapt.Fill(dt);
            conn.Close();

            // tạo datatable có trùn mã lớp
            // Chuỗi biểu thức lọc ra các nhân viên nam có năm sinh lớn hơn 1985
            string stringExpression = "MaMH = '" + cbMaMH.Text + "'";
            //Dữ liệu lọc ra là một mảng các đối tượng DataRow
            DataRow[] rows = dt.Select(stringExpression);
            //Chuyển đổi các dòng dữ liệu rows thành DataTable với method CopyToDataTable()
            DataTable filterData = rows.CopyToDataTable();
            // Hiển thị dữ liệu đã được lọc ra
            dt = filterData;

            // tạo biến đếm cho cột STT
            int num = rows.Length;

            for (int i = 1; i <= num; i++)
            {
                dt.Rows[i - 1]["STT"] = i;
            }

            dt.Columns.Remove("MAMH");
            return dt;
        }

        void ExportDataTableToPdf(DataTable dtblTable, String strPdfPath, string strHeader)
        {
            System.IO.FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            //Report Header
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);


            iTextSharp.text.Font fntHead = new iTextSharp.text.Font(bfntHead, 16, 1);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk(strHeader.ToUpper(), fntHead));
            document.Add(prgHeading);

            //Author
            Paragraph prgAuthor = new Paragraph();
            BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntAuthor = new iTextSharp.text.Font(btnAuthor, 8, 2);
            prgAuthor.Alignment = Element.ALIGN_RIGHT;
            prgAuthor.Add(new Chunk("From : VP GROUP", fntAuthor));
            prgAuthor.Add(new Chunk("\nDate : " + DateTime.Now.ToShortDateString(), fntAuthor));
            document.Add(prgAuthor);

            //Add a line seperation
            Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, null, Element.ALIGN_LEFT, 1)));
            document.Add(p);

            //Add line break
            document.Add(new Chunk("\n", fntHead));

            //Write the table
            PdfPTable table = new PdfPTable(dtblTable.Columns.Count);
            //Table header
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntColumnHeader = new iTextSharp.text.Font(btnColumnHeader, 10, 1);
            for (int i = 0; i < dtblTable.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                //cell.BackgroundColor = Color.DarkGray;
                cell.AddElement(new Chunk(dtblTable.Columns[i].ColumnName.ToUpper(), fntColumnHeader));
                table.AddCell(cell);
            }
            //table Data
            for (int i = 0; i < dtblTable.Rows.Count; i++)
            {
                for (int j = 0; j < dtblTable.Columns.Count; j++)
                {
                    table.AddCell(dtblTable.Rows[i][j].ToString());
                }
            }

            document.Add(table);
            document.Close();
            writer.Close();
            fs.Close();
        }

        private void btnPrintStuList_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtbl = MakeDataTable();
                ExportDataTableToPdf(dtbl, @"F:\HK1-2019-2020\CSDLPT\Đồ án\pdf file\DSSV.pdf", "Danh sách sinh viên");
                // Hiển thị file pdf
                System.Diagnostics.Process.Start(@"F:\HK1-2019-2020\CSDLPT\Đồ án\pdf file\DSSV.pdf");
                this.WindowState = System.Windows.Forms.FormWindowState.Minimized;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Đã có lỗi khi in");
            }
        }

        // sự kiện bấm nút in

        private void btnPrintSroceTable_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtbl = MakeDataTable();
                ExportDataTableToPdf(dtbl, @"F:\HK1-2019-2020\CSDLPT\Đồ án\pdf file\BangDiem.pdf", "BANG DIEM");
                // Hiển thị file pdf
                System.Diagnostics.Process.Start(@"F:\HK1-2019-2020\CSDLPT\Đồ án\pdf file\BangDiem.pdf");
                this.WindowState = System.Windows.Forms.FormWindowState.Minimized;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Đã có lỗi khi in");
            }
        }

        
    }
}
