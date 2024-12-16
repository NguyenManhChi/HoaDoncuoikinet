using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace HoaDon
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=NGUYE\\MANHCHI;Initial Catalog=netcuoiki;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
            // Thêm các bảng vào ComboBox
            comboBoxTables.Items.Add("HoaDonBanHang");
            comboBoxTables.Items.Add("NhapKho");
            comboBoxTables.Items.Add("XuatKho");
            comboBoxTables.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnchon_Click(object sender, EventArgs e)
        {
            // Lấy tên bảng từ ComboBox
            string selectedTable = comboBoxTables.SelectedItem.ToString();

            // Hiển thị dữ liệu của bảng được chọn
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = $"SELECT * FROM {selectedTable}"; // Truy vấn bảng
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Hiển thị dữ liệu lên DataGridView
                    dataGridView1.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
            }

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string selectedTable = comboBoxTables.SelectedItem.ToString();

            // Lấy mã hóa đơn từ TextBox
            string maHoaDon = txttimkiem.Text.Trim();

            if (string.IsNullOrEmpty(maHoaDon))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Truy vấn dữ liệu dựa trên mã hóa đơn
                    string query = $"SELECT * FROM {selectedTable} WHERE maHoaDon = @maHoaDon";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@maHoaDon", maHoaDon);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Kiểm tra nếu không có dữ liệu trả về
                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Hiển thị dữ liệu trên DataGridView
                    dataGridView1.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}");
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Bạn có chắc chắn muốn thoát không?", // Nội dung thông báo
        "Xác nhận thoát",                     // Tiêu đề
        MessageBoxButtons.YesNo,              // Các nút lựa chọn
        MessageBoxIcon.Question);             // Biểu tượng câu hỏi

            // Nếu người dùng chọn "Yes", thoát ứng dụng
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Thoát ứng dụng
            }
        }




        private void btnkhoitao_Click(object sender, EventArgs e)
        {
            txttimkiem.Clear();

            // Reset the ComboBox to the first item
            comboBoxTables.SelectedIndex = 0;

            // Clear the DataGridView
            dataGridView1.DataSource = null;
        }

        private void btnloc_Click(object sender, EventArgs e)
        {
            string selectedTable = comboBoxTables.SelectedItem.ToString();

            // Get the start and end dates from the TextBoxes
            string startDateStr = txtbatdau.Text.Trim();
            string endDateStr = txtketthuc.Text.Trim();

            // Check if the start and end date fields are not empty
            if (string.IsNullOrEmpty(startDateStr) || string.IsNullOrEmpty(endDateStr))
            {
                MessageBox.Show("Vui lòng nhập cả khoảng thời gian!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Try to parse the dates
            DateTime startDate, endDate;
            if (!DateTime.TryParse(startDateStr, out startDate) || !DateTime.TryParse(endDateStr, out endDate))
            {
                MessageBox.Show("Ngày nhập không hợp lệ. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the start date is earlier than the end date
            if (startDate > endDate)
            {
                MessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "";
                    string dateColumn = ""; // This will store the name of the date column depending on the selected table.

                    // Adjust the query based on the selected table and the correct date column
                    if (selectedTable == "HoaDonBanHang")
                    {
                        dateColumn = "ngayMua";
                        query = $"SELECT * FROM HoaDonBanHang WHERE {dateColumn} >= @startDate AND {dateColumn} <= @endDate";
                    }
                    else if (selectedTable == "NhapKho")
                    {
                        dateColumn = "ngayNhap";
                        query = $"SELECT * FROM NhapKho WHERE {dateColumn} >= @startDate AND {dateColumn} <= @endDate";
                    }
                    else if (selectedTable == "XuatKho")
                    {
                        dateColumn = "ngayMua";
                        query = $"SELECT * FROM XuatKho WHERE {dateColumn} >= @startDate AND {dateColumn} <= @endDate";
                    }

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Check if there is any data returned
                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu trong khoảng thời gian đã chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Display the data in the DataGridView
                    dataGridView1.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi lọc dữ liệu: {ex.Message}");
                }
            }
        }
    }
}