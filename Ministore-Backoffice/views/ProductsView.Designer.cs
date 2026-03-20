namespace WindowsFormsApp1.views
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
            this.tblproducts = new System.Windows.Forms.TableLayoutPanel();
            this.pnlbtns = new System.Windows.Forms.Panel();
            this.tsproducts = new System.Windows.Forms.ToolStrip();
            this.btnadd = new System.Windows.Forms.ToolStripButton();
            this.btnview = new System.Windows.Forms.ToolStripButton();
            this.btnedit = new System.Windows.Forms.ToolStripButton();
            this.btndelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnrefresh = new System.Windows.Forms.ToolStripButton();
            this.pnlfilters = new System.Windows.Forms.Panel();
            this.tblfilters = new System.Windows.Forms.TableLayoutPanel();
            this.lblsearch = new System.Windows.Forms.Label();
            this.lblcategory = new System.Windows.Forms.Label();
            this.lblstockstatus = new System.Windows.Forms.Label();
            this.txtboxsearch = new System.Windows.Forms.TextBox();
            this.cmbcategory = new System.Windows.Forms.ComboBox();
            this.cmbstocks = new System.Windows.Forms.ComboBox();
            this.pnldetails = new System.Windows.Forms.Panel();
            this.dgvproducts = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colstock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblproducts.SuspendLayout();
            this.pnlbtns.SuspendLayout();
            this.tsproducts.SuspendLayout();
            this.pnlfilters.SuspendLayout();
            this.tblfilters.SuspendLayout();
            this.pnldetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tblproducts
            // 
            this.tblproducts.ColumnCount = 1;
            this.tblproducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblproducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblproducts.Controls.Add(this.pnlbtns, 0, 0);
            this.tblproducts.Controls.Add(this.pnlfilters, 0, 1);
            this.tblproducts.Controls.Add(this.pnldetails, 0, 2);
            this.tblproducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblproducts.Location = new System.Drawing.Point(0, 0);
            this.tblproducts.Name = "tblproducts";
            this.tblproducts.Padding = new System.Windows.Forms.Padding(16);
            this.tblproducts.RowCount = 3;
            this.tblproducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tblproducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tblproducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblproducts.Size = new System.Drawing.Size(781, 525);
            this.tblproducts.TabIndex = 1;
            // 
            // pnlbtns
            // 
            this.pnlbtns.Controls.Add(this.tsproducts);
            this.pnlbtns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlbtns.Location = new System.Drawing.Point(19, 19);
            this.pnlbtns.Name = "pnlbtns";
            this.pnlbtns.Size = new System.Drawing.Size(743, 50);
            this.pnlbtns.TabIndex = 0;
            // 
            // tsproducts
            // 
            this.tsproducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsproducts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsproducts.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsproducts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnadd,
            this.btnview,
            this.btnedit,
            this.btndelete,
            this.toolStripSeparator1,
            this.btnrefresh});
            this.tsproducts.Location = new System.Drawing.Point(0, 0);
            this.tsproducts.Name = "tsproducts";
            this.tsproducts.Size = new System.Drawing.Size(743, 50);
            this.tsproducts.TabIndex = 0;
            this.tsproducts.Text = "tsproducts";
            // 
            // btnadd
            // 
            this.btnadd.Image = global::WindowsFormsApp1.Properties.Resources.square_plus;
            this.btnadd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(61, 47);
            this.btnadd.Text = "Add";
            // 
            // btnview
            // 
            this.btnview.Image = global::WindowsFormsApp1.Properties.Resources.eye;
            this.btnview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(65, 47);
            this.btnview.Text = "View";
            // 
            // btnedit
            // 
            this.btnedit.Image = global::WindowsFormsApp1.Properties.Resources.edit1;
            this.btnedit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(59, 47);
            this.btnedit.Text = "Edit";
            // 
            // btndelete
            // 
            this.btndelete.Image = global::WindowsFormsApp1.Properties.Resources.square_minus;
            this.btndelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(77, 47);
            this.btndelete.Text = "Delete";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Image = global::WindowsFormsApp1.Properties.Resources.rotate_clockwise;
            this.btnrefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(82, 47);
            this.btnrefresh.Text = "Refresh";
            // 
            // pnlfilters
            // 
            this.pnlfilters.BackColor = System.Drawing.Color.White;
            this.pnlfilters.Controls.Add(this.tblfilters);
            this.pnlfilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlfilters.Location = new System.Drawing.Point(19, 75);
            this.pnlfilters.Name = "pnlfilters";
            this.pnlfilters.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.pnlfilters.Size = new System.Drawing.Size(743, 78);
            this.pnlfilters.TabIndex = 1;
            // 
            // tblfilters
            // 
            this.tblfilters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblfilters.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblfilters.ColumnCount = 3;
            this.tblfilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblfilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblfilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblfilters.Controls.Add(this.lblsearch, 0, 0);
            this.tblfilters.Controls.Add(this.lblcategory, 1, 0);
            this.tblfilters.Controls.Add(this.lblstockstatus, 2, 0);
            this.tblfilters.Controls.Add(this.txtboxsearch, 0, 1);
            this.tblfilters.Controls.Add(this.cmbcategory, 1, 1);
            this.tblfilters.Controls.Add(this.cmbstocks, 2, 1);
            this.tblfilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblfilters.Location = new System.Drawing.Point(12, 10);
            this.tblfilters.Name = "tblfilters";
            this.tblfilters.RowCount = 2;
            this.tblfilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblfilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblfilters.Size = new System.Drawing.Size(719, 58);
            this.tblfilters.TabIndex = 0;
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.Location = new System.Drawing.Point(4, 1);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(280, 27);
            this.lblsearch.TabIndex = 0;
            this.lblsearch.Text = "Search";
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategory.Location = new System.Drawing.Point(291, 1);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(208, 27);
            this.lblcategory.TabIndex = 1;
            this.lblcategory.Text = "Category";
            // 
            // lblstockstatus
            // 
            this.lblstockstatus.AutoSize = true;
            this.lblstockstatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblstockstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstockstatus.Location = new System.Drawing.Point(506, 1);
            this.lblstockstatus.Name = "lblstockstatus";
            this.lblstockstatus.Size = new System.Drawing.Size(209, 27);
            this.lblstockstatus.TabIndex = 2;
            this.lblstockstatus.Text = "Stock Status";
            // 
            // txtboxsearch
            // 
            this.txtboxsearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtboxsearch.Location = new System.Drawing.Point(4, 32);
            this.txtboxsearch.Name = "txtboxsearch";
            this.txtboxsearch.Size = new System.Drawing.Size(280, 22);
            this.txtboxsearch.TabIndex = 3;
            // 
            // cmbcategory
            // 
            this.cmbcategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbcategory.FormattingEnabled = true;
            this.cmbcategory.Location = new System.Drawing.Point(291, 32);
            this.cmbcategory.Name = "cmbcategory";
            this.cmbcategory.Size = new System.Drawing.Size(208, 24);
            this.cmbcategory.TabIndex = 4;
            // 
            // cmbstocks
            // 
            this.cmbstocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbstocks.FormattingEnabled = true;
            this.cmbstocks.Location = new System.Drawing.Point(506, 32);
            this.cmbstocks.Name = "cmbstocks";
            this.cmbstocks.Size = new System.Drawing.Size(209, 24);
            this.cmbstocks.TabIndex = 5;
            // 
            // pnldetails
            // 
            this.pnldetails.BackColor = System.Drawing.Color.White;
            this.pnldetails.Controls.Add(this.dgvproducts);
            this.pnldetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnldetails.Location = new System.Drawing.Point(19, 159);
            this.pnldetails.Name = "pnldetails";
            this.pnldetails.Padding = new System.Windows.Forms.Padding(12);
            this.pnldetails.Size = new System.Drawing.Size(743, 347);
            this.pnldetails.TabIndex = 2;
            // 
            // dgvproducts
            // 
            this.dgvproducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvproducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colname,
            this.colcategory,
            this.colprice,
            this.colstock,
            this.colstatus});
            this.dgvproducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvproducts.GridColor = System.Drawing.SystemColors.Control;
            this.dgvproducts.Location = new System.Drawing.Point(12, 12);
            this.dgvproducts.MultiSelect = false;
            this.dgvproducts.Name = "dgvproducts";
            this.dgvproducts.ReadOnly = true;
            this.dgvproducts.RowHeadersVisible = false;
            this.dgvproducts.RowHeadersWidth = 51;
            this.dgvproducts.RowTemplate.Height = 24;
            this.dgvproducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvproducts.Size = new System.Drawing.Size(719, 323);
            this.dgvproducts.TabIndex = 0;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colname
            // 
            this.colname.HeaderText = "Name";
            this.colname.MinimumWidth = 6;
            this.colname.Name = "colname";
            this.colname.ReadOnly = true;
            // 
            // colcategory
            // 
            this.colcategory.HeaderText = "Category";
            this.colcategory.MinimumWidth = 6;
            this.colcategory.Name = "colcategory";
            this.colcategory.ReadOnly = true;
            // 
            // colprice
            // 
            this.colprice.HeaderText = "Price";
            this.colprice.MinimumWidth = 6;
            this.colprice.Name = "colprice";
            this.colprice.ReadOnly = true;
            // 
            // colstock
            // 
            this.colstock.HeaderText = "Stock";
            this.colstock.MinimumWidth = 6;
            this.colstock.Name = "colstock";
            this.colstock.ReadOnly = true;
            // 
            // colstatus
            // 
            this.colstatus.HeaderText = "Status";
            this.colstatus.MinimumWidth = 6;
            this.colstatus.Name = "colstatus";
            this.colstatus.ReadOnly = true;
            // 
            // ProductsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblproducts);
            this.Name = "ProductsView";
            this.Size = new System.Drawing.Size(781, 525);
            this.tblproducts.ResumeLayout(false);
            this.pnlbtns.ResumeLayout(false);
            this.pnlbtns.PerformLayout();
            this.tsproducts.ResumeLayout(false);
            this.tsproducts.PerformLayout();
            this.pnlfilters.ResumeLayout(false);
            this.tblfilters.ResumeLayout(false);
            this.tblfilters.PerformLayout();
            this.pnldetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducts)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ComboBox cmbstocks;
        private System.Windows.Forms.Panel pnldetails;
        private System.Windows.Forms.DataGridView dgvproducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colstock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colstatus;
    }
}
