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
    }
}
