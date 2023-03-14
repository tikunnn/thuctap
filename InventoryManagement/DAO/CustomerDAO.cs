using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.DAO
{
    public class CustomerDAO : BaseDAO
    {
        public NhanVien _nhanvien;
        public CustomerDAO()
        {

        }

        public List<KhachHang> GetAll() => _connect.KhachHangs.ToList();

        public bool Insert(KhachHang khach)
        {
            _connect.KhachHangs.AddOrUpdate(khach);
            return _connect.SaveChanges() > 0;
        }

        public void Delete(int id)
        {
            var dk = _connect.KhachHangs.FirstOrDefault(x => x.ID_KhachHang == id);
            _connect.KhachHangs.Remove(dk);
            _connect.SaveChanges();
        }

        public List<KhachHang> Seacrh(string key)
        {
            var dk = _connect.KhachHangs.Where(x => x.ID_Xoa.ToString().Contains(key) ||
            x.Ten.Contains(key) || x.DiaChi.Contains(key) || x.SoDienThoai.Contains(key) ||
            x.GhiChu.Contains(key));

            return dk.ToList();
        }


    }
}
