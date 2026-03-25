namespace WindowsFormsApp1.Forms
{
    partial class ProductsForm
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
            pnlMain = new Panel();
            pnlButtons = new Panel();
            btnsave = new Button();
            btncancel = new Button();
            tblForm = new TableLayoutPanel();
            txtName = new TextBox();
            cmbCat = new ComboBox();
            numStock = new NumericUpDown();
            cmbStatus = new ComboBox();
            txtID = new TextBox();
            numPrice = new NumericUpDown();
            pnlname = new Panel();
            lblname = new Label();
            pnlcategory = new Panel();
            lblcategory = new Label();
            pnlprice = new Panel();
            lblprice = new Label();
            pnlstock = new Panel();
            lblstock = new Label();
            pnlstatus = new Panel();
            lblstatus = new Label();
            pnlID = new Panel();
            lblID = new Label();
            pnlMain.SuspendLayout();
            pnlButtons.SuspendLayout();
            tblForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            pnlname.SuspendLayout();
            pnlcategory.SuspendLayout();
            pnlprice.SuspendLayout();
            pnlstock.SuspendLayout();
            pnlstatus.SuspendLayout();
            pnlID.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlButtons);
            pnlMain.Controls.Add(tblForm);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Margin = new Padding(3, 4, 3, 4);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(20, 25, 20, 25);
            pnlMain.Size = new Size(800, 562);
            pnlMain.TabIndex = 3;
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnsave);
            pnlButtons.Controls.Add(btncancel);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(20, 419);
            pnlButtons.Margin = new Padding(3, 4, 3, 4);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(760, 118);
            pnlButtons.TabIndex = 2;
            // 
            // btnsave
            // 
            btnsave.AutoSize = true;
            btnsave.FlatAppearance.BorderSize = 0;
            btnsave.FlatStyle = FlatStyle.Flat;
            btnsave.Image = App.WindowsApp.Properties.Resources.device_floppy1;
            btnsave.Location = new Point(631, 28);
            btnsave.Margin = new Padding(3, 4, 3, 4);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(107, 68);
            btnsave.TabIndex = 1;
            btnsave.Text = "Save";
            btnsave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // btncancel
            // 
            btncancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btncancel.AutoSize = true;
            btncancel.FlatAppearance.BorderSize = 0;
            btncancel.FlatStyle = FlatStyle.Flat;
            btncancel.Image = App.WindowsApp.Properties.Resources.cancel;
            btncancel.Location = new Point(476, 28);
            btncancel.Margin = new Padding(3, 4, 3, 4);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(111, 68);
            btncancel.TabIndex = 0;
            btncancel.Text = "Cancel";
            btncancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click;
            // 
            // tblForm
            // 
            tblForm.AutoSize = true;
            tblForm.ColumnCount = 2;
            tblForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tblForm.Controls.Add(txtName, 1, 0);
            tblForm.Controls.Add(cmbCat, 1, 1);
            tblForm.Controls.Add(numStock, 1, 3);
            tblForm.Controls.Add(cmbStatus, 1, 4);
            tblForm.Controls.Add(txtID, 1, 5);
            tblForm.Controls.Add(numPrice, 1, 2);
            tblForm.Controls.Add(pnlname, 0, 0);
            tblForm.Controls.Add(pnlcategory, 0, 1);
            tblForm.Controls.Add(pnlprice, 0, 2);
            tblForm.Controls.Add(pnlstock, 0, 3);
            tblForm.Controls.Add(pnlstatus, 0, 4);
            tblForm.Controls.Add(pnlID, 0, 5);
            tblForm.Dock = DockStyle.Top;
            tblForm.Location = new Point(20, 25);
            tblForm.Margin = new Padding(3, 4, 3, 4);
            tblForm.Name = "tblForm";
            tblForm.RowCount = 6;
            tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblForm.Size = new Size(760, 300);
            tblForm.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.Control;
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(155, 4);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(602, 27);
            txtName.TabIndex = 0;
            // 
            // cmbCat
            // 
            cmbCat.BackColor = SystemColors.Control;
            cmbCat.Dock = DockStyle.Fill;
            cmbCat.Location = new Point(155, 54);
            cmbCat.Margin = new Padding(3, 4, 3, 4);
            cmbCat.Name = "cmbCat";
            cmbCat.Size = new Size(602, 28);
            cmbCat.TabIndex = 1;
            // 
            // numStock
            // 
            numStock.BackColor = SystemColors.Control;
            numStock.Dock = DockStyle.Fill;
            numStock.Location = new Point(155, 154);
            numStock.Margin = new Padding(3, 4, 3, 4);
            numStock.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numStock.Name = "numStock";
            numStock.Size = new Size(602, 27);
            numStock.TabIndex = 3;
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = SystemColors.Control;
            cmbStatus.Dock = DockStyle.Fill;
            cmbStatus.Location = new Point(155, 204);
            cmbStatus.Margin = new Padding(3, 4, 3, 4);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(602, 28);
            cmbStatus.TabIndex = 4;
            // 
            // txtID
            // 
            txtID.BackColor = SystemColors.Control;
            txtID.Dock = DockStyle.Fill;
            txtID.Location = new Point(155, 254);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.Size = new Size(602, 27);
            txtID.TabIndex = 5;
            // 
            // numPrice
            // 
            numPrice.BackColor = SystemColors.Control;
            numPrice.Dock = DockStyle.Fill;
            numPrice.Location = new Point(155, 104);
            numPrice.Margin = new Padding(3, 4, 3, 4);
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(602, 27);
            numPrice.TabIndex = 2;
            // 
            // pnlname
            // 
            pnlname.AutoSize = true;
            pnlname.Controls.Add(lblname);
            pnlname.Dock = DockStyle.Fill;
            pnlname.Location = new Point(3, 4);
            pnlname.Margin = new Padding(3, 4, 3, 4);
            pnlname.Name = "pnlname";
            pnlname.Size = new Size(146, 42);
            pnlname.TabIndex = 6;
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblname.Location = new Point(14, 8);
            lblname.Name = "lblname";
            lblname.Size = new Size(48, 18);
            lblname.TabIndex = 0;
            lblname.Text = "Name";
            // 
            // pnlcategory
            // 
            pnlcategory.Controls.Add(lblcategory);
            pnlcategory.Dock = DockStyle.Fill;
            pnlcategory.Location = new Point(3, 54);
            pnlcategory.Margin = new Padding(3, 4, 3, 4);
            pnlcategory.Name = "pnlcategory";
            pnlcategory.Size = new Size(146, 42);
            pnlcategory.TabIndex = 7;
            // 
            // lblcategory
            // 
            lblcategory.AutoSize = true;
            lblcategory.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcategory.Location = new Point(14, 10);
            lblcategory.Name = "lblcategory";
            lblcategory.Size = new Size(68, 18);
            lblcategory.TabIndex = 0;
            lblcategory.Text = "Category";
            // 
            // pnlprice
            // 
            pnlprice.Controls.Add(lblprice);
            pnlprice.Dock = DockStyle.Fill;
            pnlprice.Location = new Point(3, 104);
            pnlprice.Margin = new Padding(3, 4, 3, 4);
            pnlprice.Name = "pnlprice";
            pnlprice.Size = new Size(146, 42);
            pnlprice.TabIndex = 8;
            // 
            // lblprice
            // 
            lblprice.AutoSize = true;
            lblprice.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblprice.Location = new Point(14, 8);
            lblprice.Name = "lblprice";
            lblprice.Size = new Size(42, 18);
            lblprice.TabIndex = 0;
            lblprice.Text = "Price";
            // 
            // pnlstock
            // 
            pnlstock.Controls.Add(lblstock);
            pnlstock.Dock = DockStyle.Fill;
            pnlstock.Location = new Point(3, 154);
            pnlstock.Margin = new Padding(3, 4, 3, 4);
            pnlstock.Name = "pnlstock";
            pnlstock.Size = new Size(146, 42);
            pnlstock.TabIndex = 9;
            // 
            // lblstock
            // 
            lblstock.AutoSize = true;
            lblstock.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblstock.Location = new Point(14, 8);
            lblstock.Name = "lblstock";
            lblstock.Size = new Size(47, 18);
            lblstock.TabIndex = 0;
            lblstock.Text = "Stock";
            // 
            // pnlstatus
            // 
            pnlstatus.Controls.Add(lblstatus);
            pnlstatus.Dock = DockStyle.Fill;
            pnlstatus.Location = new Point(3, 204);
            pnlstatus.Margin = new Padding(3, 4, 3, 4);
            pnlstatus.Name = "pnlstatus";
            pnlstatus.Size = new Size(146, 42);
            pnlstatus.TabIndex = 10;
            // 
            // lblstatus
            // 
            lblstatus.AutoSize = true;
            lblstatus.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblstatus.Location = new Point(14, 10);
            lblstatus.Name = "lblstatus";
            lblstatus.Size = new Size(50, 18);
            lblstatus.TabIndex = 0;
            lblstatus.Text = "Status";
            // 
            // pnlID
            // 
            pnlID.Controls.Add(lblID);
            pnlID.Dock = DockStyle.Fill;
            pnlID.Location = new Point(3, 254);
            pnlID.Margin = new Padding(3, 4, 3, 4);
            pnlID.Name = "pnlID";
            pnlID.Size = new Size(146, 42);
            pnlID.TabIndex = 11;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.Location = new Point(14, 8);
            lblID.Name = "lblID";
            lblID.Size = new Size(22, 18);
            lblID.TabIndex = 0;
            lblID.Text = "ID";
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(pnlMain);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductsForm";
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlButtons.ResumeLayout(false);
            pnlButtons.PerformLayout();
            tblForm.ResumeLayout(false);
            tblForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            pnlname.ResumeLayout(false);
            pnlname.PerformLayout();
            pnlcategory.ResumeLayout(false);
            pnlcategory.PerformLayout();
            pnlprice.ResumeLayout(false);
            pnlprice.PerformLayout();
            pnlstock.ResumeLayout(false);
            pnlstock.PerformLayout();
            pnlstatus.ResumeLayout(false);
            pnlstatus.PerformLayout();
            pnlID.ResumeLayout(false);
            pnlID.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TableLayoutPanel tblForm;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbCat;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Panel pnlname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Panel pnlcategory;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.Panel pnlprice;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Panel pnlstock;
        private System.Windows.Forms.Label lblstock;
        private System.Windows.Forms.Panel pnlstatus;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Panel pnlID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
    }
}