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
        public Form2(SqlConnection connectionFromPreviousForm)
        {
            InitializeComponent();
            connection = connectionFromPreviousForm;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            connection.Open();

            // Tạo câu truy vấn SQL
            string query = "SELECT * FROM DonVi";

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
    }
}
