namespace InventoryManagement.Forms
{
    partial class BillSellForm
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
            this.DTNgayBan = new System.Windows.Forms.DateTimePicker();
            this.DTNgayCN = new System.Windows.Forms.DateTimePicker();
            this.DTNgaytao = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_HoaDonBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Kho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Created_By = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Created_At = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update_By = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update_At = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TbUpdateby = new System.Windows.Forms.TextBox();
            this.TbCreateby = new System.Windows.Forms.TextBox();
            this.TbIDKho = new System.Windows.Forms.TextBox();
            this.TbIDNV = new System.Windows.Forms.TextBox();
            this.TbIDHDB = new System.Windows.Forms.TextBox();
            this.tbIDKH = new System.Windows.Forms.TextBox();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(426, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "Tìm kiếm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(426, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 52;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DTNgayBan
            // 
            this.DTNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTNgayBan.Location = new System.Drawing.Point(161, 72);
            this.DTNgayBan.Name = "DTNgayBan";
            this.DTNgayBan.Size = new System.Drawing.Size(131, 20);
            this.DTNgayBan.TabIndex = 51;
            // 
            // DTNgayCN
            // 
            this.DTNgayCN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTNgayCN.Location = new System.Drawing.Point(509, 104);
            this.DTNgayCN.Name = "DTNgayCN";
            this.DTNgayCN.Size = new System.Drawing.Size(131, 20);
            this.DTNgayCN.TabIndex = 50;
            // 
            // DTNgaytao
            // 
            this.DTNgaytao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTNgaytao.Location = new System.Drawing.Point(509, 46);
            this.DTNgaytao.Name = "DTNgaytao";
            this.DTNgaytao.Size = new System.Drawing.Size(131, 20);
            this.DTNgaytao.TabIndex = 49;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 243);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 367);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hóa đơn bán";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_KhachHang,
            this.ID_HoaDonBan,
            this.NgayBan,
            this.ID_NhanVien,
            this.ID_Kho,
            this.Created_By,
            this.Created_At,
            this.Update_By,
            this.Update_At});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(737, 345);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID_KhachHang
            // 
            this.ID_KhachHang.DataPropertyName = "ID_KhachHang";
            this.ID_KhachHang.HeaderText = "ID Khach Hang";
            this.ID_KhachHang.Name = "ID_KhachHang";
            this.ID_KhachHang.Width = 75;
            // 
            // ID_HoaDonBan
            // 
            this.ID_HoaDonBan.DataPropertyName = "ID_HoaDonBan";
            this.ID_HoaDonBan.HeaderText = "ID Hoá Đơn Bán";
            this.ID_HoaDonBan.Name = "ID_HoaDonBan";
            this.ID_HoaDonBan.Width = 80;
            // 
            // NgayBan
            // 
            this.NgayBan.DataPropertyName = "NgayBan";
            this.NgayBan.HeaderText = "Ngày Bán";
            this.NgayBan.Name = "NgayBan";
            this.NgayBan.Width = 75;
            // 
            // ID_NhanVien
            // 
            this.ID_NhanVien.DataPropertyName = "ID_NhanVien";
            this.ID_NhanVien.HeaderText = "ID Nhân Viên";
            this.ID_NhanVien.Name = "ID_NhanVien";
            this.ID_NhanVien.Width = 75;
            // 
            // ID_Kho
            // 
            this.ID_Kho.DataPropertyName = "ID_Kho";
            this.ID_Kho.HeaderText = "ID Kho";
            this.ID_Kho.Name = "ID_Kho";
            this.ID_Kho.Width = 76;
            // 
            // Created_By
            // 
            this.Created_By.DataPropertyName = "Created_By";
            this.Created_By.HeaderText = "Người tạo";
            this.Created_By.Name = "Created_By";
            this.Created_By.Width = 75;
            // 
            // Created_At
            // 
            this.Created_At.DataPropertyName = "Created_At";
            this.Created_At.HeaderText = "Ngày tạo ";
            this.Created_At.Name = "Created_At";
            this.Created_At.Width = 75;
            // 
            // Update_By
            // 
            this.Update_By.DataPropertyName = "Update_By";
            this.Update_By.HeaderText = "Người Cập nhật";
            this.Update_By.Name = "Update_By";
            this.Update_By.Width = 76;
            // 
            // Update_At
            // 
            this.Update_At.DataPropertyName = "Update_At";
            this.Update_At.HeaderText = "Ngày Cập Nhật";
            this.Update_At.Name = "Update_At";
            this.Update_At.Width = 75;
            // 
            // TbUpdateby
            // 
            this.TbUpdateby.Location = new System.Drawing.Point(508, 72);
            this.TbUpdateby.Margin = new System.Windows.Forms.Padding(2);
            this.TbUpdateby.Name = "TbUpdateby";
            this.TbUpdateby.Size = new System.Drawing.Size(131, 20);
            this.TbUpdateby.TabIndex = 47;
            // 
            // TbCreateby
            // 
            this.TbCreateby.Location = new System.Drawing.Point(508, 17);
            this.TbCreateby.Margin = new System.Windows.Forms.Padding(2);
            this.TbCreateby.Name = "TbCreateby";
            this.TbCreateby.Size = new System.Drawing.Size(131, 20);
            this.TbCreateby.TabIndex = 46;
            // 
            // TbIDKho
            // 
            this.TbIDKho.Location = new System.Drawing.Point(161, 134);
            this.TbIDKho.Margin = new System.Windows.Forms.Padding(2);
            this.TbIDKho.Name = "TbIDKho";
            this.TbIDKho.Size = new System.Drawing.Size(131, 20);
            this.TbIDKho.TabIndex = 45;
            // 
            // TbIDNV
            // 
            this.TbIDNV.Location = new System.Drawing.Point(161, 104);
            this.TbIDNV.Margin = new System.Windows.Forms.Padding(2);
            this.TbIDNV.Name = "TbIDNV";
            this.TbIDNV.Size = new System.Drawing.Size(131, 20);
            this.TbIDNV.TabIndex = 44;
            // 
            // TbIDHDB
            // 
            this.TbIDHDB.Location = new System.Drawing.Point(161, 43);
            this.TbIDHDB.Margin = new System.Windows.Forms.Padding(2);
            this.TbIDHDB.Name = "TbIDHDB";
            this.TbIDHDB.Size = new System.Drawing.Size(131, 20);
            this.TbIDHDB.TabIndex = 43;
            // 
            // tbIDKH
            // 
            this.tbIDKH.Location = new System.Drawing.Point(161, 14);
            this.tbIDKH.Margin = new System.Windows.Forms.Padding(2);
            this.tbIDKH.Name = "tbIDKH";
            this.tbIDKH.Size = new System.Drawing.Size(131, 20);
            this.tbIDKH.TabIndex = 42;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(240, 167);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 30);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(161, 167);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(74, 30);
            this.btnReset.TabIndex = 40;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(83, 167);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 30);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(423, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Ngày cập nhật";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(423, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Người cập nhật";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(423, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Ngày tạo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Người tạo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "ID kho";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "ID nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ngày bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "ID Hóa đơn bán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "ID Khách Hàng";
            // 
            // BillSellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(743, 610);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DTNgayBan);
            this.Controls.Add(this.DTNgayCN);
            this.Controls.Add(this.DTNgaytao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TbUpdateby);
            this.Controls.Add(this.TbCreateby);
            this.Controls.Add(this.TbIDKho);
            this.Controls.Add(this.TbIDNV);
            this.Controls.Add(this.TbIDHDB);
            this.Controls.Add(this.tbIDKH);
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
            this.Name = "BillSellForm";
            this.Text = "BillSellForm";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker DTNgayBan;
        private System.Windows.Forms.DateTimePicker DTNgayCN;
        private System.Windows.Forms.DateTimePicker DTNgaytao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_HoaDonBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Kho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created_By;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created_At;
        private System.Windows.Forms.DataGridViewTextBoxColumn Update_By;
        private System.Windows.Forms.DataGridViewTextBoxColumn Update_At;
        private System.Windows.Forms.TextBox TbUpdateby;
        private System.Windows.Forms.TextBox TbCreateby;
        private System.Windows.Forms.TextBox TbIDKho;
        private System.Windows.Forms.TextBox TbIDNV;
        private System.Windows.Forms.TextBox TbIDHDB;
        private System.Windows.Forms.TextBox tbIDKH;
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
    }
}