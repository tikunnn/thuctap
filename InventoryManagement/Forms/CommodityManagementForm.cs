using InventoryManagement.DAO;
using InventoryManagement.Models;
using InventoryManagement.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Forms
{
    public partial class CommodityManagementForm : Form
    {
        List<HangHoa> dsHangHoa;
        private NhanVien _nhanvien;
        string imgLocation = "";
        byte[] img = null;
        NhanVien nvCurrent = new NhanVien();

        private HangHoa _hanghoa;
        HangHoa hhCurrent = new HangHoa();

        public CommodityManagementForm(NhanVien nhanvien)
        {
            InitializeComponent();
            _nhanvien = nhanvien;
        }
        public CommodityManagementForm()
        {
            InitializeComponent();
        }

        private void CommodityManagementForm_Load(object sender, EventArgs e)
        {
            LoadHangHoa();
        }
        private void LoadHangHoa()
        {
            var dao = new HangDAO();
            dsHangHoa = dao.GetAll_HangHoa();

            int count = 1;
            lvCommodity.Items.Clear();

            foreach (var hh in dsHangHoa)
            {
                ListViewItem item = lvCommodity.Items.Add(count.ToString());

                item.SubItems.Add(hh.ID_HangHoa.ToString());
                item.SubItems.Add(hh.Ten);
                item.SubItems.Add(hh.XuatXu);
                item.SubItems.Add(hh.DonViTinh);
                item.SubItems.Add(hh.GiaBan.ToString());


                count++;
            }
        }

        private void btnChoosePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open File Image";
            dlg.FileName = "Hãy chọn File";
            dlg.Filter = "Image Files (JPEG, GIF, BMP, etc.)|"
                            + ".jpg;.jpeg;*.gif;*.bmp;"
                            + ".tif;.tiff;*.png|"
                            + "JPEG files (.jpg;.jpeg)|*.jpg;*.jpeg|"
                            + "GIF files (.gif)|.gif|"
                            + "BMP files (.bmp)|.bmp|"
                            + "TIFF files (.tif;.tiff)|*.tif;*.tiff|"
                            + "PNG files (.png)|.png|"
                            + "All files (.)|*.*";

            dlg.InitialDirectory = Environment.CurrentDirectory;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dlg.FileName.ToString();
                pbPicture.ImageLocation = imgLocation;
            }
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            this.tbID.Text = "";
            this.tbCommodityName.Text = "";
            this.tbOrigin.Text = "";
            this.tbUnit.Text = "";
            this.tbExportPrice.Text = "";
            this.pbPicture.Image = null;
        }

        private void lvCommodity_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            for (int i = 0; i < lvCommodity.Items.Count; i++)
            {
                if (lvCommodity.Items[i].Selected)
                {
                    HangHoa hhCurrent = new HangHoa();
                    hhCurrent = dsHangHoa[i];
                    tbID.Text = hhCurrent.ID_HangHoa.ToString();
                    tbCommodityName.Text = hhCurrent.Ten;
                    tbOrigin.Text = hhCurrent.XuatXu;
                    tbUnit.Text = hhCurrent.DonViTinh;
                    tbExportPrice.Text = hhCurrent.GiaBan.ToString();

                    if (hhCurrent.HinhAnh == null)
                    {
                        pbPicture.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(hhCurrent.HinhAnh);
                        pbPicture.Image = Image.FromStream(ms);

                    }
                }
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            List<HangHoa> dsHangHoa = new List<HangHoa>();
            lvCommodity.Items.Clear();

            HangDAO dao = new HangDAO();
            dsHangHoa = dao.Search(tbSearch.Text);

            foreach (HangHoa hangHoa in dsHangHoa)
            {
                ListViewItem item = new ListViewItem(hangHoa.ID_HangHoa.ToString());

                item.SubItems.Add(hangHoa.ID_HangHoa.ToString());
                item.SubItems.Add(hangHoa.Ten);
                item.SubItems.Add(hangHoa.XuatXu);
                item.SubItems.Add(hangHoa.DonViTinh);
                item.SubItems.Add(hangHoa.GiaBan.ToString());

                lvCommodity.Items.Add(item);
            }
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            InsertHangHoa();
            LoadHangHoa();
        }

        private int InsertHangHoa()
        {
            var dao = new HangDAO();

            HangHoa hh = new HangHoa();
            if (tbCommodityName.Text == "" || tbOrigin.Text == "" || tbUnit.Text == "" || tbExportPrice.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                hh.ID_HangHoa = Convert.ToInt32(tbID.Text);
                hh.Ten = tbCommodityName.Text;
                hh.XuatXu = tbOrigin.Text;
                hh.DonViTinh = tbUnit.Text;
                hh.GiaBan = Convert.ToInt32(tbExportPrice.Text);
                hh.Created_By = _nhanvien.Ten;
                hh.Created_At = DateTime.Now;
                

                if (pbPicture.Image == null)
                {
                    FileStream file = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader binary = new BinaryReader(file);

                    img = binary.ReadBytes((int)file.Length);
                    hh.HinhAnh = img;
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return dao.InsertUpdate(hh);
                }
                //else
                //{
                //    hh.HinhAnh = ImageToByteArray(pbPicture.Image);
                //    MessageBox.Show("Cập nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return dao.InsertUpdate(hh);
                //}
            }
            return -1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateHangHoa();
            LoadHangHoa();
        }
        private int UpdateHangHoa()
        {
            var dao = new HangDAO();

            HangHoa hh = new HangHoa();
            if (tbCommodityName.Text == "" || tbOrigin.Text == "" || tbUnit.Text == "" || tbExportPrice.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                hh.ID_HangHoa = Convert.ToInt32(tbID.Text);
                hh.Ten = tbCommodityName.Text;
                hh.XuatXu = tbOrigin.Text;
                hh.DonViTinh = tbUnit.Text;
                hh.GiaBan = Convert.ToInt32(tbExportPrice.Text);
                hh.Created_By = nvCurrent.Ten;
                hh.Created_At = nvCurrent.Created_At;
                hh.Updated_By = _nhanvien.Ten;
                hh.Updated_At = DateTime.Now;

                //if (pbPicture.Image == null)
                //{
                //    FileStream file = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                //    BinaryReader binary = new BinaryReader(file);

                //    img = binary.ReadBytes((int)file.Length);
                //    hh.HinhAnh = img;
                //    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return dao.InsertUpdate(hh);
                //}
                //else
                //{
                //    hh.HinhAnh = ImageToByteArray(pbPicture.Image);
                //    MessageBox.Show("Cập nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return dao.InsertUpdate(hh);
                //}

                if (pbPicture.Image != null)
                {
                    hh.HinhAnh = ImageToByteArray(pbPicture.Image);
                    MessageBox.Show("Cập nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return dao.InsertUpdate(hh);
                }
            }
            return -1;
        }


        public byte[] ImageToByteArray(System.Drawing.Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        private void tsmiDeleteCommodity_Click(object sender, EventArgs e)
        {
            var dao = new HangDAO();

            if (MessageBox.Show("Bạn có muốn xóa mặt hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for (int i = 0; i < lvCommodity.Items.Count; i++)
                {
                    if (lvCommodity.Items[i].Selected)
                    {
                        dao.Delete_ID(dsHangHoa[i].ID_HangHoa);
                        MessageBox.Show("Xóa mặt hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadHangHoa();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lvCommodity_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i < lvCommodity.Items.Count; i++)
            {
                if (lvCommodity.Items[i].Selected)
                    hhCurrent = dsHangHoa[i];
            }
            CommodityDetails details = new CommodityDetails(hhCurrent);
            details.ShowDialog();
        }
    }
}
