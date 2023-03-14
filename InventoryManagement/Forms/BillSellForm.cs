using InventoryManagement.DAO;
using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventoryManagement.Forms
{
    public partial class BillSellForm : Form
    {
        HoaDonBanDAO dao = new HoaDonBanDAO();
        public BillSellForm()
        {
            InitializeComponent();
            ListViewBuy();
        }

        private void ListViewBuy()
        {
            var dao = new HoaDonBanDAO();
            var hoaDonBans = dao.GetAll().Select(x => new
            {
                x.ID_KhachHang,
                x.ID_HoaDonBan,
                x.NgayBan,
                x.ID_NhanVien,
                x.ID_Kho,
                x.Created_By,
                x.Created_At,
                x.Updated_By,
                x.Updated_At,
            }
            ).ToList();
            dataGridView1.DataSource = hoaDonBans;
        }

        private Form activeFrom = null;

        public object ConfigurationManager { get; private set; }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void Reset()
        {
            tbIDKH.Text = "";
            TbIDHDB.Text = "";
            DTNgayBan.Text = "";
            TbCreateby.Text = "";
            DTNgayCN.Text = "";
            TbUpdateby.Text = "";
            TbIDNV.Text = "";
            TbIDKho.Text = "";
            DTNgaytao.Text = "";
            ListViewBuy();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        #region Kiểm Tra thông tin
        public bool kiemtra()
        {
            return true;
        }

        public int AddData()
        {
            var hdb = new HoaDonBan();
            if (tbIDKH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Thêm thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbIDKH.Focus();
            }
            else
            {
                hdb.ID_KhachHang = Convert.ToInt32(tbIDKH.Text);
                hdb.ID_HoaDonBan = Convert.ToInt32(TbIDHDB.Text);
                hdb.ID_NhanVien = Convert.ToInt32(TbIDNV.Text);
                hdb.ID_Kho = Convert.ToInt32(TbIDKho.Text);
                hdb.Created_By = this.TbCreateby.Text;
                hdb.Updated_By = this.TbUpdateby.Text;
                hdb.Created_At = this.DTNgaytao.Value;
                hdb.Updated_At = this.DTNgayCN.Value;
                hdb.NgayBan = this.DTNgayBan.Value;
                var hddDao = new HoaDonBanDAO();
                hddDao.Insert(hdb);

                //var dk = dao.Insert(hdb);

                //if (dk)
                //{
                //    MessageBox.Show("Đã Thêm Thành Công");
                //}
                //else
                //{
                //    MessageBox.Show("Thất Bại");
                //}
                //dao.GetAll();
            }
            return -1;
        }
        #endregion



        private void Bill_Load(object sender, EventArgs e)
        {
            DTNgayBan.Value = DateTime.Now;
            DTNgayCN.Value = DateTime.Now;
            DTNgaytao.Value = DateTime.Now;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var ins = AddData();
            if (ins > 0)
            {
                Reset();
            }
            else
            {
                Reset();
            }
            //AddData();
            Reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(TbIDHDB.Text);
            var hdb = new HoaDonBanDAO();
            hdb.delete(i);
            Reset();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string b = textBox1.Text;
            HoaDonBanDAO dao = new HoaDonBanDAO();
            dataGridView1.DataSource = dao.findkey(b);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            tbIDKH.Text = Convert.ToString(row.Cells["ID_KhachHang"].Value);
            TbIDHDB.Text = Convert.ToString(row.Cells["ID_HoaDonBan"].Value);
            DTNgayBan.Text = Convert.ToString(row.Cells["NgayBan"].Value);
            TbIDNV.Text = Convert.ToString(row.Cells["ID_NhanVien"].Value);
            TbIDKho.Text = Convert.ToString(row.Cells["ID_Kho"].Value);
            TbCreateby.Text = Convert.ToString(row.Cells["Created_By"].Value);
            DTNgaytao.Text = Convert.ToString(row.Cells["Created_At"].Value);
            TbUpdateby.Text = Convert.ToString(row.Cells["Update_By"].Value);
            DTNgayCN.Text = Convert.ToString(row.Cells["Update_At"].Value);
        }
    }
}
