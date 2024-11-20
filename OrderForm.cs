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
	public partial class OrderForm : Form
	{
		private string connectionString = "Data Source=DESKTOP-9TAMLUV;Initial Catalog=MobileShop;Integrated Security=True";
		public OrderForm()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void txtOrderId_Load(object sender, EventArgs e)
		{

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				try
				{
					conn.Open();
					string query = "INSERT INTO DonHang (khachhangid, sanphamid, soluong, ngaymua) VALUES (@khachhangid, @sanphamid, @soluong, @ngaymua)";
					SqlCommand cmd = new SqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@khachhangid", txtCustomerId.Text);
					cmd.Parameters.AddWithValue("@sanphamid", txtProductId.Text);
					cmd.Parameters.AddWithValue("@soluong", int.Parse(txtQuantity.Text));
					cmd.Parameters.AddWithValue("@ngaymua", dtpOrderDate.Value);

					cmd.ExecuteNonQuery();
					MessageBox.Show("Thêm đơn hàng thành công!");
					LoadOrders();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi khi thêm đơn hàng: " + ex.Message);
				}
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				try
				{
					conn.Open();
					string query = "UPDATE DonHang SET khachhangid = @khachhangid, sanphamid = @sanphamid, soluong = @soluong, ngaymua = @ngaymua WHERE id = @id";
					SqlCommand cmd = new SqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
					cmd.Parameters.AddWithValue("@khachhangid", txtCustomerId.Text);
					cmd.Parameters.AddWithValue("@sanphamid", txtProductId.Text);
					cmd.Parameters.AddWithValue("@soluong", int.Parse(txtQuantity.Text));
					cmd.Parameters.AddWithValue("@ngaymua", dtpOrderDate.Value);

					cmd.ExecuteNonQuery();
					MessageBox.Show("Sửa đơn hàng thành công!");
					LoadOrders();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi khi sửa đơn hàng: " + ex.Message);
				}
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				try
				{
					conn.Open();
					string query = "DELETE FROM DonHang WHERE id = @id";
					SqlCommand cmd = new SqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));

					cmd.ExecuteNonQuery();
					MessageBox.Show("Xóa đơn hàng thành công!");
					LoadOrders();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi khi xóa đơn hàng: " + ex.Message);
				}
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				try
				{
					conn.Open();
					string query = "SELECT * FROM DonHang WHERE id = @id";
					SqlCommand cmd = new SqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));

					SqlDataAdapter adapter = new SqlDataAdapter(cmd);
					DataTable dt = new DataTable();
					adapter.Fill(dt);
					dgvOrders.DataSource = dt;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi khi tìm kiếm đơn hàng: " + ex.Message);
				}
			}
		}
		private void LoadOrders()
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				try
				{
					conn.Open();
					string query = "SELECT * FROM DonHang";
					SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
					DataTable dt = new DataTable();
					adapter.Fill(dt);
					dgvOrders.DataSource = dt;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
				}
			}
		}

	}
}
