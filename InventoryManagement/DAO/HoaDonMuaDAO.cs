using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.DAO
{
    public class HoaDonMuaDAo : BaseDAO
    {
        public HoaDonMuaDAo()
        {

        }

        public List<HoaDonMua> GetAll() => _connect.HoaDonMuas.ToList();
        public bool Insert(HoaDonMua hdm)
        {
            _connect.HoaDonMuas.AddOrUpdate(hdm);
            return _connect.SaveChanges() >0 ; 
        }

        public void delete(int id)
        {
            var dk = _connect.HoaDonMuas.FirstOrDefault(x => x.ID_HDMua == id);
            _connect.HoaDonMuas.Remove(dk);
            _connect.SaveChanges();
        }

        public List<HoaDonMua> findkey(string a)
        {
            var results = _connect.HoaDonMuas.Where(x => x.ID_HDMua.ToString().Contains(a) || x.ID_NhaCungCap.ToString().Contains(a)
            || x.NgayNhap.ToString().Contains(a) || x.ID_Kho.ToString().Contains(a) || x.ID_NhanVien.ToString().Contains(a));
            return results.ToList();
        }

        public List<HoaDonMua> GetAll_HoaDonMua()
        {
            return _connect.HoaDonMuas.ToList();
        }

        public int InsertUpdate(HoaDonMua hdm)
        {
            using (var db = new STORAGEEntities1())
            {
                using (var db1 = new STORAGEEntities1())
                {
                    var find = db.HoaDonMuas.FirstOrDefault(x => x.ID_HDMua == hdm.ID_HDMua);
                    if (find != null)
                        db1.Entry(hdm).State = EntityState.Modified;
                    else
                        hdm = db1.HoaDonMuas.Add(hdm);
                    db1.SaveChanges();
                    return hdm.ID_HDMua;
                }
            }
        }
    }
}
