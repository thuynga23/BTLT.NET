using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kt20th11
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			this.IsMdiContainer = true;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}
		private void menuProductList_Click(object sender, EventArgs e)
		{
			ProductForm productForm = new ProductForm();
			productForm.MdiParent = this; // Thiết lập Form cha là MainForm
			productForm.Show();
		}
		private void menuCustomerList_Click(object sender, EventArgs e)
		{
			CustomerForm customerForm = new CustomerForm();
			customerForm.MdiParent = this; // Thiết lập Form cha là MainForm
			customerForm.Show();
		}
		private void menuOrderList_Click(object sender, EventArgs e)
		{
			OrderForm orderForm = new OrderForm();
			orderForm.MdiParent = this; // Thiết lập Form cha là MainForm
			orderForm.Show();
		}
	}
}
