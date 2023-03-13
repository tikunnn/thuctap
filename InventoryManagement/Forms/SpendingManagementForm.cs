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
    public partial class SpendingManagementForm : Form
    {
        private Home home;
        public SpendingManagementForm()
        {
            InitializeComponent();
        }

        private Home activeForm;
        //public Home home;


        public void OpenChildForm(Form childForm, object btnSender)
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

        private void btnPurchaseBill_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PurshaseBillForm(), sender);
        }

        private void btnPurchaseSell_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SellBillForm(), sender);
        }

    }
}
