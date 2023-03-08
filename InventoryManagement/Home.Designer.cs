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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.panelHome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelHome.Controls.Add(this.lbUserName);
            this.panelHome.Controls.Add(this.btnLogOut);
            this.panelHome.Controls.Add(this.button4);
            this.panelHome.Controls.Add(this.button3);
            this.panelHome.Controls.Add(this.btnStaffManagement);
            this.panelHome.Controls.Add(this.btnCommodityManagement);
            this.panelHome.Controls.Add(this.ptbPicUser);
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(312, 768);
            this.panelHome.TabIndex = 0;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbUserName.Location = new System.Drawing.Point(27, 226);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(123, 20);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "Tên người dùng";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(0, 680);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(312, 68);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 517);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(312, 68);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 443);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(312, 68);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnStaffManagement
            // 
            this.btnStaffManagement.Location = new System.Drawing.Point(0, 369);
            this.btnStaffManagement.Name = "btnStaffManagement";
            this.btnStaffManagement.Size = new System.Drawing.Size(312, 68);
            this.btnStaffManagement.TabIndex = 2;
            this.btnStaffManagement.Text = "Quản lý nhân viên";
            this.btnStaffManagement.UseVisualStyleBackColor = true;
            this.btnStaffManagement.Click += new System.EventHandler(this.btnStaffManagement_Click);
            // 
            // btnCommodityManagement
            // 
            this.btnCommodityManagement.Location = new System.Drawing.Point(0, 295);
            this.btnCommodityManagement.Name = "btnCommodityManagement";
            this.btnCommodityManagement.Size = new System.Drawing.Size(312, 68);
            this.btnCommodityManagement.TabIndex = 1;
            this.btnCommodityManagement.Text = "Quản lý hàng hóa";
            this.btnCommodityManagement.UseVisualStyleBackColor = true;
            this.btnCommodityManagement.Click += new System.EventHandler(this.btnCommodityManagement_Click);
            // 
            // ptbPicUser
            // 
            this.ptbPicUser.Image = ((System.Drawing.Image)(resources.GetObject("ptbPicUser.Image")));
            this.ptbPicUser.Location = new System.Drawing.Point(74, 32);
            this.ptbPicUser.Name = "ptbPicUser";
            this.ptbPicUser.Size = new System.Drawing.Size(163, 163);
            this.ptbPicUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPicUser.TabIndex = 1;
            this.ptbPicUser.TabStop = false;
            // 
            // pnScreen
            // 
            this.pnScreen.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnScreen.Location = new System.Drawing.Point(311, 0);
            this.pnScreen.Name = "pnScreen";
            this.pnScreen.Size = new System.Drawing.Size(969, 768);
            this.pnScreen.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.pnScreen);
            this.Controls.Add(this.panelHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnStaffManagement;
        private System.Windows.Forms.Button btnCommodityManagement;
        private System.Windows.Forms.Panel pnScreen;
        private System.Windows.Forms.Label lbUserName;
    }
}