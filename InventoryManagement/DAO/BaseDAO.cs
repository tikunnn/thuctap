using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.DAO
{
    public class BaseDAO
    {
        public STORAGEEntities _connect;
        public BaseDAO()
        {
            _connect = new STORAGEEntities();
        }
    }
}
