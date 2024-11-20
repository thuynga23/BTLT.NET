namespace kt20th11
{
	partial class MainForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuProductList = new System.Windows.Forms.ToolStripMenuItem();
			this.menuCustomerList = new System.Windows.Forms.ToolStripMenuItem();
			this.menuOrderList = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProductList,
            this.menuCustomerList,
            this.menuOrderList});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuProductList
			// 
			this.menuProductList.Name = "menuProductList";
			this.menuProductList.Size = new System.Drawing.Size(129, 20);
			this.menuProductList.Text = "Danh mục sản phẩm";
			this.menuProductList.Click += new System.EventHandler(this.menuProductList_Click);
			// 
			// menuCustomerList
			// 
			this.menuCustomerList.Name = "menuCustomerList";
			this.menuCustomerList.Size = new System.Drawing.Size(139, 20);
			this.menuCustomerList.Text = "Danh mục khách hàng";
			this.menuCustomerList.Click += new System.EventHandler(this.menuCustomerList_Click);
			// 
			// menuOrderList
			// 
			this.menuOrderList.Name = "menuOrderList";
			this.menuOrderList.Size = new System.Drawing.Size(71, 20);
			this.menuOrderList.Text = "Đơn hàng";
			this.menuOrderList.Click += new System.EventHandler(this.menuOrderList_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuProductList;
		private System.Windows.Forms.ToolStripMenuItem menuCustomerList;
		private System.Windows.Forms.ToolStripMenuItem menuOrderList;
	}
}