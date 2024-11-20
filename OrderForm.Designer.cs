namespace kt20th11
{
	partial class OrderForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.txtProductId = new System.Windows.Forms.TextBox();
			this.txtCustomerId = new System.Windows.Forms.TextBox();
			this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.dgvOrders = new System.Windows.Forms.DataGridView();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(62, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã đơn hàng";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(62, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Mã khách hàng";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(62, 125);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Mã sản phẩm";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(62, 160);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Số lượng";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(179, 52);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(254, 20);
			this.textBox1.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(62, 195);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Ngày mua";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// txtQuantity
			// 
			this.txtQuantity.Location = new System.Drawing.Point(179, 160);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(254, 20);
			this.txtQuantity.TabIndex = 6;
			// 
			// txtProductId
			// 
			this.txtProductId.Location = new System.Drawing.Point(179, 122);
			this.txtProductId.Name = "txtProductId";
			this.txtProductId.Size = new System.Drawing.Size(254, 20);
			this.txtProductId.TabIndex = 7;
			// 
			// txtCustomerId
			// 
			this.txtCustomerId.Location = new System.Drawing.Point(179, 89);
			this.txtCustomerId.Name = "txtCustomerId";
			this.txtCustomerId.Size = new System.Drawing.Size(254, 20);
			this.txtCustomerId.TabIndex = 8;
			// 
			// dtpOrderDate
			// 
			this.dtpOrderDate.Location = new System.Drawing.Point(179, 195);
			this.dtpOrderDate.Name = "dtpOrderDate";
			this.dtpOrderDate.Size = new System.Drawing.Size(254, 20);
			this.dtpOrderDate.TabIndex = 9;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(83, 258);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 10;
			this.btnAdd.Text = "Thêm ";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(197, 258);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 11;
			this.btnEdit.Text = "Sửa";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(313, 258);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 12;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// dgvOrders
			// 
			this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOrders.Location = new System.Drawing.Point(550, 122);
			this.dgvOrders.Name = "dgvOrders";
			this.dgvOrders.Size = new System.Drawing.Size(578, 511);
			this.dgvOrders.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(557, 34);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(49, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "Tìm kiếm";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(644, 31);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(254, 20);
			this.textBox2.TabIndex = 15;
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(928, 34);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 16;
			this.btnSearch.Text = "Tìm kiếm";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(719, 78);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(246, 24);
			this.label7.TabIndex = 17;
			this.label7.Text = "DANH SÁCH ĐƠN HÀNG";
			// 
			// OrderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1140, 655);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.dgvOrders);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.dtpOrderDate);
			this.Controls.Add(this.txtCustomerId);
			this.Controls.Add(this.txtProductId);
			this.Controls.Add(this.txtQuantity);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "OrderForm";
			this.Text = "OrderForm";
			this.Load += new System.EventHandler(this.txtOrderId_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtQuantity;
		private System.Windows.Forms.TextBox txtProductId;
		private System.Windows.Forms.TextBox txtCustomerId;
		private System.Windows.Forms.DateTimePicker dtpOrderDate;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.DataGridView dgvOrders;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Label label7;
	}
}