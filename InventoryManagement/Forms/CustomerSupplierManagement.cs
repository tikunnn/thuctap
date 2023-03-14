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
    public partial class CustomerSupplierManagement : Form
    {
        private NhanVien _nhanvien;
        public CustomerSupplierManagement()
        {
            InitializeComponent();
        }
        public CustomerSupplierManagement(NhanVien nhanvien)
        {
            _nhanvien = nhanvien;
        }

        private CustomerSupplierManagement activeForm;

        private void Quản_lý_Load(object sender, EventArgs e)
        {

        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnChild.Controls.Add(childForm);
            this.pnChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SupplierManagement(), sender);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerManagement(_nhanvien), sender);
        }
    }
}
