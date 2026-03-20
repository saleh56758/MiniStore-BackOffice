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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.tblForm = new System.Windows.Forms.TableLayoutPanel();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.cmbProductCategory = new System.Windows.Forms.ComboBox();
            this.nudProductStock = new System.Windows.Forms.NumericUpDown();
            this.cmbProductStatus = new System.Windows.Forms.ComboBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pnlname = new System.Windows.Forms.Panel();
            this.lblname = new System.Windows.Forms.Label();
            this.pnlcategory = new System.Windows.Forms.Panel();
            this.lblcategory = new System.Windows.Forms.Label();
            this.pnlprice = new System.Windows.Forms.Panel();
            this.lblprice = new System.Windows.Forms.Label();
            this.pnlstock = new System.Windows.Forms.Panel();
            this.lblstock = new System.Windows.Forms.Label();
            this.pnlstatus = new System.Windows.Forms.Panel();
            this.lblstatus = new System.Windows.Forms.Label();
            this.pnlID = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.tblForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.pnlname.SuspendLayout();
            this.pnlcategory.SuspendLayout();
            this.pnlprice.SuspendLayout();
            this.pnlstock.SuspendLayout();
            this.pnlstatus.SuspendLayout();
            this.pnlID.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlButtons);
            this.pnlMain.Controls.Add(this.tblForm);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMain.Size = new System.Drawing.Size(800, 450);
            this.pnlMain.TabIndex = 3;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnsave);
            this.pnlButtons.Controls.Add(this.btncancel);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(20, 336);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(760, 94);
            this.pnlButtons.TabIndex = 2;
            // 
            // btnsave
            // 
            this.btnsave.AutoSize = true;
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Image = global::WindowsFormsApp1.Properties.Resources.device_floppy1;
            this.btnsave.Location = new System.Drawing.Point(631, 22);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(107, 54);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "Save";
            this.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            this.btncancel.AutoSize = true;
            this.btncancel.FlatAppearance.BorderSize = 0;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Image = global::WindowsFormsApp1.Properties.Resources.cancel;
            this.btncancel.Location = new System.Drawing.Point(476, 22);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(107, 54);
            this.btncancel.TabIndex = 0;
            this.btncancel.Text = "Cancel";
            this.btncancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // tblForm
            // 
            this.tblForm.AutoSize = true;
            this.tblForm.ColumnCount = 2;
            this.tblForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblForm.Controls.Add(this.txtProductName, 1, 0);
            this.tblForm.Controls.Add(this.cmbProductCategory, 1, 1);
            this.tblForm.Controls.Add(this.nudProductStock, 1, 3);
            this.tblForm.Controls.Add(this.cmbProductStatus, 1, 4);
            this.tblForm.Controls.Add(this.txtProductId, 1, 5);
            this.tblForm.Controls.Add(this.numericUpDown1, 1, 2);
            this.tblForm.Controls.Add(this.pnlname, 0, 0);
            this.tblForm.Controls.Add(this.pnlcategory, 0, 1);
            this.tblForm.Controls.Add(this.pnlprice, 0, 2);
            this.tblForm.Controls.Add(this.pnlstock, 0, 3);
            this.tblForm.Controls.Add(this.pnlstatus, 0, 4);
            this.tblForm.Controls.Add(this.pnlID, 0, 5);
            this.tblForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblForm.Location = new System.Drawing.Point(20, 20);
            this.tblForm.Name = "tblForm";
            this.tblForm.RowCount = 6;
            this.tblForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblForm.Size = new System.Drawing.Size(760, 240);
            this.tblForm.TabIndex = 0;
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.SystemColors.Control;
            this.txtProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProductName.Location = new System.Drawing.Point(155, 3);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(602, 22);
            this.txtProductName.TabIndex = 1;
            // 
            // cmbProductCategory
            // 
            this.cmbProductCategory.BackColor = System.Drawing.SystemColors.Control;
            this.cmbProductCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbProductCategory.Location = new System.Drawing.Point(155, 43);
            this.cmbProductCategory.Name = "cmbProductCategory";
            this.cmbProductCategory.Size = new System.Drawing.Size(602, 24);
            this.cmbProductCategory.TabIndex = 3;
            // 
            // nudProductStock
            // 
            this.nudProductStock.BackColor = System.Drawing.SystemColors.Control;
            this.nudProductStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudProductStock.Location = new System.Drawing.Point(155, 123);
            this.nudProductStock.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudProductStock.Name = "nudProductStock";
            this.nudProductStock.Size = new System.Drawing.Size(602, 22);
            this.nudProductStock.TabIndex = 7;
            // 
            // cmbProductStatus
            // 
            this.cmbProductStatus.BackColor = System.Drawing.SystemColors.Control;
            this.cmbProductStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbProductStatus.Location = new System.Drawing.Point(155, 163);
            this.cmbProductStatus.Name = "cmbProductStatus";
            this.cmbProductStatus.Size = new System.Drawing.Size(602, 24);
            this.cmbProductStatus.TabIndex = 9;
            // 
            // txtProductId
            // 
            this.txtProductId.BackColor = System.Drawing.SystemColors.Control;
            this.txtProductId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProductId.Location = new System.Drawing.Point(155, 203);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(602, 22);
            this.txtProductId.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.Control;
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown1.Location = new System.Drawing.Point(155, 83);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(602, 22);
            this.numericUpDown1.TabIndex = 12;
            // 
            // pnlname
            // 
            this.pnlname.AutoSize = true;
            this.pnlname.Controls.Add(this.lblname);
            this.pnlname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlname.Location = new System.Drawing.Point(3, 3);
            this.pnlname.Name = "pnlname";
            this.pnlname.Size = new System.Drawing.Size(146, 34);
            this.pnlname.TabIndex = 13;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(14, 6);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(48, 18);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Name";
            // 
            // pnlcategory
            // 
            this.pnlcategory.Controls.Add(this.lblcategory);
            this.pnlcategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlcategory.Location = new System.Drawing.Point(3, 43);
            this.pnlcategory.Name = "pnlcategory";
            this.pnlcategory.Size = new System.Drawing.Size(146, 34);
            this.pnlcategory.TabIndex = 14;
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategory.Location = new System.Drawing.Point(14, 8);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(68, 18);
            this.lblcategory.TabIndex = 0;
            this.lblcategory.Text = "Category";
            // 
            // pnlprice
            // 
            this.pnlprice.Controls.Add(this.lblprice);
            this.pnlprice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlprice.Location = new System.Drawing.Point(3, 83);
            this.pnlprice.Name = "pnlprice";
            this.pnlprice.Size = new System.Drawing.Size(146, 34);
            this.pnlprice.TabIndex = 15;
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(14, 6);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(42, 18);
            this.lblprice.TabIndex = 0;
            this.lblprice.Text = "Price";
            // 
            // pnlstock
            // 
            this.pnlstock.Controls.Add(this.lblstock);
            this.pnlstock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlstock.Location = new System.Drawing.Point(3, 123);
            this.pnlstock.Name = "pnlstock";
            this.pnlstock.Size = new System.Drawing.Size(146, 34);
            this.pnlstock.TabIndex = 16;
            // 
            // lblstock
            // 
            this.lblstock.AutoSize = true;
            this.lblstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstock.Location = new System.Drawing.Point(14, 6);
            this.lblstock.Name = "lblstock";
            this.lblstock.Size = new System.Drawing.Size(47, 18);
            this.lblstock.TabIndex = 0;
            this.lblstock.Text = "Stock";
            // 
            // pnlstatus
            // 
            this.pnlstatus.Controls.Add(this.lblstatus);
            this.pnlstatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlstatus.Location = new System.Drawing.Point(3, 163);
            this.pnlstatus.Name = "pnlstatus";
            this.pnlstatus.Size = new System.Drawing.Size(146, 34);
            this.pnlstatus.TabIndex = 17;
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(14, 8);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(50, 18);
            this.lblstatus.TabIndex = 0;
            this.lblstatus.Text = "Status";
            // 
            // pnlID
            // 
            this.pnlID.Controls.Add(this.lblID);
            this.pnlID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlID.Location = new System.Drawing.Point(3, 203);
            this.pnlID.Name = "pnlID";
            this.pnlID.Size = new System.Drawing.Size(146, 34);
            this.pnlID.TabIndex = 18;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(14, 6);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(22, 18);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMain);
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.tblForm.ResumeLayout(false);
            this.tblForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.pnlname.ResumeLayout(false);
            this.pnlname.PerformLayout();
            this.pnlcategory.ResumeLayout(false);
            this.pnlcategory.PerformLayout();
            this.pnlprice.ResumeLayout(false);
            this.pnlprice.PerformLayout();
            this.pnlstock.ResumeLayout(false);
            this.pnlstock.PerformLayout();
            this.pnlstatus.ResumeLayout(false);
            this.pnlstatus.PerformLayout();
            this.pnlID.ResumeLayout(false);
            this.pnlID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TableLayoutPanel tblForm;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.ComboBox cmbProductCategory;
        private System.Windows.Forms.NumericUpDown nudProductStock;
        private System.Windows.Forms.ComboBox cmbProductStatus;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
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