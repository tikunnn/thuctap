using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.DAO
{
    public class HangDAO : BaseDAO
    {
        public HangDAO() { } 

        public List<HangHoa> GetAll_HangHoa()
        {
            return _connect.HangHoas.ToList();
        }

        public List<HangHoa> Search(string key)
        {
            List<HangHoa> list = GetAll_HangHoa();
            List<HangHoa> result = new List<HangHoa>();

            foreach (var item in list)
            {
                if ( item.ID_HangHoa.ToString().Contains(key)
                    || item.Ten.ToLower().Contains(key) 
                    || item.XuatXu.ToLower().Contains(key)
                    || item.DonViTinh.ToLower().Contains(key)
                    || item.GiaBan.ToString().Contains(key))
                    result.Add(item);
            }
            return result;
        }
        #region insert & update
        public int InsertUpdate(HangHoa item)
        {
            using ( var db = new STORAGEEntities())
            {
                using (var db1 = new STORAGEEntities())
                {
                    var find = db.HangHoas.FirstOrDefault(x => x.ID_HangHoa == item.ID_HangHoa);
                    if (find != null)
                        db1.Entry(item).State = EntityState.Modified;
                    else
                        item = db1.HangHoas.Add(item);
                    db1.SaveChanges();
                    return item.ID_HangHoa;
                }
            }
        }
        #endregion

        public void Delete_ID(int id)
        {
            using (var db = new STORAGEEntities())
            {
                var obj = db.HangHoas.FirstOrDefault(x => x.ID_HangHoa == id);
                if (obj != null)
                {
                    db.HangHoas.Remove(obj);
                    db.SaveChanges();
                }
            }
        }
    }
}
