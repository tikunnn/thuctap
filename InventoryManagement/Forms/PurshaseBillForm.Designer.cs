namespace InventoryManagement.Forms
{
    partial class PurshaseBillForm
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
            this.dgvPurchaseBill = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseBill)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPurchaseBill
            // 
            this.dgvPurchaseBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseBill.Location = new System.Drawing.Point(34, 158);
            this.dgvPurchaseBill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPurchaseBill.Name = "dgvPurchaseBill";
            this.dgvPurchaseBill.RowHeadersWidth = 51;
            this.dgvPurchaseBill.RowTemplate.Height = 24;
            this.dgvPurchaseBill.Size = new System.Drawing.Size(614, 281);
            this.dgvPurchaseBill.TabIndex = 0;
            // 
            // PurshaseBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(726, 567);
            this.Controls.Add(this.dgvPurchaseBill);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PurshaseBillForm";
            this.Text = "PurshaseBillForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPurchaseBill;
    }
}