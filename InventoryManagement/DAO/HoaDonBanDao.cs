using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.DAO
{
    public class HoaDonBanDAO : BaseDAO
    {
        public HoaDonBanDAO()
        {

        }
        public List<HoaDonBan> GetAll() => _connect.HoaDonBans.ToList();
        public void Insert(HoaDonBan hdb)
        {
            _connect.HoaDonBans.AddOrUpdate(hdb);
            _connect.SaveChanges();
        }

        public void delete(int id)
        {
            var dk = _connect.HoaDonBans.FirstOrDefault(x => x.ID_HoaDonBan == id);
            _connect.HoaDonBans.Remove(dk);
            _connect.SaveChanges();
        }

        public List<HoaDonBan> findkey(string a)
        {
            var results = _connect.HoaDonBans.Where(x => x.ID_HoaDonBan.ToString().Contains(a) || x.ID_KhachHang.ToString().Contains(a)
            || x.NgayBan.ToString().Contains(a) || x.ID_Kho.ToString().Contains(a) || x.ID_NhanVien.ToString().Contains(a));
            return results.ToList();
        }
    }
}

