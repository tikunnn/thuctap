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
    public partial class CustomerManagement : Form
    {
        List<KhachHang> khachHangs;
        CustomerDAO dao = new CustomerDAO();
        NguoiDAO nDao = new NguoiDAO();
        private NhanVien _nhanvien;


        private string name;

        public CustomerManagement()
        {
            InitializeComponent();
        }

        public CustomerManagement(NhanVien nhanVien)
        {
            InitializeComponent();
            _nhanvien = nhanVien;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadData()
        {
            //var dao = new NccDAO();
            var CusDAO = dao.GetAll().Select(x => new
            {
                x.ID_KhachHang,
                x.Ten,
                x.DiaChi,
                x.SoDienThoai,
                x.GhiChu
            }).ToList();
            dgvCustomer.DataSource = CusDAO;
        }

        private void CustomerManagement_Load(object sender, EventArgs e)
        {
            LoadData();
            dtpDate.Value = DateTime.Now;
            tbStaff.Text = name;
        }

        public void LoadName()
        {
            tbStaff.Text = _nhanvien.Ten;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var InsUp = InsertUpdate();
            if (InsUp > 0)
            {
                LoadData();
            }
            else
            {
                MessageBox.Show("Cập nhật thành công");
                LoadData();
            }
        }

        private int InsertUpdate()
        {
            var kh = new KhachHang();
            if (tbName.Text == null || tbAddress == null || tbPhoneNumber == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                kh.ID_KhachHang = Convert.ToInt16(tbID.Text);
                kh.Ten = tbName.Text;
                kh.DiaChi = tbAddress.Text;
                kh.SoDienThoai = tbPhoneNumber.Text;
                kh.GhiChu = tbNote.Text;
                //tbStaff.Text = _nhanvien.Ten;

                var ck = dao.Insert(kh);
                if (ck)
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
                dao.GetAll();


            }
            return -1;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(tbID.Text);
            dao.Delete(i);
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            tbID.Text = string.Empty;
            tbName.Text = string.Empty;
            tbAddress.Text = string.Empty;
            tbPhoneNumber.Text = string.Empty;
            tbNote.Text = string.Empty;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string key = tbSearch.Text;
            var searchCusDao = dao.Seacrh(key).ToList();
            dgvCustomer.DataSource = searchCusDao;
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var i = dgvCustomer.CurrentRow.Index;
            DataRow(i);
        }

        private void DataRow(int cur)
        {
            tbID.Text = dgvCustomer.Rows[cur].Cells[0].Value.ToString();
            tbName.Text = dgvCustomer.Rows[cur].Cells[1].Value.ToString();
            tbAddress.Text = dgvCustomer.Rows[cur].Cells[2].Value.ToString();
            tbPhoneNumber.Text = dgvCustomer.Rows[cur].Cells[3].Value.ToString();

            if (dgvCustomer.Rows[cur].Cells[4].Value == null)
            {
                tbNote.Text = "";
            }
            else
                tbNote.Text = dgvCustomer.Rows[cur].Cells[4].Value.ToString();
        }

        
    }
}
