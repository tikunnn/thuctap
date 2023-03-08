using InventoryManagement.DAO;
using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        string imgLocation = "";
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
    }
}
