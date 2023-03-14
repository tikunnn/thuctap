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

    public partial class BillBuyForm : Form
    {
        HoaDonMuaDAo dao = new HoaDonMuaDAo();

        public BillBuyForm()
        {
            InitializeComponent();
            ListViewSell();
        }

        private void ListViewSell()
        {

            var hoaDonMuas = dao.GetAll().Select(x => new
            {
                x.ID_NhaCungCap,
                x.ID_HDMua,
                x.NgayNhap,
                x.ID_NhanVien,
                x.ID_Kho,
                x.Created_By,
                x.Created_At,
                x.Updated_By,
                x.Updated_At,
            }).ToList();
            dataGridViewBuy.DataSource = hoaDonMuas;
        }

        private Form activeFrom = null;

        public object ConfigurationManager { get; private set; }

        private void dataGridViewBuy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var ins = AddData();
            if (ins>0)
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

        public void Reset()
        {
            tbIDNccs.Text = "";
            TbIDHDM.Text = "";
            DTNgayNhap.Text = "";
            TbCreateby.Text = "";
            DTNgayCN.Text = "";
            TbUpdateby.Text = "";
            TbIDNV.Text = "";
            TbIDKho.Text = "";
            DTNgaytao.Text = "";
            ListViewSell();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            DTNgayNhap.Value = DateTime.Now;
            DTNgayCN.Value = DateTime.Now;
            DTNgaytao.Value = DateTime.Now;
        }

        public bool kiemtra()
        {
            return true;
        }


        private int AddData()   
        {
            var hdm = new HoaDonMua();
            if (tbIDNccs.Text == "" || TbIDHDM.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Thêm thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                hdm.ID_NhaCungCap = Convert.ToInt32(tbIDNccs.Text);
                hdm.ID_HDMua = Convert.ToInt32(TbIDHDM.Text);
                hdm.ID_NhanVien = Convert.ToInt32(TbIDNV.Text);
                hdm.ID_Kho = Convert.ToInt32(TbIDKho.Text);
                hdm.Created_By = this.TbCreateby.Text;
                hdm.Updated_By = this.TbUpdateby.Text;
                hdm.Created_At = this.DTNgaytao.Value;
                hdm.Updated_At = this.DTNgayCN.Value;
                hdm.NgayNhap = this.DTNgayNhap.Value;
                //hdmDao.InsertUpdate(hdm);
                var dk = dao.Insert(hdm);

                if (dk)
                {
                    MessageBox.Show("Đã Thêm Thành Công");
                }
                else {
                    MessageBox.Show("Thất Bại");
                }
                dao.GetAll();
                
                //return hdmDao.InsertUpdate(hdm);
            }
            return -1;
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            Reset();
        }

        private void dataGridViewBuy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridViewBuy.Rows[e.RowIndex];
            tbIDNccs.Text = Convert.ToString(row.Cells["ID_NhaCungCap"].Value);
            TbIDHDM.Text = Convert.ToString(row.Cells["ID_HDMua"].Value);
            DTNgayNhap.Text = Convert.ToString(row.Cells["NgayNhap"].Value);
            TbIDNV.Text = Convert.ToString(row.Cells["ID_NhanVien"].Value);
            TbIDKho.Text = Convert.ToString(row.Cells["ID_Kho"].Value);
            TbCreateby.Text = Convert.ToString(row.Cells["Created_By"].Value);
            DTNgaytao.Text = Convert.ToString(row.Cells["Created_At"].Value);
            TbUpdateby.Text = Convert.ToString(row.Cells["Update_By"].Value);
            DTNgayCN.Text = Convert.ToString(row.Cells["Update_At"].Value);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string b = textBox1.Text;
            HoaDonMuaDAo dao = new HoaDonMuaDAo();
            dataGridViewBuy.DataSource = dao.findkey(b);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(TbIDHDM.Text);
            var hdm = new HoaDonMuaDAo();
            hdm.delete(i);
            Reset();
        }

    }
}


