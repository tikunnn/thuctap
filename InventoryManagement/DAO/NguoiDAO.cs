using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.DAO
{
    public class NguoiDAO : BaseDAO
    {
        public NguoiDAO() { }
        public NhanVien GetLogin(string username, string password)
        {
            return _connect.NhanViens.FirstOrDefault(x => x.UserName == username && x.Pasword == password);
        }

        public List<NhanVien> GetAll_NhanVien()
        {
            return _connect.NhanViens.ToList();
        }

        public int InsertUpdate(NhanVien obj)
        {
            using (var db = new STORAGEEntities())
            {
                using (var db1 = new STORAGEEntities())
                {
                    var find = db.NhanViens.FirstOrDefault(x => x.ID_NhanVien == obj.ID_NhanVien);
                    if (find != null) db1.Entry(obj).State = EntityState.Modified;
                    else obj = db1.NhanViens.Add(obj);
                    db1.SaveChanges();
                    return obj.ID_NhanVien;
                }
            }
        }

        #region comment
        //public int Insert(NhanVien obj)
        //{
        //    using (var db = new STORAGEEntities())
        //    {
        //        var find = db.NhanViens.FirstOrDefault(x => x.ID_NhanVien == obj.ID_NhanVien);
        //        if (find == null)
        //        {
        //            db.Entry(obj).State = EntityState.Modified;
        //            db.SaveChanges();
        //            return obj.ID_NhanVien;
        //        }
        //        else
        //            return -1;
        //    }
        //}
        //public int Update(NhanVien obj)
        //{
        //    using (var db = new STORAGEEntities())
        //    {
        //        var find = db.NhanViens.FirstOrDefault(x => x.ID_NhanVien == obj.ID_NhanVien);
        //        if (find != null)
        //        {
        //            db.NhanViens.Add(obj);
        //            return obj.ID_NhanVien;
        //        }
        //        else
        //            return -1;
        //    }
        //}
        #endregion

        public void CheckUser(NhanVien obj)
        {
            using (var db = new STORAGEEntities())
            {
                using (var db1 = new STORAGEEntities())
                {
                    var find = db.NhanViens.FirstOrDefault(x => x.UserName == obj.UserName);
                    if (find != null) db1.Entry(obj).State = EntityState.Modified;
                    else obj = db1.NhanViens.Add(obj);
                    db1.SaveChanges();
                }
            }
        }

        public void Delete_ID (int id)
        {
            using (var db = new STORAGEEntities ())
            {
                var obj = db.NhanViens.FirstOrDefault(x => x.ID_NhanVien == id);
                if (obj != null)
                {
                    db.NhanViens.Remove(obj);
                    db.SaveChanges();
                }
            }
        }

        public void Delete_IDs(List<string> IDs)
        {
            using (var db = new STORAGEEntities())
            {
                var ls = db.NhanViens.AsQueryable();
                if (ls != null && ls.Any())
                {
                    ls = ls.Where(x => IDs.Contains(x.ID_NhanVien.ToString()));
                    foreach (var item in ls)
                    {
                        db.NhanViens.Remove(item);
                    }
                    db.SaveChanges();
                }
            }
        }
    }
}
