using DAL_BUS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BUS.BUS
{
    public class AccountServices
    {
        AppDbContext _context;
        public AccountServices()
        {
            _context = new AppDbContext();
        }
        public string Login(string username, string password)
        {
            var account = _context.Accounts
                .FirstOrDefault(p => p.Username == username && p.Password == password);
            if (account == null) return "";
            else // Có tìm thấy
            {
                return account.Role + ":" + account.Username;
            }
        }
    }
}
