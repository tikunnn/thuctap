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
    public partial class CommodityDetails : Form
    {
        private HangHoa _hanghoa;
        public CommodityDetails()
        {
            InitializeComponent();
        }
        public CommodityDetails(HangHoa hanghoa)
        {
            InitializeComponent();
            _hanghoa = hanghoa;
        }

        private void CommodityDetails_Load(object sender, EventArgs e)
        {
            LoadCommodityDetails();
        }
        private void LoadCommodityDetails()
        {
            tbID.Text = _hanghoa.ID_HangHoa.ToString();
            tbName.Text = _hanghoa.Ten;
            tbOrigin.Text = _hanghoa.XuatXu;
            tbPriceExport.Text = _hanghoa.GiaBan.ToString();
            tbCreatedBy.Text = _hanghoa.Created_By;
            tbCreatedAt.Text = _hanghoa.Created_At.ToString();
            tbUpdatedBy.Text = _hanghoa.Updated_By;
            tbUpdatedAt.Text = _hanghoa.Updated_At.ToString();
        }
    }
}
