using DAL_BUS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BUS.BUS
{
    public class ProductServices
    {
        AppDbContext _context;
        public ProductServices()
        {
            _context = new AppDbContext();
        }
        public List<Product> GetAllProducts()
        {  // Get all
            return _context.Products.ToList();
        }
        public string CreateProduct(Product product)
        {
            // Validate các thuộc tính
            if (product.Name.Trim() == "" || product.Details.Trim() == "" || product.From.Trim() == "")
            {
                return "Hãy kiểm tra lại dữ liệu không được trống";
            }
            else if (product.Price < 0 || product.TotalAmount < 0)
            {
                return "Giá hoặc số lượng không thể là giá trị âm";
            }
            else if (string.IsNullOrEmpty(product.ImgURL))
            {
                return "Đường dẫn ảnh đang trống";
            }
            else
            {
                try
                {
                    _context.Products.Add(product);
                    _context.SaveChanges();
                    return "Thêm mới sản phẩm thành công";
                }
                catch (Exception e)
                {
                    return "Thêm thất bại " + e.Message;
                }
            }
        }
        public List<Product> SearchByName(string name) // Tìm những sản phẩm mà tên có chứa sản phẩm như thế
        {
            return _context.Products.Where(p => p.Name.ToLower().Contains(name.ToLower())).ToList();
            // ToLower => Chuyển về dạng viết thường để tìm kiếm hoa thường đều được
        }
        public string LockProduct(Guid id)
        {
            var product = _context.Products.Find(id);
            if (product.Status == 0) return "Sản phẩm đã bị khóa, không thể khóa";
            else
            {
                product.Status = 0;
                _context.Products.Update(product);
                _context.SaveChanges();
                return "Khóa sản phẩm thành công";
            }
        }
        public string UnLockProduct(Guid id)
        {
            var product = _context.Products.Find(id);
            if (product.Status != 0) return "Sản phẩm không bị khóa, không thể mở khóa";
            else
            {
                product.Status = 1;
                _context.Products.Update(product);
                _context.SaveChanges();
                return "Khóa sản phẩm thành công";
            }
        }
        public string UpdateProduct(Product product)
        {
            var updateProduct = _context.Products.Find(product.Id);
            updateProduct.Name = product.Name;
            updateProduct.ImgURL = product.ImgURL;
            updateProduct.Status = product.Status;
            updateProduct.SaleID = product.SaleID;
            // Chỉ làm 4 cái thôi, =))) tự làm còn lại nhé
            _context.Products.Update(updateProduct);
            _context.SaveChanges();
            return "Sửa thành công";
        }
    }
}
