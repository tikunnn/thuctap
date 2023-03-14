namespace InventoryManagement.Forms
{
    partial class BillBuyForm
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
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DTNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.DTNgayCN = new System.Windows.Forms.DateTimePicker();
            this.DTNgaytao = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewBuy = new System.Windows.Forms.DataGridView();
            this.TbUpdateby = new System.Windows.Forms.TextBox();
            this.TbCreateby = new System.Windows.Forms.TextBox();
            this.TbIDKho = new System.Windows.Forms.TextBox();
            this.TbIDNV = new System.Windows.Forms.TextBox();
            this.TbIDHDM = new System.Windows.Forms.TextBox();
            this.tbIDNccs = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_NhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_HDMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Kho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Created_By = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Created_At = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update_By = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update_At = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuy)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(424, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 77;
            this.label10.Text = "Tìm kiếm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(479, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 20);
            this.textBox1.TabIndex = 76;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DTNgayNhap
            // 
            this.DTNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTNgayNhap.Location = new System.Drawing.Point(161, 65);
            this.DTNgayNhap.Name = "DTNgayNhap";
            this.DTNgayNhap.Size = new System.Drawing.Size(131, 20);
            this.DTNgayNhap.TabIndex = 75;
            // 
            // DTNgayCN
            // 
            this.DTNgayCN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTNgayCN.Location = new System.Drawing.Point(509, 97);
            this.DTNgayCN.Name = "DTNgayCN";
            this.DTNgayCN.Size = new System.Drawing.Size(131, 20);
            this.DTNgayCN.TabIndex = 74;
            // 
            // DTNgaytao
            // 
            this.DTNgaytao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTNgaytao.Location = new System.Drawing.Point(509, 39);
            this.DTNgaytao.Name = "DTNgaytao";
            this.DTNgaytao.Size = new System.Drawing.Size(131, 20);
            this.DTNgaytao.TabIndex = 73;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewBuy);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 246);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 367);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hóa đơn mua";
            // 
            // dataGridViewBuy
            // 
            this.dataGridViewBuy.AllowUserToOrderColumns = true;
            this.dataGridViewBuy.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_NhaCungCap,
            this.ID_HDMua,
            this.NgayNhap,
            this.ID_NhanVien,
            this.ID_Kho,
            this.Created_By,
            this.Created_At,
            this.Update_By,
            this.Update_At});
            this.dataGridViewBuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBuy.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewBuy.Location = new System.Drawing.Point(3, 19);
            this.dataGridViewBuy.Name = "dataGridViewBuy";
            this.dataGridViewBuy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBuy.Size = new System.Drawing.Size(767, 345);
            this.dataGridViewBuy.TabIndex = 24;
            this.dataGridViewBuy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBuy_CellClick);
            // 
            // TbUpdateby
            // 
            this.TbUpdateby.Location = new System.Drawing.Point(508, 65);
            this.TbUpdateby.Margin = new System.Windows.Forms.Padding(2);
            this.TbUpdateby.Name = "TbUpdateby";
            this.TbUpdateby.Size = new System.Drawing.Size(131, 20);
            this.TbUpdateby.TabIndex = 71;
            // 
            // TbCreateby
            // 
            this.TbCreateby.Location = new System.Drawing.Point(508, 10);
            this.TbCreateby.Margin = new System.Windows.Forms.Padding(2);
            this.TbCreateby.Name = "TbCreateby";
            this.TbCreateby.Size = new System.Drawing.Size(131, 20);
            this.TbCreateby.TabIndex = 70;
            // 
            // TbIDKho
            // 
            this.TbIDKho.Location = new System.Drawing.Point(161, 127);
            this.TbIDKho.Margin = new System.Windows.Forms.Padding(2);
            this.TbIDKho.Name = "TbIDKho";
            this.TbIDKho.Size = new System.Drawing.Size(131, 20);
            this.TbIDKho.TabIndex = 69;
            // 
            // TbIDNV
            // 
            this.TbIDNV.Location = new System.Drawing.Point(161, 97);
            this.TbIDNV.Margin = new System.Windows.Forms.Padding(2);
            this.TbIDNV.Name = "TbIDNV";
            this.TbIDNV.Size = new System.Drawing.Size(131, 20);
            this.TbIDNV.TabIndex = 68;
            // 
            // TbIDHDM
            // 
            this.TbIDHDM.Location = new System.Drawing.Point(161, 36);
            this.TbIDHDM.Margin = new System.Windows.Forms.Padding(2);
            this.TbIDHDM.Name = "TbIDHDM";
            this.TbIDHDM.Size = new System.Drawing.Size(131, 20);
            this.TbIDHDM.TabIndex = 67;
            // 
            // tbIDNccs
            // 
            this.tbIDNccs.Location = new System.Drawing.Point(161, 7);
            this.tbIDNccs.Margin = new System.Windows.Forms.Padding(2);
            this.tbIDNccs.Name = "tbIDNccs";
            this.tbIDNccs.Size = new System.Drawing.Size(131, 20);
            this.tbIDNccs.TabIndex = 66;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(218, 170);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 30);
            this.btnDelete.TabIndex = 63;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(139, 170);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(74, 30);
            this.btnReset.TabIndex = 64;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(61, 170);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 30);
            this.btnAdd.TabIndex = 65;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(423, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 62;
            this.label9.Text = "Ngày cập nhật";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(423, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "Người cập nhật";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(423, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Ngày tạo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Người tạo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "ID kho";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "ID nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Ngày Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "ID Hóa đơn mua";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "ID Nhà Cung Cấp";
            // 
            // ID_NhaCungCap
            // 
            this.ID_NhaCungCap.DataPropertyName = "ID_NhaCungCap";
            this.ID_NhaCungCap.HeaderText = "ID Nhà Cung Cấp";
            this.ID_NhaCungCap.Name = "ID_NhaCungCap";
            this.ID_NhaCungCap.Width = 80;
            // 
            // ID_HDMua
            // 
            this.ID_HDMua.DataPropertyName = "ID_HDMua";
            this.ID_HDMua.HeaderText = "ID Hoá Đơn Mua";
            this.ID_HDMua.Name = "ID_HDMua";
            this.ID_HDMua.Width = 80;
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày Nhập";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.Width = 80;
            // 
            // ID_NhanVien
            // 
            this.ID_NhanVien.DataPropertyName = "ID_NhanVien";
            this.ID_NhanVien.HeaderText = "ID Nhân Viên";
            this.ID_NhanVien.Name = "ID_NhanVien";
            this.ID_NhanVien.Width = 80;
            // 
            // ID_Kho
            // 
            this.ID_Kho.DataPropertyName = "ID_Kho";
            this.ID_Kho.HeaderText = "ID Kho";
            this.ID_Kho.Name = "ID_Kho";
            this.ID_Kho.Width = 80;
            // 
            // Created_By
            // 
            this.Created_By.DataPropertyName = "Created_By";
            this.Created_By.HeaderText = "Người tạo";
            this.Created_By.Name = "Created_By";
            this.Created_By.Width = 80;
            // 
            // Created_At
            // 
            this.Created_At.DataPropertyName = "Created_At";
            this.Created_At.HeaderText = "Ngày tạo ";
            this.Created_At.Name = "Created_At";
            this.Created_At.Width = 80;
            // 
            // Update_By
            // 
            this.Update_By.DataPropertyName = "Update_By";
            this.Update_By.HeaderText = "Người Cập nhật";
            this.Update_By.Name = "Update_By";
            this.Update_By.Width = 80;
            // 
            // Update_At
            // 
            this.Update_At.DataPropertyName = "Update_At";
            this.Update_At.HeaderText = "Ngày Cập Nhật";
            this.Update_At.Name = "Update_At";
            this.Update_At.Width = 80;
            // 
            // BillBuyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(773, 613);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DTNgayNhap);
            this.Controls.Add(this.DTNgayCN);
            this.Controls.Add(this.DTNgaytao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TbUpdateby);
            this.Controls.Add(this.TbCreateby);
            this.Controls.Add(this.TbIDKho);
            this.Controls.Add(this.TbIDNV);
            this.Controls.Add(this.TbIDHDM);
            this.Controls.Add(this.tbIDNccs);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BillBuyForm";
            this.Text = "BillBuyForm";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker DTNgayNhap;
        private System.Windows.Forms.DateTimePicker DTNgayCN;
        private System.Windows.Forms.DateTimePicker DTNgaytao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewBuy;
        private System.Windows.Forms.TextBox TbUpdateby;
        private System.Windows.Forms.TextBox TbCreateby;
        private System.Windows.Forms.TextBox TbIDKho;
        private System.Windows.Forms.TextBox TbIDNV;
        private System.Windows.Forms.TextBox TbIDHDM;
        private System.Windows.Forms.TextBox tbIDNccs;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_NhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_HDMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Kho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created_By;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created_At;
        private System.Windows.Forms.DataGridViewTextBoxColumn Update_By;
        private System.Windows.Forms.DataGridViewTextBoxColumn Update_At;
    }
}