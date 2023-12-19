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
using static WinFormsApp1.Form1;
using static WinFormsApp1.Connect;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private SqlConnection connection;
        public static object Rows { get; internal set; }

        public Form2(SqlConnection connectionFromPreviousForm)
        {
            InitializeComponent();
            connection = connectionFromPreviousForm;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            connection.Open();

            // Tạo câu truy vấn SQL
            string query = "SELECT * FROM GV";

            // Tạo đối tượng SqlDataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            // Tạo đối tượng DataTable để chứa dữ liệu
            DataTable dataTable = new DataTable();

            // Đổ dữ liệu từ SqlDataAdapter vào DataTable
            adapter.Fill(dataTable);

            // Gán DataTable làm nguồn dữ liệu cho DataGridView
            dataGridView1.DataSource = dataTable;
            connection.Close();


        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaGv = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string HoTen = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string Sdt = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string GhiChu = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            string MaDonVi = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

            // Hiển thị thông tin
            txt_NhapMaGV.Text = MaGv;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                string sql = "DELETE FROM GV WHERE MaGV = @MaGV";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@MaGV", id);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);

                MessageBox.Show("Xóa câu hỏi thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn câu hỏi cần xóa!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void ccb_CoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ccb_CoSo.Items.Clear();

            connection.Open();

            // Tạo câu truy vấn SQL để lấy dữ liệu từ cột không trùng nhau
            string query = "SELECT DISTINCT MaCoSo FROM DonVi";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Kiểm tra xem có dữ liệu hay không
                    if (reader.HasRows)
                    {
                        // Duyệt qua từng dòng và thêm giá trị vào ComboBox
                        while (reader.Read())
                        {
                            string value = reader["MaCoSo"].ToString();
                            ccb_CoSo.Items.Add(value);
                        }
                    }
                }
            }
            connection.Close();
                if (ccb_CoSo.SelectedIndex != -1)
            {
                // Lấy giá trị của mục được chọn
                string selectedValue = ccb_CoSo.SelectedItem.ToString();

                // Sử dụng giá trị để truy vấn thông tin liên quan từ cơ sở dữ liệu
      
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số để tránh SQL Injection
                        command.Parameters.AddWithValue("@SelectedValue", selectedValue);

                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string value = reader["MaCoSo"].ToString();
                                    ccb_CoSo.Items.Add(value);
                                }
                            }
                        }
                    }
                }
                connection.Close();
            }
        }

        private void ccb_DonVi_SelectedIndexChanged(object sender, EventArgs e)
        {
            ccb_DonVi.Items.Clear();

            connection.Open();

            // Tạo câu truy vấn SQL để lấy dữ liệu từ cột không trùng nhau
            string query = "SELECT DISTINCT MaDonVi FROM GV";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Kiểm tra xem có dữ liệu hay không
                    if (reader.HasRows)
                    {
                        // Duyệt qua từng dòng và thêm giá trị vào ComboBox
                        while (reader.Read())
                        {
                            string value = reader["MaDonVi"].ToString();
                            ccb_DonVi.Items.Add(value);
                        }
                    }
                }
            }
            connection.Close();
        }
    }
}
