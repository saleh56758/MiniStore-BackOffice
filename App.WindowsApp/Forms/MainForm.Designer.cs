namespace App.WindowsApp.Forms

{
    partial class MainForm:Form
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
            pnlheader = new Panel();
            flpright = new FlowLayoutPanel();
            adminpic = new PictureBox();
            Admin = new Label();
            flpleft = new FlowLayoutPanel();
            titlepic = new PictureBox();
            title = new Label();
            pnlContent = new Panel();
            btndashboard = new Button();
            btnproducts = new Button();
            btnlogs = new Button();
            btnorders = new Button();
            btnreports = new Button();
            btnsync = new Button();
            btnsettings = new Button();
            pnlsidebar = new Panel();
            statusStrip = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            pnlheader.SuspendLayout();
            flpright.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)adminpic).BeginInit();
            flpleft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)titlepic).BeginInit();
            pnlsidebar.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // pnlheader
            // 
            pnlheader.Controls.Add(flpright);
            pnlheader.Controls.Add(flpleft);
            pnlheader.Dock = DockStyle.Top;
            pnlheader.Location = new Point(0, 0);
            pnlheader.Name = "pnlheader";
            pnlheader.Size = new Size(1009, 93);
            pnlheader.TabIndex = 0;
            // 
            // flpright
            // 
            flpright.Controls.Add(adminpic);
            flpright.Controls.Add(Admin);
            flpright.Dock = DockStyle.Right;
            flpright.Location = new Point(848, 0);
            flpright.Name = "flpright";
            flpright.Size = new Size(161, 93);
            flpright.TabIndex = 1;
            flpright.Paint += flowLayoutPanel1_Paint;
            // 
            // adminpic
            // 
            adminpic.Image = Properties.Resources.user;
            adminpic.Location = new Point(3, 3);
            adminpic.Name = "adminpic";
            adminpic.Size = new Size(59, 50);
            adminpic.SizeMode = PictureBoxSizeMode.CenterImage;
            adminpic.TabIndex = 1;
            adminpic.TabStop = false;
            // 
            // Admin
            // 
            Admin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Admin.AutoSize = true;
            Admin.Location = new Point(68, 0);
            Admin.Name = "Admin";
            Admin.Size = new Size(49, 56);
            Admin.TabIndex = 2;
            Admin.Text = "Admin";
            Admin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flpleft
            // 
            flpleft.Controls.Add(titlepic);
            flpleft.Controls.Add(title);
            flpleft.Dock = DockStyle.Left;
            flpleft.Location = new Point(0, 0);
            flpleft.Name = "flpleft";
            flpleft.Size = new Size(246, 93);
            flpleft.TabIndex = 0;
            // 
            // titlepic
            // 
            titlepic.Image = Properties.Resources.store;
            titlepic.Location = new Point(3, 3);
            titlepic.Name = "titlepic";
            titlepic.Size = new Size(81, 50);
            titlepic.SizeMode = PictureBoxSizeMode.CenterImage;
            titlepic.TabIndex = 0;
            titlepic.TabStop = false;
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            title.AutoSize = true;
            title.Location = new Point(90, 0);
            title.Name = "title";
            title.Size = new Size(144, 56);
            title.TabIndex = 3;
            title.Text = "Ministore-Backoffice";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(233, 93);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(776, 589);
            pnlContent.TabIndex = 4;
            // 
            // btndashboard
            // 
            btndashboard.AutoSize = true;
            btndashboard.FlatAppearance.BorderSize = 0;
            btndashboard.FlatStyle = FlatStyle.Flat;
            btndashboard.Image = Properties.Resources.dashboard;
            btndashboard.Location = new Point(30, 60);
            btndashboard.Name = "btndashboard";
            btndashboard.Size = new Size(200, 40);
            btndashboard.TabIndex = 0;
            btndashboard.Text = "Dashboard";
            btndashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btndashboard.UseVisualStyleBackColor = true;
            btndashboard.Click += btn_dashboard_Click;
            // 
            // btnproducts
            // 
            btnproducts.FlatAppearance.BorderSize = 0;
            btnproducts.FlatStyle = FlatStyle.Flat;
            btnproducts.Image = Properties.Resources.products;
            btnproducts.Location = new Point(30, 120);
            btnproducts.Name = "btnproducts";
            btnproducts.Size = new Size(200, 40);
            btnproducts.TabIndex = 2;
            btnproducts.Text = "Products";
            btnproducts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnproducts.UseVisualStyleBackColor = true;
            btnproducts.Click += btn_products_Click;
            // 
            // btnlogs
            // 
            btnlogs.FlatAppearance.BorderSize = 0;
            btnlogs.FlatStyle = FlatStyle.Flat;
            btnlogs.Image = Properties.Resources.logs;
            btnlogs.Location = new Point(30, 360);
            btnlogs.Name = "btnlogs";
            btnlogs.Size = new Size(200, 40);
            btnlogs.TabIndex = 3;
            btnlogs.Text = "Logs";
            btnlogs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlogs.UseVisualStyleBackColor = true;
            btnlogs.Click += btn_Log_Click;
            // 
            // btnorders
            // 
            btnorders.FlatAppearance.BorderSize = 0;
            btnorders.FlatStyle = FlatStyle.Flat;
            btnorders.Image = Properties.Resources.truck;
            btnorders.Location = new Point(30, 180);
            btnorders.Name = "btnorders";
            btnorders.Size = new Size(200, 40);
            btnorders.TabIndex = 4;
            btnorders.Text = "Orders";
            btnorders.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnorders.UseVisualStyleBackColor = true;
            btnorders.Click += btn_Orders_Click;
            // 
            // btnreports
            // 
            btnreports.FlatAppearance.BorderSize = 0;
            btnreports.FlatStyle = FlatStyle.Flat;
            btnreports.Image = Properties.Resources.reportanalytics;
            btnreports.Location = new Point(30, 240);
            btnreports.Name = "btnreports";
            btnreports.Size = new Size(200, 40);
            btnreports.TabIndex = 1;
            btnreports.Text = "Reports";
            btnreports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnreports.UseVisualStyleBackColor = true;
            btnreports.Click += btn_Reports_Click;
            // 
            // btnsync
            // 
            btnsync.FlatAppearance.BorderSize = 0;
            btnsync.FlatStyle = FlatStyle.Flat;
            btnsync.Image = Properties.Resources.refresh;
            btnsync.Location = new Point(30, 300);
            btnsync.Name = "btnsync";
            btnsync.Size = new Size(200, 40);
            btnsync.TabIndex = 5;
            btnsync.Text = "Sync";
            btnsync.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnsync.UseVisualStyleBackColor = true;
            btnsync.Click += bt_Sync_Click;
            // 
            // btnsettings
            // 
            btnsettings.FlatAppearance.BorderSize = 0;
            btnsettings.FlatStyle = FlatStyle.Flat;
            btnsettings.Image = Properties.Resources.settings;
            btnsettings.Location = new Point(30, 420);
            btnsettings.Name = "btnsettings";
            btnsettings.Size = new Size(200, 40);
            btnsettings.TabIndex = 6;
            btnsettings.Text = "Settings";
            btnsettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnsettings.UseVisualStyleBackColor = true;
            btnsettings.Click += btn_Settings_Click;
            // 
            // pnlsidebar
            // 
            pnlsidebar.AutoSize = true;
            pnlsidebar.Controls.Add(btnsettings);
            pnlsidebar.Controls.Add(btnsync);
            pnlsidebar.Controls.Add(btnreports);
            pnlsidebar.Controls.Add(btnorders);
            pnlsidebar.Controls.Add(btnlogs);
            pnlsidebar.Controls.Add(btnproducts);
            pnlsidebar.Controls.Add(btndashboard);
            pnlsidebar.Dock = DockStyle.Left;
            pnlsidebar.Location = new Point(0, 93);
            pnlsidebar.Name = "pnlsidebar";
            pnlsidebar.Size = new Size(233, 589);
            pnlsidebar.TabIndex = 3;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip.Location = new Point(0, 682);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1009, 26);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "Ready";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(59, 20);
            toolStripStatusLabel1.Text = "Ready...";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 708);
            Controls.Add(pnlContent);
            Controls.Add(pnlsidebar);
            Controls.Add(statusStrip);
            Controls.Add(pnlheader);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            WindowState = FormWindowState.Maximized;
            Load += mainform_Load;
            pnlheader.ResumeLayout(false);
            flpright.ResumeLayout(false);
            flpright.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)adminpic).EndInit();
            flpleft.ResumeLayout(false);
            flpleft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)titlepic).EndInit();
            pnlsidebar.ResumeLayout(false);
            pnlsidebar.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlheader;
        private System.Windows.Forms.FlowLayoutPanel flpright;
        private System.Windows.Forms.FlowLayoutPanel flpleft;
        private System.Windows.Forms.PictureBox adminpic;
        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.PictureBox titlepic;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btndashboard;
        private System.Windows.Forms.Button btnproducts;
        private System.Windows.Forms.Button btnlogs;
        private System.Windows.Forms.Button btnorders;
        private System.Windows.Forms.Button btnreports;
        private System.Windows.Forms.Button btnsync;
        private System.Windows.Forms.Button btnsettings;
        private System.Windows.Forms.Panel pnlsidebar;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}