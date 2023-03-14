namespace InventoryManagement.Forms
{
    partial class CustomerSupplierManagement
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
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnSuppiler = new System.Windows.Forms.Button();
            this.pnChild = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Location = new System.Drawing.Point(153, 10);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(113, 30);
            this.btnCustomer.TabIndex = 5;
            this.btnCustomer.Text = "Khách hàng";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnSuppiler
            // 
            this.btnSuppiler.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSuppiler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSuppiler.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSuppiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppiler.Location = new System.Drawing.Point(34, 10);
            this.btnSuppiler.Name = "btnSuppiler";
            this.btnSuppiler.Size = new System.Drawing.Size(113, 30);
            this.btnSuppiler.TabIndex = 4;
            this.btnSuppiler.Text = "Nhà cung cấp";
            this.btnSuppiler.UseVisualStyleBackColor = false;
            this.btnSuppiler.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // pnChild
            // 
            this.pnChild.BackColor = System.Drawing.Color.Linen;
            this.pnChild.Location = new System.Drawing.Point(0, 46);
            this.pnChild.Margin = new System.Windows.Forms.Padding(0);
            this.pnChild.Name = "pnChild";
            this.pnChild.Size = new System.Drawing.Size(726, 572);
            this.pnChild.TabIndex = 3;
            // 
            // CustomerSupplierManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(727, 624);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnSuppiler);
            this.Controls.Add(this.pnChild);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerSupplierManagement";
            this.Text = "CustomerSupplierManagement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnSuppiler;
        private System.Windows.Forms.Panel pnChild;
    }
}