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
        // Phương thức create - tạo account
        public string CreateAccount(string username, string password, int role)
        {
            Account account = new Account() // Tạo account mới từ thông tin được truyền vào
            {
                Role = role,
                Password = password,
                Username = username
            };
            try
            {
                _context.Accounts.Add(account);
                _context.SaveChanges();
                return "Tạo thành công";
            }
            catch (Exception e)
            {
                return "Tạo thất bại " + e.Message;
            }
        }
        public List<Account> GetAccounts() // Lấy tất cả danh sách của các Account
        {
            return _context.Accounts.ToList();
        }
        public string LockAccount(string username) // Khóa tài khoản
        {
            var account = _context.Accounts.Find(username); // Tìm ra user cần bị khóa
            if (account.Role == 1)
            {
                return "Không thể khóa một tài khoản admin";
            }
            else if (account.Role == 0)
            {
                return "Tài khoản đã bị khóa, không thể khóa thêm";
            }
            account.Role = 0; // Tự hiểu 0 là khóa trong các trường hợp còn lại
            try
            {
                _context.Accounts.Update(account);
                _context.SaveChanges(); return "Đã khóa tài khoản " + username;
            }
            catch (Exception e)
            {
                return "Khóa thất bại " + e.Message;
            }
        }
        public string UnLockAccount(string username) // Mở khóa tài khoản
        {
            var account = _context.Accounts.Find(username); // Tìm ra user cần bị khóa
            if (account.Role != 0)
            {
                return "Không thể mở khóa cho tài khoản không bị khóa";
            }
            account.Role = 2; // Tự hiểu 2 là user thường
            try
            {
                _context.Accounts.Update(account);
                _context.SaveChanges(); return "Đã mở khóa tài khoản " + username;
            }
            catch (Exception e)
            {
                return "Mở khóa thất bại " + e.Message;
            }
        }
        public string UpdateAccount(string username, string password, int status)
        {
            var account = _context.Accounts.Find(username);
            if (account == null) // Không tìm thấy
            {
                return "Không tìm thấy tài khoản cần sửa";
            }
            else
            {
                account.Role = status;
                account.Password = password; // Không sửa username vì nó là khóa chính
                _context.Accounts.Update(account);
                _context.SaveChanges();
                return "Sửa thành công";
            }
        }
    }
}
