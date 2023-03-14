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
    public partial class SupplierManagement : Form
    {
        private NhanVien _nhanvien;
        List<NhaCungCap> nhaCungCaps;
        SupplierDAO dao = new SupplierDAO();
        public SupplierManagement()
        {
            InitializeComponent();
        }
        public SupplierManagement(NhanVien nhanvien)
        {
            InitializeComponent();
            _nhanvien = nhanvien;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadData()
        {
            //var dao = new NccDAO();
            var SupDAO = dao.GetAll().Select(x => new
            {
                x.ID_NhaCungCap,
                x.TenNhaCungCap,
                x.DiaChi,
                x.SoDienThoai,
                x.GhiChu
            }).ToList();
            dgvSupplier.DataSource = SupDAO;
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SupplierManagerment_Load(object sender, EventArgs e)
        {
            LoadData();
            dtpDate.Value = DateTime.Now;

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var InsUp = InsertUpdate();
            if (InsUp > 0)
            {
                LoadData();
            }
            else
            {
                LoadData();
            }

        }

        private int InsertUpdate()
        {
            var ncc = new NhaCungCap();
            if (tbName.Text == null || tbAddress.Text == null || tbPhoneNumber.Text == null )
            {
                MessageBox.Show("Vui lòng nhập thông tin yêu cầu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                ncc.ID_NhaCungCap = Convert.ToInt16(tbID.Text);
                ncc.TenNhaCungCap = tbName.Text;
                ncc.DiaChi = tbAddress.Text;
                ncc.SoDienThoai = tbPhoneNumber.Text;
                ncc.GhiChu = tbNote.Text;

                var ck = dao.Insert(ncc);
                if (ck == true)
                {
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            return -1;
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var i = dgvSupplier.CurrentRow.Index;
            DataRow(i);

        }

        private void DataRow(int cur)
        {
            tbID.Text = dgvSupplier.Rows[cur].Cells[0].Value.ToString();
            tbName.Text = dgvSupplier.Rows[cur].Cells[1].Value.ToString();
            tbAddress.Text = dgvSupplier.Rows[cur].Cells[2].Value.ToString();
            tbPhoneNumber.Text = dgvSupplier.Rows[cur].Cells[3].Value.ToString();

            if (dgvSupplier.Rows[cur].Cells[4].Value == null)
            {
                tbNote.Text = "";
            }
            else
                tbNote.Text = dgvSupplier.Rows[cur].Cells[4].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //var ncc = new NhaCungCap();
            int i = Convert.ToInt32(tbID.Text);
            //var dao=new NccDAO();
            dao.Delete(i);
            LoadData();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string key = tbSearch.Text;
            var searchCusDao = dao.Seacrh(key).ToList();
            dgvSupplier.DataSource = searchCusDao;
        }


    }
}
