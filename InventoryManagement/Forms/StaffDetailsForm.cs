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

namespace InventoryManagement.Forms
{
    public partial class StaffDetailsForm : Form
    {
        private NhanVien _nhanvien; 
        public StaffDetailsForm()
        {
            InitializeComponent();
        }
        public StaffDetailsForm(NhanVien nhanvien)
        {
            InitializeComponent();
            _nhanvien = nhanvien; 
        }

        private void StaffDetailsForm_Load(object sender, EventArgs e)
        {
            LoadDetailsNhanVien();
        }
        public void LoadDetailsNhanVien()
        {
            //lvStaffDetails.Items.Clear();

            //ListViewItem item = lvStaffDetails.Items.Add("");

            //item.SubItems.Add(_nhanvien.ID_NhanVien.ToString());
            //item.SubItems.Add(_nhanvien.Ten);
            //item.SubItems.Add(_nhanvien.Created_By);
            //item.SubItems.Add(_nhanvien.Created_At.ToString());
            //item.SubItems.Add(_nhanvien.Updated_By);
            //item.SubItems.Add(_nhanvien.Updated_At.ToString());
            //item.SubItems.Add(_nhanvien.UserName);
            //item.SubItems.Add(_nhanvien.Pasword);


            tbID.Text = _nhanvien.ID_NhanVien.ToString();
            tbName.Text = _nhanvien.Ten;
            tbCreatedBy.Text = _nhanvien.Created_By;
            tbCreatedAt.Text = _nhanvien.Created_At.ToString();
            tbUpdatedBy.Text = _nhanvien.Updated_By;
            tbUpdatedAt.Text = _nhanvien.Updated_At.ToString();
            tbAccount.Text = _nhanvien.UserName;
            tbPassword.Text = _nhanvien.Pasword;
        }
    }
}
