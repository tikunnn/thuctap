namespace InventoryManagement
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panelHome = new System.Windows.Forms.Panel();
            this.lbUserName = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnCusSupp = new System.Windows.Forms.Button();
            this.btnSpendingManagement = new System.Windows.Forms.Button();
            this.btnStaffManagement = new System.Windows.Forms.Button();
            this.btnCommodityManagement = new System.Windows.Forms.Button();
            this.ptbPicUser = new System.Windows.Forms.PictureBox();
            this.pnScreen = new System.Windows.Forms.Panel();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPicUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.FloralWhite;
            this.panelHome.Controls.Add(this.lbUserName);
            this.panelHome.Controls.Add(this.btnLogOut);
            this.panelHome.Controls.Add(this.btnCusSupp);
            this.panelHome.Controls.Add(this.btnSpendingManagement);
            this.panelHome.Controls.Add(this.btnStaffManagement);
            this.panelHome.Controls.Add(this.btnCommodityManagement);
            this.panelHome.Controls.Add(this.ptbPicUser);
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Margin = new System.Windows.Forms.Padding(2);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(234, 624);
            this.panelHome.TabIndex = 0;
            // 
            // lbUserName
            // 
            this.lbUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUserName.AutoSize = true;
            this.lbUserName.BackColor = System.Drawing.Color.Transparent;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.Black;
            this.lbUserName.Location = new System.Drawing.Point(20, 184);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(108, 17);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "Tên người dùng";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 552);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(234, 55);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnCusSupp
            // 
            this.btnCusSupp.BackColor = System.Drawing.Color.SandyBrown;
            this.btnCusSupp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCusSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCusSupp.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusSupp.Image = ((System.Drawing.Image)(resources.GetObject("btnCusSupp.Image")));
            this.btnCusSupp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCusSupp.Location = new System.Drawing.Point(0, 420);
            this.btnCusSupp.Margin = new System.Windows.Forms.Padding(2);
            this.btnCusSupp.Name = "btnCusSupp";
            this.btnCusSupp.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCusSupp.Size = new System.Drawing.Size(234, 55);
            this.btnCusSupp.TabIndex = 4;
            this.btnCusSupp.Text = "Quản lý cung cầu";
            this.btnCusSupp.UseVisualStyleBackColor = false;
            this.btnCusSupp.Click += new System.EventHandler(this.btnCusSupp_Click);
            // 
            // btnSpendingManagement
            // 
            this.btnSpendingManagement.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSpendingManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpendingManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpendingManagement.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpendingManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnSpendingManagement.Image")));
            this.btnSpendingManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpendingManagement.Location = new System.Drawing.Point(0, 360);
            this.btnSpendingManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpendingManagement.Name = "btnSpendingManagement";
            this.btnSpendingManagement.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSpendingManagement.Size = new System.Drawing.Size(234, 55);
            this.btnSpendingManagement.TabIndex = 3;
            this.btnSpendingManagement.Text = "Quản lý chi tiêu";
            this.btnSpendingManagement.UseVisualStyleBackColor = false;
            this.btnSpendingManagement.Click += new System.EventHandler(this.btnSpendingManagement_Click);
            // 
            // btnStaffManagement
            // 
            this.btnStaffManagement.BackColor = System.Drawing.Color.SandyBrown;
            this.btnStaffManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaffManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffManagement.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnStaffManagement.Image")));
            this.btnStaffManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffManagement.Location = new System.Drawing.Point(0, 300);
            this.btnStaffManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnStaffManagement.Name = "btnStaffManagement";
            this.btnStaffManagement.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnStaffManagement.Size = new System.Drawing.Size(234, 55);
            this.btnStaffManagement.TabIndex = 2;
            this.btnStaffManagement.Text = "Quản lý nhân viên";
            this.btnStaffManagement.UseVisualStyleBackColor = false;
            this.btnStaffManagement.Click += new System.EventHandler(this.btnStaffManagement_Click);
            // 
            // btnCommodityManagement
            // 
            this.btnCommodityManagement.BackColor = System.Drawing.Color.SandyBrown;
            this.btnCommodityManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCommodityManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCommodityManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommodityManagement.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommodityManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnCommodityManagement.Image")));
            this.btnCommodityManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCommodityManagement.Location = new System.Drawing.Point(0, 240);
            this.btnCommodityManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnCommodityManagement.Name = "btnCommodityManagement";
            this.btnCommodityManagement.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCommodityManagement.Size = new System.Drawing.Size(234, 55);
            this.btnCommodityManagement.TabIndex = 1;
            this.btnCommodityManagement.Text = "Quản lý hàng hóa";
            this.btnCommodityManagement.UseVisualStyleBackColor = false;
            this.btnCommodityManagement.Click += new System.EventHandler(this.btnCommodityManagement_Click);
            // 
            // ptbPicUser
            // 
            this.ptbPicUser.Image = ((System.Drawing.Image)(resources.GetObject("ptbPicUser.Image")));
            this.ptbPicUser.Location = new System.Drawing.Point(56, 26);
            this.ptbPicUser.Margin = new System.Windows.Forms.Padding(2);
            this.ptbPicUser.Name = "ptbPicUser";
            this.ptbPicUser.Size = new System.Drawing.Size(122, 132);
            this.ptbPicUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPicUser.TabIndex = 1;
            this.ptbPicUser.TabStop = false;
            // 
            // pnScreen
            // 
            this.pnScreen.BackColor = System.Drawing.Color.Linen;
            this.pnScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnScreen.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnScreen.Location = new System.Drawing.Point(233, 0);
            this.pnScreen.Margin = new System.Windows.Forms.Padding(2);
            this.pnScreen.Name = "pnScreen";
            this.pnScreen.Size = new System.Drawing.Size(727, 624);
            this.pnScreen.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 624);
            this.Controls.Add(this.pnScreen);
            this.Controls.Add(this.panelHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPicUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.PictureBox ptbPicUser;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnCusSupp;
        private System.Windows.Forms.Button btnSpendingManagement;
        private System.Windows.Forms.Button btnStaffManagement;
        private System.Windows.Forms.Button btnCommodityManagement;
        private System.Windows.Forms.Panel pnScreen;
        public System.Windows.Forms.Label lbUserName;
    }
}