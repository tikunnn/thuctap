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
    public partial class StaffManagementForm : Form
    {
        public StaffManagementForm()
        {
            InitializeComponent();
        }

        

        private void StaffManagementForm_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.tbID.Text = "";
            this.tbName.Text = "";
            this.dtpBirthDay.Text = "";
            this.tbGender.Text = "";
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
    }
}
