using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.DAO
{
    public class SupplierDAO : BaseDAO
    {
        public SupplierDAO()
        {

        }

        //public List<NhaCungCap> GetAll() => _connect.NhaCungCaps.ToList();
        public List<NhaCungCap> GetAll() => _connect.NhaCungCaps.ToList();

        public bool Insert(NhaCungCap ncc)
        {
            _connect.NhaCungCaps.AddOrUpdate(ncc);
            return _connect.SaveChanges() > 0;
        }

        public void Delete(int id)
        {
            var dk = _connect.NhaCungCaps.FirstOrDefault(x => x.ID_NhaCungCap == id);
            _connect.NhaCungCaps.Remove(dk);
            _connect.SaveChanges();
        }

        public List<NhaCungCap> Seacrh(string key)
        {
            var dk = _connect.NhaCungCaps.Where(x => x.ID_Xoa.ToString().Contains(key) ||
            x.TenNhaCungCap.Contains(key) || x.DiaChi.Contains(key) || x.SoDienThoai.Contains(key) ||
            x.GhiChu.Contains(key));

            return dk.ToList();
        }
    }
}
