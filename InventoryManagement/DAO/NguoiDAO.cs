using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.DAO
{
    public class NguoiDAO : BaseDAO
    {
        public NguoiDAO() { }
        public NhanVien GetLogin(string username, string password)
        {
            return _connect.NhanViens.FirstOrDefault(x => x.UserName == username && x.Pasword == password);
        }
    }
}
