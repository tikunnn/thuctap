using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class Home : Form
    {
        private NhanVien _nhanvien;
        public Home()
        {
            InitializeComponent();
        }
        public Home(NhanVien nhanvien)
        {
            InitializeComponent();
            _nhanvien = nhanvien;
        }
        private Home activeForm;
        public Home home;


        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnScreen.Controls.Add(childForm);
            this.pnScreen.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnStaffManagement_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.StaffManagementForm(), sender);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn đăng xuất không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Login login = new Login();
                login.ShowDialog();
            }
        }

        public void LoadName()
        {
            var dao = new STORAGEEntities();
            lbUserName.Text = _nhanvien.Ten;
        }

        private void btnCommodityManagement_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.CommodityManagementForm(), sender);
        }
    }
}
