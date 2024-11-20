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

namespace kt20th11
{
	public partial class Form1 : Form
		
	{
		private string connectionString = "Data Source=DESKTOP-9TAMLUV;Initial Catalog=MobileShop;Integrated Security=True";
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			
			string username = txtUsername.Text.Trim();
			string password = txtPassword.Text.Trim();

			
			if (IsLoginValid(username, password))
			{
				
				MainForm mainForm = new MainForm();
				mainForm.Show();
				this.Hide(); 
			}
			else
			{
				
				MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private bool IsLoginValid(string username, string password)
		{
			bool isValid = false;

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				try
				{
					conn.Open();
					
					string query = "SELECT COUNT(*) FROM NguoiDung WHERE tendangnhap = @username AND matkhau = @password";
					SqlCommand cmd = new SqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@username", username);
					cmd.Parameters.AddWithValue("@password", password);

					
					int result = (int)cmd.ExecuteScalar();

					
					isValid = (result > 0);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
				}
			}

			return isValid;
		}

		private void txtUsername_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


