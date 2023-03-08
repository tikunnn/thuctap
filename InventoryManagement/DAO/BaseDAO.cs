using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.DAO
{
    public class BaseDAO
    {
        public STORAGEEntities _connect;
        //private static BaseDAO instance = null;
        public BaseDAO()
        {
            _connect = new STORAGEEntities();
        }

        //public static BaseDAO Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //            instance = new BaseDAO();
        //        return instance;
        //    }
        //}

        //public List<NhanVien> Select_All_NhanVien()
        //{
        //    return BaseDAO.Instance.Select_All_NhanVien();
        //}
    }
}
