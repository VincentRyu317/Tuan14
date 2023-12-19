using System.Data.SqlClient;
using static WinFormsApp1.Connect;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Connect kn = new Connect();
        SqlConnection connsql;
        private void txt_TenCSDL_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_KetNoi_Click(object sender, EventArgs e)
        {
            TenMay = txt_TenMay.Text;
            TenCSDL = txt_TenCSDL.Text;

            // Kiểm tra xem TextBox có trống không
            if (string.IsNullOrEmpty(TenMay) || string.IsNullOrEmpty(TenCSDL))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            // Tạo chuỗi kết nối
            connectstring = $@"Data Source={TenMay};Initial Catalog={TenCSDL};Integrated Security=True";

            try
            {
                // Sử dụng chuỗi kết nối trong một tác vụ cụ thể, ví dụ: mở kết nối đến CSDL
                using (SqlConnection connection = new SqlConnection(connectstring))
                {
                    connection.Open();
                    MessageBox.Show("Kết nối thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở kết nối: " + ex.Message);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}