using InventoryManagement.DAO;
using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventoryManagement.Forms
{
    public partial class StaffManagementForm : Form
    {
        List<NhanVien> dsNhanVien;
        public StaffManagementForm()
        {
            InitializeComponent();
        }

        

        private void StaffManagementForm_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
        }
        private void LoadNhanVien()
        {
            var dao = new NguoiDAO();
            dsNhanVien = dao.GetAll_NhanVien();

            int count = 1;
            lvUser.Items.Clear();

            foreach (var nhanvien in dsNhanVien)
            {
                ListViewItem item = lvUser.Items.Add(count.ToString());

                item.SubItems.Add(nhanvien.ID_NhanVien.ToString());
                item.SubItems.Add(nhanvien.Ten);
                item.SubItems.Add(nhanvien.NgaySinh.ToString());
                item.SubItems.Add(nhanvien.GioiTinh.ToString());
                item.SubItems.Add(nhanvien.DienThoai);
                item.SubItems.Add(nhanvien.DiaChi);
                item.SubItems.Add(nhanvien.Luong.ToString());
                item.SubItems.Add(nhanvien.Created_By);
                item.SubItems.Add(nhanvien.Created_At.ToString());
                item.SubItems.Add(nhanvien.Updated_By);
                item.SubItems.Add(nhanvien.Updated_At.ToString());
                item.SubItems.Add(nhanvien.UserName);
                item.SubItems.Add(nhanvien.Pasword);
                count++;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.tbID.Text = "";
            this.tbName.Text = "";
            this.dtpBirthDay.Text = "";
            this.cbbGender.Text = "";
            this.tbSalary.Text = "";
            this.tbPhoneNumber.Text = "";
            this.tbAddress.Text = "";
            this.tbAccount.Text = "";
            this.tbPassword.Text = "";
            this.dtpDateCreated.Text = "";
            this.tbPersonCreated.Text = "";
            this.dtpDateUpdated.Text = "";
            this.tbPersonUpdated.Text = "";
        }

        private void lvUser_Click(object sender, EventArgs e)
        {
            //btnAdd.Enabled = false;
            for (int i = 0; i < lvUser.Items.Count; i++)
            {
                if (lvUser.Items[i].Selected)
                {
                    NhanVien nvCurrent = new NhanVien();
                    nvCurrent = dsNhanVien[i];
                    tbID.Text = nvCurrent.ID_NhanVien.ToString();
                    tbName.Text = nvCurrent.Ten;
                    dtpBirthDay.Text = nvCurrent.NgaySinh.ToString();
                    cbbGender.Text = nvCurrent.GioiTinh.ToString();
                    tbSalary.Text = nvCurrent.Luong.ToString();
                    tbPhoneNumber.Text = nvCurrent.DienThoai;
                    tbAddress.Text = nvCurrent.DiaChi;
                    tbAccount.Text = nvCurrent.UserName;
                    tbPassword.Text = nvCurrent.Pasword;
                    dtpDateCreated.Text = nvCurrent.Created_At.ToString();
                    tbPersonCreated.Text = nvCurrent.Created_By;
                    dtpDateUpdated.Text = nvCurrent.Updated_At.ToString();
                    tbPersonUpdated.Text = nvCurrent.Updated_By;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int insert = InsertUpdateStaff();

            if (insert > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công");
                LoadNhanVien();
            }
            else
            {
                MessageBox.Show("Cập nhật thành công");
                LoadNhanVien();
            }    
        }

        private int InsertUpdateStaff()
        {
            NhanVien obj = new NhanVien();
            //obj.ID_NhanVien = 0;

            if (tbName.Text == "" || dtpBirthDay.Text == ""  )
                //|| cbbGender.Text == "" || tbSalary.Text == "" || tbPhoneNumber.Text == "" 
                //|| tbAddress.Text == "" || tbAccount.Text == "" || tbPassword.Text == ""
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
            } 
            else
            {
                obj.ID_NhanVien = Convert.ToInt32(tbID.Text);
                obj.Ten = tbName.Text;
                //obj.NgaySinh = DateTime.Now;
                //if (cbbGender.SelectedIndex == 0)
                //    obj.GioiTinh = false;
                //else
                //    obj.GioiTinh = true;

                var dao = new NguoiDAO();
                return dao.InsertUpdate(obj);
            }

            return -1;
        }

        private void tsmiDeleteStaff_Click(object sender, EventArgs e)
        {
            var dao = new NguoiDAO(); 
            
            if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                
                MessageBox.Show("Xóa thành công", "Thông báo");
                LoadNhanVien();
            }
            else
            {
                MessageBox.Show("Vui lòng thử lại", "Lỗi");
            }
        }
    }
}
