using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.DAO
{
    public class HangDAO : BaseDAO
    {
        public HangDAO() { } 
        public STORAGEEntities GetContext()
        {
            return new STORAGEEntities();
        }

        public List<HangHoa> GetAll_HangHoa()
        {
            using (var db = new STORAGEEntities())
            {
                var ls = db.HangHoas.AsQueryable();
                if (ls != null & ls.Any())
                    return ls.ToList();
                return new List<HangHoa>();
            }
        }

        //public List<HangHoa> Find_KeyWord(string Keyword)
        //{
        //    using (var db = new STORAGEEntities())
        //    {
        //        if (!string.IsNullOrWhiteSpace(Keyword))
        //        {
        //            var obj = db.HangHoas.FirstOrDefault(s => s.ID_HangHoa.ToString().CompareTo(Keyword) == 0);
        //            if (obj != null)
        //            {
        //                List<HangHoa> ls = new List<HangHoa>();
        //                ls.Add(obj);
        //                return ls;
        //            }
        //            var list = db.HangHoas.AsQueryable();
        //            list = list.Where(s => s.ID_HangHoa.ToString().Contains(Keyword)
        //            || s.Ten.ToLower().Contains(Keyword)
        //            );
        //            if (list != null && list.Any())
        //            {
        //                return list.OrderByDescending(s => s.ID_HangHoa).ToList();
        //            }
        //        }
        //        else
        //        {
        //            var list = db.HangHoas.AsQueryable();
        //            if (list != null && list.Any())
        //            {
        //                return list.OrderByDescending(s => s.ID_HangHoa).ToList();
        //            }
        //        }
        //        return new List<HangHoa>();
        //    }
        //}

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
    }
}
