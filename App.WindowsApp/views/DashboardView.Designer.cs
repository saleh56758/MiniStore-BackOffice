namespace App.WindowsApp.views
{
    partial class DashboardView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tblDashboard = new TableLayoutPanel();
            pnlrecentOrders = new Panel();
            lblRecentOrders = new Label();
            listView1 = new ListView();
            OrderIDColumn = new ColumnHeader();
            CustomerIDColumn = new ColumnHeader();
            GrandTotalColumn = new ColumnHeader();
            OrderStatusColumn = new ColumnHeader();
            tblKPI = new TableLayoutPanel();
            panel1 = new Panel();
            lblSalesV = new Label();
            lblSalesT = new Label();
            panel2 = new Panel();
            lblOrdersV = new Label();
            lblOrdersT = new Label();
            panel3 = new Panel();
            lblRevenueV = new Label();
            lblRevenueT = new Label();
            pnllowstock = new Panel();
            LVlowstock = new ListView();
            productColumn = new ColumnHeader();
            stockColumn = new ColumnHeader();
            lblLowStock = new Label();
            tblDashboard.SuspendLayout();
            pnlrecentOrders.SuspendLayout();
            tblKPI.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            pnllowstock.SuspendLayout();
            SuspendLayout();
            // 
            // tblDashboard
            // 
            tblDashboard.ColumnCount = 1;
            tblDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblDashboard.Controls.Add(pnlrecentOrders, 0, 2);
            tblDashboard.Controls.Add(tblKPI, 0, 0);
            tblDashboard.Controls.Add(pnllowstock, 0, 1);
            tblDashboard.Dock = DockStyle.Fill;
            tblDashboard.Location = new Point(0, 0);
            tblDashboard.Margin = new Padding(3, 4, 3, 4);
            tblDashboard.Name = "tblDashboard";
            tblDashboard.Padding = new Padding(16, 20, 16, 20);
            tblDashboard.RowCount = 3;
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tblDashboard.Size = new Size(849, 624);
            tblDashboard.TabIndex = 0;
            // 
            // pnlrecentOrders
            // 
            pnlrecentOrders.Controls.Add(lblRecentOrders);
            pnlrecentOrders.Controls.Add(listView1);
            pnlrecentOrders.Dock = DockStyle.Fill;
            pnlrecentOrders.Location = new Point(19, 391);
            pnlrecentOrders.Margin = new Padding(3, 4, 3, 4);
            pnlrecentOrders.Name = "pnlrecentOrders";
            pnlrecentOrders.Size = new Size(811, 209);
            pnlrecentOrders.TabIndex = 2;
            pnlrecentOrders.Paint += pnlrecentOrders_Paint;
            // 
            // lblRecentOrders
            // 
            lblRecentOrders.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblRecentOrders.AutoSize = true;
            lblRecentOrders.Location = new Point(16, 19);
            lblRecentOrders.Name = "lblRecentOrders";
            lblRecentOrders.Size = new Size(102, 20);
            lblRecentOrders.TabIndex = 3;
            lblRecentOrders.Text = "Recent Orders";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { OrderIDColumn, CustomerIDColumn, GrandTotalColumn, OrderStatusColumn });
            listView1.Dock = DockStyle.Bottom;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(0, 44);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(811, 165);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // OrderIDColumn
            // 
            OrderIDColumn.Text = "OrderID";
            // 
            // CustomerIDColumn
            // 
            CustomerIDColumn.Text = "Customer";
            // 
            // GrandTotalColumn
            // 
            GrandTotalColumn.Text = "Total";
            // 
            // OrderStatusColumn
            // 
            OrderStatusColumn.Text = "Status";
            // 
            // tblKPI
            // 
            tblKPI.ColumnCount = 3;
            tblKPI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tblKPI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tblKPI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tblKPI.Controls.Add(panel1, 0, 0);
            tblKPI.Controls.Add(panel2, 1, 0);
            tblKPI.Controls.Add(panel3, 2, 0);
            tblKPI.Dock = DockStyle.Fill;
            tblKPI.Location = new Point(19, 24);
            tblKPI.Margin = new Padding(3, 4, 3, 4);
            tblKPI.Name = "tblKPI";
            tblKPI.RowCount = 1;
            tblKPI.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblKPI.RowStyles.Add(new RowStyle(SizeType.Absolute, 142F));
            tblKPI.Size = new Size(811, 142);
            tblKPI.TabIndex = 0;
            tblKPI.Paint += tblKPI_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblSalesV);
            panel1.Controls.Add(lblSalesT);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(261, 134);
            panel1.TabIndex = 0;
            // 
            // lblSalesV
            // 
            lblSalesV.AutoSize = true;
            lblSalesV.Location = new Point(150, 52);
            lblSalesV.Name = "lblSalesV";
            lblSalesV.Size = new Size(33, 20);
            lblSalesV.TabIndex = 1;
            lblSalesV.Text = "150";
            // 
            // lblSalesT
            // 
            lblSalesT.AutoSize = true;
            lblSalesT.Location = new Point(13, 52);
            lblSalesT.Name = "lblSalesT";
            lblSalesT.Size = new Size(43, 20);
            lblSalesT.TabIndex = 0;
            lblSalesT.Text = "Sales";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblOrdersV);
            panel2.Controls.Add(lblOrdersT);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(270, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(261, 134);
            panel2.TabIndex = 3;
            // 
            // lblOrdersV
            // 
            lblOrdersV.AutoSize = true;
            lblOrdersV.Location = new Point(150, 52);
            lblOrdersV.Name = "lblOrdersV";
            lblOrdersV.Size = new Size(33, 20);
            lblOrdersV.TabIndex = 1;
            lblOrdersV.Text = "100";
            // 
            // lblOrdersT
            // 
            lblOrdersT.AutoSize = true;
            lblOrdersT.Location = new Point(19, 52);
            lblOrdersT.Name = "lblOrdersT";
            lblOrdersT.Size = new Size(53, 20);
            lblOrdersT.TabIndex = 0;
            lblOrdersT.Text = "Orders";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lblRevenueV);
            panel3.Controls.Add(lblRevenueT);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(537, 4);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(271, 134);
            panel3.TabIndex = 4;
            // 
            // lblRevenueV
            // 
            lblRevenueV.AutoSize = true;
            lblRevenueV.Location = new Point(132, 52);
            lblRevenueV.Name = "lblRevenueV";
            lblRevenueV.Size = new Size(82, 20);
            lblRevenueV.TabIndex = 1;
            lblRevenueV.Text = "37,700 PKR";
            // 
            // lblRevenueT
            // 
            lblRevenueT.AutoSize = true;
            lblRevenueT.Location = new Point(17, 52);
            lblRevenueT.Name = "lblRevenueT";
            lblRevenueT.Size = new Size(65, 20);
            lblRevenueT.TabIndex = 0;
            lblRevenueT.Text = "Revenue";
            // 
            // pnllowstock
            // 
            pnllowstock.Controls.Add(LVlowstock);
            pnllowstock.Controls.Add(lblLowStock);
            pnllowstock.Dock = DockStyle.Fill;
            pnllowstock.Location = new Point(19, 174);
            pnllowstock.Margin = new Padding(3, 4, 3, 4);
            pnllowstock.Name = "pnllowstock";
            pnllowstock.Size = new Size(811, 209);
            pnllowstock.TabIndex = 1;
            // 
            // LVlowstock
            // 
            LVlowstock.Columns.AddRange(new ColumnHeader[] { productColumn, stockColumn });
            LVlowstock.Dock = DockStyle.Bottom;
            LVlowstock.FullRowSelect = true;
            LVlowstock.GridLines = true;
            LVlowstock.Location = new Point(0, 44);
            LVlowstock.Margin = new Padding(3, 4, 3, 4);
            LVlowstock.Name = "LVlowstock";
            LVlowstock.Size = new Size(811, 165);
            LVlowstock.TabIndex = 1;
            LVlowstock.UseCompatibleStateImageBehavior = false;
            LVlowstock.View = View.Details;
            // 
            // productColumn
            // 
            productColumn.Text = "Products";
            // 
            // stockColumn
            // 
            stockColumn.Text = "Stock";
            // 
            // lblLowStock
            // 
            lblLowStock.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblLowStock.AutoSize = true;
            lblLowStock.Location = new Point(16, 19);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(76, 20);
            lblLowStock.TabIndex = 0;
            lblLowStock.Text = "Low Stock";
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblDashboard);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DashboardView";
            Size = new Size(849, 624);
            tblDashboard.ResumeLayout(false);
            pnlrecentOrders.ResumeLayout(false);
            pnlrecentOrders.PerformLayout();
            tblKPI.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            pnllowstock.ResumeLayout(false);
            pnllowstock.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblDashboard;
        private System.Windows.Forms.TableLayoutPanel tblKPI;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSalesV;
        private System.Windows.Forms.Label lblSalesT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblOrdersV;
        private System.Windows.Forms.Label lblOrdersT;
        private System.Windows.Forms.Label lblRevenueV;
        private System.Windows.Forms.Label lblRevenueT;
        private System.Windows.Forms.Panel pnllowstock;
        private System.Windows.Forms.Panel pnlrecentOrders;
        private System.Windows.Forms.ListView LVlowstock;
        private System.Windows.Forms.ColumnHeader productColumn;
        private System.Windows.Forms.ColumnHeader stockColumn;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.Label lblRecentOrders;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader OrderIDColumn;
        private System.Windows.Forms.ColumnHeader CustomerIDColumn;
        private System.Windows.Forms.ColumnHeader GrandTotalColumn;
        private System.Windows.Forms.ColumnHeader OrderStatusColumn;
    }
}
