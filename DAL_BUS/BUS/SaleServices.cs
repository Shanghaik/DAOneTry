using DAL_BUS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BUS.BUS
{
    public class SaleServices
    {
        // Chú ý đối với sale thì chúng ta cần quan tâm đến các vấn đề sau:
        // Thời gian (Ngày bắt đầu < ngày kết thúc, nếu tạo mới thì ngày bắt đầu phải kể từ ngày hiện tại,
        // ngày kết thúc không thể trước ngày hiện tại,...
        // percent - % giảm phải từ 0 đến 100%
        AppDbContext _context;
        public SaleServices()
        {
            _context = new AppDbContext();
        }
        public List<Sale> GetAllSales()
        {
            return _context.Sales.ToList();
        }
        public string CreateSales(Sale sale)
        {
            // Validate
            if (sale.StartDate < DateTime.Now || sale.EndDate < DateTime.Now || sale.StartDate > sale.EndDate)
            {
                return "Kiểm tra lại thời hạn của chương trình khuyến mãi";
            }
            else if (sale.Percent > 100 || sale.Percent < 0)
            {
                return "% giảm không thể ngoài khoảng 0-100";
            }else
            {
                _context.Sales.Add(sale);
                _context.SaveChanges();
                return "Tạo mới khuyến mãi thành công";
            }
        }
    }
}
