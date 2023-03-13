using InventoryManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            SetUpPlaceHolder();
        }

        private const string PlaceHolderTextUser = "user1";
        //private const string PlaceHolderTextPass = "";


        private void SetUpPlaceHolder()
        {
            tbUser.Text = PlaceHolderTextUser;
            tbUser.GotFocus += RemovePlaceHolderUser;
            tbUser.LostFocus += ShowPlaceHolderUser;

            //tbPass.Text = PlaceHolderTextPass;
            //tbPass.GotFocus += RemovePlaceHolderPass;
            //tbPass.LostFocus += ShowPlaceHolderPass;
        }

        private void ShowPlaceHolderUser(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUser.Text))
                tbUser.Text = PlaceHolderTextUser;
        }
        private void RemovePlaceHolderUser(object sender, EventArgs e)
        {
            if (tbUser.Text == PlaceHolderTextUser)
                tbUser.Text = "";
        }

        //private void ShowPlaceHolderPass(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(tbPass.Text))
        //        tbPass.Text = PlaceHolderTextPass;
        //}

        //private void RemovePlaceHolderPass(object sender, EventArgs e)
        //{
        //    if (tbPass.Text == PlaceHolderTextPass)
        //        tbPass.Text = "";
        //}

        private void btnExit_Click(object sender, EventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát ứng dụng", "Thông báo", MessageBoxButtons.YesNo);
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var dao = new NguoiDAO();
            try
            {
                var login = dao.GetLogin(tbUser.Text, tbPass.Text);
                if (tbUser.Text == "" || tbPass.Text == "")
                {
                    lbNotication.Text = "Vui lòng nhập đầy đủ thông tin";
                }
                else
                {
                    if (login != null)
                    {
                        Home home = new Home(login);
                        home.LoadName();
                        home.ShowDialog();
                    }
                    else
                    {
                        lbNotication.Text = "Sai tên đăng nhập hoặc mật khẩu";
                    }
                }
                
            }
            
            catch(Exception ex) 
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                tbPass.PasswordChar = '\0';
            }
            else
            {
                tbPass.PasswordChar = '*';
            }
        }
    }
}
