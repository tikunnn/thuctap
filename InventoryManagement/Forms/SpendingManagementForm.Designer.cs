namespace InventoryManagement.Forms
{
    partial class SpendingManagementForm
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
            this.btnPurchaseBill = new System.Windows.Forms.Button();
            this.btnPurchaseSell = new System.Windows.Forms.Button();
            this.pnScreen = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnPurchaseBill
            // 
            this.btnPurchaseBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseBill.Location = new System.Drawing.Point(34, 10);
            this.btnPurchaseBill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPurchaseBill.Name = "btnPurchaseBill";
            this.btnPurchaseBill.Size = new System.Drawing.Size(113, 30);
            this.btnPurchaseBill.TabIndex = 0;
            this.btnPurchaseBill.Text = "Hóa đơn mua";
            this.btnPurchaseBill.UseVisualStyleBackColor = true;
            this.btnPurchaseBill.Click += new System.EventHandler(this.btnPurchaseBill_Click);
            // 
            // btnPurchaseSell
            // 
            this.btnPurchaseSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseSell.Location = new System.Drawing.Point(152, 10);
            this.btnPurchaseSell.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPurchaseSell.Name = "btnPurchaseSell";
            this.btnPurchaseSell.Size = new System.Drawing.Size(113, 30);
            this.btnPurchaseSell.TabIndex = 0;
            this.btnPurchaseSell.Text = "Hóa đơn bán";
            this.btnPurchaseSell.UseVisualStyleBackColor = true;
            this.btnPurchaseSell.Click += new System.EventHandler(this.btnPurchaseSell_Click);
            // 
            // pnScreen
            // 
            this.pnScreen.BackColor = System.Drawing.Color.Linen;
            this.pnScreen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnScreen.Location = new System.Drawing.Point(0, 57);
            this.pnScreen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnScreen.Name = "pnScreen";
            this.pnScreen.Size = new System.Drawing.Size(726, 567);
            this.pnScreen.TabIndex = 1;
            // 
            // SpendingManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(726, 624);
            this.Controls.Add(this.pnScreen);
            this.Controls.Add(this.btnPurchaseSell);
            this.Controls.Add(this.btnPurchaseBill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SpendingManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpendingManagementForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPurchaseBill;
        private System.Windows.Forms.Button btnPurchaseSell;
        private System.Windows.Forms.Panel pnScreen;
    }
}