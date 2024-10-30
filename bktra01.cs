using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bktra01
{
    public partial class Form1 : Form
    {
        public class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }

            public Product(string name, decimal price, int quantity = 1)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cấu hình ListView
            lvProducts.View = View.Details;
            lvProducts.Columns.Add("Tên sản phẩm", 150);
            lvProducts.Columns.Add("Giá", 100);
            lvProducts.Columns.Add("Số lượng", 100);

            // Thêm sản phẩm mẫu vào ListView
            lvProducts.Items.Add(new ListViewItem(new[] { "bánh tyty", "10000", "1" }));
            lvProducts.Items.Add(new ListViewItem(new[] { "sữa vinamilk", "20000", "1" }));
            lvProducts.Items.Add(new ListViewItem(new[] { "sữa TH", "15000", "1" }));
            // Cấu hình DataGridView
            dgvCart.ColumnCount = 4;
            dgvCart.Columns[0].Name = "Tên sản phẩm";
            dgvCart.Columns[1].Name = "Giá";
            dgvCart.Columns[2].Name = "Số lượng";
            dgvCart.Columns[3].Name = "Thanh toán";
            dgvCart.Columns[3].ReadOnly = true; // Không cho phép chỉnh sửa cột Thanh toán
        }

        private void lvProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count > 0)
            {
                // Lấy thông tin sản phẩm từ ListView
                ListViewItem selectedItem = lvProducts.SelectedItems[0];
                string productName = selectedItem.SubItems[0].Text;
                decimal price = decimal.Parse(selectedItem.SubItems[1].Text);
                int quantity = int.Parse(selectedItem.SubItems[2].Text);

                // Tính tổng giá trị
                decimal total = price * quantity;

                // Thêm vào DataGridView
                dgvCart.Rows.Add(productName, price, quantity, total);

                // Cập nhật tổng số lượng và tổng giá trị
                UpdateCartSummary();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm từ danh sách.");
            }
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCart.SelectedRows)
            {
                dgvCart.Rows.Remove(row);
            }
            UpdateCartSummary();
        }
        private void UpdateCartSummary()
        {
            int totalQuantity = 0;
            decimal totalPrice = 0;

            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                totalQuantity += Convert.ToInt32(row.Cells["Số lượng"].Value);
                totalPrice += Convert.ToDecimal(row.Cells["Thanh toán"].Value);
            }

            lblTotalQuantity.Text = "Tổng số lượng: " + totalQuantity;
            lblTotalPrice.Text = "Tổng giá trị: " + totalPrice;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count > 0)
            {
                MessageBox.Show("Thanh toán thành công! Tổng giá trị: " + lblTotalPrice.Text);
                dgvCart.Rows.Clear(); // Xóa toàn bộ sản phẩm trong giỏ hàng
                UpdateCartSummary();   // Cập nhật lại tổng số lượng và tổng giá trị
            }
            else
            {
                MessageBox.Show("Giỏ hàng của bạn đang trống.");
            }
        }
    }
}
