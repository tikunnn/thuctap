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
        public STORAGEEntities1 _connect;
        public BaseDAO()
        {
            _connect = new STORAGEEntities1();
        }
    }
}
