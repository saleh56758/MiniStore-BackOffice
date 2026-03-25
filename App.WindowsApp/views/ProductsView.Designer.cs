namespace App.WindowsApp.views
{
    partial class ProductsView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tblproducts = new TableLayoutPanel();
            pnlbtns = new Panel();
            tsproducts = new ToolStrip();
            btnadd = new ToolStripButton();
            btnview = new ToolStripButton();
            btnedit = new ToolStripButton();
            btndelete = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnrefresh = new ToolStripButton();
            pnlfilters = new Panel();
            tblfilters = new TableLayoutPanel();
            lblsearch = new Label();
            lblcategory = new Label();
            lblstockstatus = new Label();
            txtboxsearch = new TextBox();
            cmbcategory = new ComboBox();
            cmbstatus = new ComboBox();
            pnldetails = new Panel();
            dgvproducts = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            tblproducts.SuspendLayout();
            pnlbtns.SuspendLayout();
            tsproducts.SuspendLayout();
            pnlfilters.SuspendLayout();
            tblfilters.SuspendLayout();
            pnldetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvproducts).BeginInit();
            SuspendLayout();
            // 
            // tblproducts
            // 
            tblproducts.ColumnCount = 1;
            tblproducts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblproducts.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblproducts.Controls.Add(pnlbtns, 0, 0);
            tblproducts.Controls.Add(pnlfilters, 0, 1);
            tblproducts.Controls.Add(pnldetails, 0, 2);
            tblproducts.Dock = DockStyle.Fill;
            tblproducts.Location = new Point(0, 0);
            tblproducts.Margin = new Padding(3, 4, 3, 4);
            tblproducts.Name = "tblproducts";
            tblproducts.Padding = new Padding(16, 20, 16, 20);
            tblproducts.RowCount = 3;
            tblproducts.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tblproducts.RowStyles.Add(new RowStyle(SizeType.Absolute, 105F));
            tblproducts.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblproducts.Size = new Size(781, 656);
            tblproducts.TabIndex = 1;
            // 
            // pnlbtns
            // 
            pnlbtns.Controls.Add(tsproducts);
            pnlbtns.Dock = DockStyle.Fill;
            pnlbtns.Location = new Point(19, 24);
            pnlbtns.Margin = new Padding(3, 4, 3, 4);
            pnlbtns.Name = "pnlbtns";
            pnlbtns.Size = new Size(743, 62);
            pnlbtns.TabIndex = 0;
            // 
            // tsproducts
            // 
            tsproducts.Dock = DockStyle.Fill;
            tsproducts.GripStyle = ToolStripGripStyle.Hidden;
            tsproducts.ImageScalingSize = new Size(20, 20);
            tsproducts.Items.AddRange(new ToolStripItem[] { btnadd, btnview, btnedit, btndelete, toolStripSeparator1, btnrefresh });
            tsproducts.Location = new Point(0, 0);
            tsproducts.Name = "tsproducts";
            tsproducts.Size = new Size(743, 62);
            tsproducts.TabIndex = 0;
            tsproducts.Text = "tsproducts";
            // 
            // btnadd
            // 
            btnadd.Image = Properties.Resources.square_plus;
            btnadd.ImageTransparentColor = Color.Magenta;
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(61, 59);
            btnadd.Text = "Add";
            btnadd.Click += btnadd_Click;
            // 
            // btnview
            // 
            btnview.Image = Properties.Resources.eye;
            btnview.ImageTransparentColor = Color.Magenta;
            btnview.Name = "btnview";
            btnview.Size = new Size(65, 59);
            btnview.Text = "View";
            btnview.Click += btnview_Click;
            // 
            // btnedit
            // 
            btnedit.Image = Properties.Resources.edit;
            btnedit.ImageTransparentColor = Color.Magenta;
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(59, 59);
            btnedit.Text = "Edit";
            btnedit.Click += btnedit_Click;
            // 
            // btndelete
            // 
            btndelete.Image = Properties.Resources.square_minus;
            btndelete.ImageTransparentColor = Color.Magenta;
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(77, 59);
            btndelete.Text = "Delete";
            btndelete.Click += btndelete_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 62);
            // 
            // btnrefresh
            // 
            btnrefresh.Image = Properties.Resources.refresh;
            btnrefresh.ImageTransparentColor = Color.Magenta;
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(82, 59);
            btnrefresh.Text = "Refresh";
            btnrefresh.Click += btnrefresh_Click;
            // 
            // pnlfilters
            // 
            pnlfilters.BackColor = Color.White;
            pnlfilters.Controls.Add(tblfilters);
            pnlfilters.Dock = DockStyle.Fill;
            pnlfilters.Location = new Point(19, 94);
            pnlfilters.Margin = new Padding(3, 4, 3, 4);
            pnlfilters.Name = "pnlfilters";
            pnlfilters.Padding = new Padding(12);
            pnlfilters.Size = new Size(743, 97);
            pnlfilters.TabIndex = 1;
            // 
            // tblfilters
            // 
            tblfilters.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblfilters.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tblfilters.ColumnCount = 3;
            tblfilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tblfilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblfilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblfilters.Controls.Add(lblsearch, 0, 0);
            tblfilters.Controls.Add(lblcategory, 1, 0);
            tblfilters.Controls.Add(lblstockstatus, 2, 0);
            tblfilters.Controls.Add(txtboxsearch, 0, 1);
            tblfilters.Controls.Add(cmbcategory, 1, 1);
            tblfilters.Controls.Add(cmbstatus, 2, 1);
            tblfilters.Dock = DockStyle.Fill;
            tblfilters.Location = new Point(12, 12);
            tblfilters.Margin = new Padding(3, 4, 3, 4);
            tblfilters.Name = "tblfilters";
            tblfilters.RowCount = 2;
            tblfilters.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblfilters.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblfilters.Size = new Size(719, 73);
            tblfilters.TabIndex = 0;
            // 
            // lblsearch
            // 
            lblsearch.AutoSize = true;
            lblsearch.Dock = DockStyle.Fill;
            lblsearch.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblsearch.Location = new Point(4, 1);
            lblsearch.Name = "lblsearch";
            lblsearch.Size = new Size(280, 35);
            lblsearch.TabIndex = 0;
            lblsearch.Text = "Search";
            // 
            // lblcategory
            // 
            lblcategory.AutoSize = true;
            lblcategory.Dock = DockStyle.Fill;
            lblcategory.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcategory.Location = new Point(291, 1);
            lblcategory.Name = "lblcategory";
            lblcategory.Size = new Size(208, 35);
            lblcategory.TabIndex = 1;
            lblcategory.Text = "Category";
            // 
            // lblstockstatus
            // 
            lblstockstatus.AutoSize = true;
            lblstockstatus.Dock = DockStyle.Fill;
            lblstockstatus.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblstockstatus.Location = new Point(506, 1);
            lblstockstatus.Name = "lblstockstatus";
            lblstockstatus.Size = new Size(209, 35);
            lblstockstatus.TabIndex = 2;
            lblstockstatus.Text = "Stock Status";
            // 
            // txtboxsearch
            // 
            txtboxsearch.Dock = DockStyle.Fill;
            txtboxsearch.Location = new Point(4, 41);
            txtboxsearch.Margin = new Padding(3, 4, 3, 4);
            txtboxsearch.Name = "txtboxsearch";
            txtboxsearch.Size = new Size(280, 27);
            txtboxsearch.TabIndex = 3;
            txtboxsearch.TextChanged += txtboxsearch_TextChanged;
            // 
            // cmbcategory
            // 
            cmbcategory.Dock = DockStyle.Fill;
            cmbcategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbcategory.FormattingEnabled = true;
            cmbcategory.Location = new Point(291, 41);
            cmbcategory.Margin = new Padding(3, 4, 3, 4);
            cmbcategory.Name = "cmbcategory";
            cmbcategory.Size = new Size(208, 28);
            cmbcategory.TabIndex = 4;
            cmbcategory.SelectedIndexChanged += cmbcategory_SelectedIndexChanged;
            // 
            // cmbstatus
            // 
            cmbstatus.Dock = DockStyle.Fill;
            cmbstatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbstatus.FormattingEnabled = true;
            cmbstatus.Location = new Point(506, 41);
            cmbstatus.Margin = new Padding(3, 4, 3, 4);
            cmbstatus.Name = "cmbstatus";
            cmbstatus.Size = new Size(209, 28);
            cmbstatus.TabIndex = 5;
            // 
            // pnldetails
            // 
            pnldetails.BackColor = Color.White;
            pnldetails.Controls.Add(dgvproducts);
            pnldetails.Dock = DockStyle.Fill;
            pnldetails.Location = new Point(19, 199);
            pnldetails.Margin = new Padding(3, 4, 3, 4);
            pnldetails.Name = "pnldetails";
            pnldetails.Padding = new Padding(12, 15, 12, 15);
            pnldetails.Size = new Size(743, 433);
            pnldetails.TabIndex = 2;
            // 
            // dgvproducts
            // 
            dgvproducts.AllowUserToAddRows = false;
            dgvproducts.AllowUserToDeleteRows = false;
            dgvproducts.AllowUserToResizeRows = false;
            dgvproducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvproducts.BackgroundColor = Color.White;
            dgvproducts.BorderStyle = BorderStyle.None;
            dgvproducts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvproducts.ColumnHeadersHeight = 29;
            dgvproducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvproducts.Columns.AddRange(new DataGridViewColumn[] { colID, colName, colCategory, colPrice, colStock, colStatus });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvproducts.DefaultCellStyle = dataGridViewCellStyle1;
            dgvproducts.Dock = DockStyle.Fill;
            dgvproducts.EnableHeadersVisualStyles = false;
            dgvproducts.GridColor = SystemColors.Control;
            dgvproducts.Location = new Point(12, 15);
            dgvproducts.Margin = new Padding(3, 4, 3, 4);
            dgvproducts.MultiSelect = false;
            dgvproducts.Name = "dgvproducts";
            dgvproducts.ReadOnly = true;
            dgvproducts.RowHeadersVisible = false;
            dgvproducts.RowHeadersWidth = 51;
            dgvproducts.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.MenuHighlight;
            dgvproducts.RowTemplate.Height = 24;
            dgvproducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvproducts.Size = new Size(719, 403);
            dgvproducts.TabIndex = 0;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.ReadOnly = true;
            // 
            // colName
            // 
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.DataPropertyName = "Category";
            colCategory.HeaderText = "Category";
            colCategory.MinimumWidth = 6;
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.DataPropertyName = "Price";
            colPrice.HeaderText = "Price";
            colPrice.MinimumWidth = 6;
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // colStock
            // 
            colStock.DataPropertyName = "Stock";
            colStock.HeaderText = "Stock";
            colStock.MinimumWidth = 6;
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // ProductsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblproducts);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductsView";
            Size = new Size(781, 656);
            Load += ProductsView_Load;
            tblproducts.ResumeLayout(false);
            pnlbtns.ResumeLayout(false);
            pnlbtns.PerformLayout();
            tsproducts.ResumeLayout(false);
            tsproducts.PerformLayout();
            pnlfilters.ResumeLayout(false);
            tblfilters.ResumeLayout(false);
            tblfilters.PerformLayout();
            pnldetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvproducts).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblproducts;
        private System.Windows.Forms.Panel pnlbtns;
        private System.Windows.Forms.ToolStrip tsproducts;
        private System.Windows.Forms.ToolStripButton btnadd;
        private System.Windows.Forms.ToolStripButton btnview;
        private System.Windows.Forms.ToolStripButton btnedit;
        private System.Windows.Forms.ToolStripButton btndelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnrefresh;
        private System.Windows.Forms.Panel pnlfilters;
        private System.Windows.Forms.TableLayoutPanel tblfilters;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.Label lblstockstatus;
        private System.Windows.Forms.TextBox txtboxsearch;
        private System.Windows.Forms.ComboBox cmbcategory;
        private System.Windows.Forms.ComboBox cmbstatus;
        private System.Windows.Forms.Panel pnldetails;
        private System.Windows.Forms.DataGridView dgvproducts;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colStatus;
    }
}
