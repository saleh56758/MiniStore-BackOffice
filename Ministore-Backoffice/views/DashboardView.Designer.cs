namespace WindowsFormsApp1.views
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
            this.tblDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.pnlrecentOrders = new System.Windows.Forms.Panel();
            this.lblRecentOrders = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.OrderIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GrandTotalColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderStatusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tblKPI = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSalesV = new System.Windows.Forms.Label();
            this.lblSalesT = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblOrdersV = new System.Windows.Forms.Label();
            this.lblOrdersT = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblRevenueV = new System.Windows.Forms.Label();
            this.lblRevenueT = new System.Windows.Forms.Label();
            this.pnllowstock = new System.Windows.Forms.Panel();
            this.LVlowstock = new System.Windows.Forms.ListView();
            this.productColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stockColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblLowStock = new System.Windows.Forms.Label();
            this.tblDashboard.SuspendLayout();
            this.pnlrecentOrders.SuspendLayout();
            this.tblKPI.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnllowstock.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblDashboard
            // 
            this.tblDashboard.ColumnCount = 1;
            this.tblDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDashboard.Controls.Add(this.pnlrecentOrders, 0, 2);
            this.tblDashboard.Controls.Add(this.tblKPI, 0, 0);
            this.tblDashboard.Controls.Add(this.pnllowstock, 0, 1);
            this.tblDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDashboard.Location = new System.Drawing.Point(0, 0);
            this.tblDashboard.Name = "tblDashboard";
            this.tblDashboard.Padding = new System.Windows.Forms.Padding(16);
            this.tblDashboard.RowCount = 3;
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblDashboard.Size = new System.Drawing.Size(849, 499);
            this.tblDashboard.TabIndex = 0;
            // 
            // pnlrecentOrders
            // 
            this.pnlrecentOrders.Controls.Add(this.lblRecentOrders);
            this.pnlrecentOrders.Controls.Add(this.listView1);
            this.pnlrecentOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlrecentOrders.Location = new System.Drawing.Point(19, 312);
            this.pnlrecentOrders.Name = "pnlrecentOrders";
            this.pnlrecentOrders.Size = new System.Drawing.Size(811, 168);
            this.pnlrecentOrders.TabIndex = 2;
            // 
            // lblRecentOrders
            // 
            this.lblRecentOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecentOrders.AutoSize = true;
            this.lblRecentOrders.Location = new System.Drawing.Point(16, 16);
            this.lblRecentOrders.Name = "lblRecentOrders";
            this.lblRecentOrders.Size = new System.Drawing.Size(94, 16);
            this.lblRecentOrders.TabIndex = 3;
            this.lblRecentOrders.Text = "Recent Orders";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderIDColumn,
            this.CustomerIDColumn,
            this.GrandTotalColumn,
            this.OrderStatusColumn});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 35);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(811, 133);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // OrderIDColumn
            // 
            this.OrderIDColumn.Text = "OrderID";
            // 
            // CustomerIDColumn
            // 
            this.CustomerIDColumn.Text = "Customer";
            // 
            // GrandTotalColumn
            // 
            this.GrandTotalColumn.Text = "Total";
            // 
            // OrderStatusColumn
            // 
            this.OrderStatusColumn.Text = "Status";
            // 
            // tblKPI
            // 
            this.tblKPI.ColumnCount = 3;
            this.tblKPI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tblKPI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tblKPI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tblKPI.Controls.Add(this.panel1, 0, 0);
            this.tblKPI.Controls.Add(this.panel2, 1, 0);
            this.tblKPI.Controls.Add(this.panel3, 2, 0);
            this.tblKPI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblKPI.Location = new System.Drawing.Point(19, 19);
            this.tblKPI.Name = "tblKPI";
            this.tblKPI.RowCount = 1;
            this.tblKPI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblKPI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tblKPI.Size = new System.Drawing.Size(811, 114);
            this.tblKPI.TabIndex = 0;
            this.tblKPI.Paint += new System.Windows.Forms.PaintEventHandler(this.tblKPI_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblSalesV);
            this.panel1.Controls.Add(this.lblSalesT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 108);
            this.panel1.TabIndex = 0;
            // 
            // lblSalesV
            // 
            this.lblSalesV.AutoSize = true;
            this.lblSalesV.Location = new System.Drawing.Point(150, 42);
            this.lblSalesV.Name = "lblSalesV";
            this.lblSalesV.Size = new System.Drawing.Size(28, 16);
            this.lblSalesV.TabIndex = 1;
            this.lblSalesV.Text = "150";
            // 
            // lblSalesT
            // 
            this.lblSalesT.AutoSize = true;
            this.lblSalesT.Location = new System.Drawing.Point(13, 42);
            this.lblSalesT.Name = "lblSalesT";
            this.lblSalesT.Size = new System.Drawing.Size(42, 16);
            this.lblSalesT.TabIndex = 0;
            this.lblSalesT.Text = "Sales";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblOrdersV);
            this.panel2.Controls.Add(this.lblOrdersT);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(270, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 108);
            this.panel2.TabIndex = 3;
            // 
            // lblOrdersV
            // 
            this.lblOrdersV.AutoSize = true;
            this.lblOrdersV.Location = new System.Drawing.Point(150, 42);
            this.lblOrdersV.Name = "lblOrdersV";
            this.lblOrdersV.Size = new System.Drawing.Size(28, 16);
            this.lblOrdersV.TabIndex = 1;
            this.lblOrdersV.Text = "100";
            // 
            // lblOrdersT
            // 
            this.lblOrdersT.AutoSize = true;
            this.lblOrdersT.Location = new System.Drawing.Point(19, 42);
            this.lblOrdersT.Name = "lblOrdersT";
            this.lblOrdersT.Size = new System.Drawing.Size(48, 16);
            this.lblOrdersT.TabIndex = 0;
            this.lblOrdersT.Text = "Orders";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblRevenueV);
            this.panel3.Controls.Add(this.lblRevenueT);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(537, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(271, 108);
            this.panel3.TabIndex = 4;
            // 
            // lblRevenueV
            // 
            this.lblRevenueV.AutoSize = true;
            this.lblRevenueV.Location = new System.Drawing.Point(132, 42);
            this.lblRevenueV.Name = "lblRevenueV";
            this.lblRevenueV.Size = new System.Drawing.Size(75, 16);
            this.lblRevenueV.TabIndex = 1;
            this.lblRevenueV.Text = "37,700 PKR";
            // 
            // lblRevenueT
            // 
            this.lblRevenueT.AutoSize = true;
            this.lblRevenueT.Location = new System.Drawing.Point(17, 42);
            this.lblRevenueT.Name = "lblRevenueT";
            this.lblRevenueT.Size = new System.Drawing.Size(62, 16);
            this.lblRevenueT.TabIndex = 0;
            this.lblRevenueT.Text = "Revenue";
            // 
            // pnllowstock
            // 
            this.pnllowstock.Controls.Add(this.LVlowstock);
            this.pnllowstock.Controls.Add(this.lblLowStock);
            this.pnllowstock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnllowstock.Location = new System.Drawing.Point(19, 139);
            this.pnllowstock.Name = "pnllowstock";
            this.pnllowstock.Size = new System.Drawing.Size(811, 167);
            this.pnllowstock.TabIndex = 1;
            // 
            // LVlowstock
            // 
            this.LVlowstock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productColumn,
            this.stockColumn});
            this.LVlowstock.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LVlowstock.FullRowSelect = true;
            this.LVlowstock.GridLines = true;
            this.LVlowstock.HideSelection = false;
            this.LVlowstock.Location = new System.Drawing.Point(0, 34);
            this.LVlowstock.Name = "LVlowstock";
            this.LVlowstock.Size = new System.Drawing.Size(811, 133);
            this.LVlowstock.TabIndex = 1;
            this.LVlowstock.UseCompatibleStateImageBehavior = false;
            this.LVlowstock.View = System.Windows.Forms.View.Details;
            // 
            // productColumn
            // 
            this.productColumn.Text = "Products";
            // 
            // stockColumn
            // 
            this.stockColumn.Text = "Stock";
            // 
            // lblLowStock
            // 
            this.lblLowStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Location = new System.Drawing.Point(16, 15);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(68, 16);
            this.lblLowStock.TabIndex = 0;
            this.lblLowStock.Text = "Low Stock";
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblDashboard);
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(849, 499);
            this.tblDashboard.ResumeLayout(false);
            this.pnlrecentOrders.ResumeLayout(false);
            this.pnlrecentOrders.PerformLayout();
            this.tblKPI.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnllowstock.ResumeLayout(false);
            this.pnllowstock.PerformLayout();
            this.ResumeLayout(false);

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
