using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRL.ViewModels
{
    public class SaleProduct 
    {
        // Chúng ta tạo ra 1 ViewModel để chứa sản phẩm sau khi đã sale, giá bán thực tế lưu hóa đơn là giá SalePrice
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; } // Mô tả
        public string ImgURL { get; set; } // Link ảnh
        public string From { get; set; }
        public long Price { get; set; }
        public int TotalAmount { get; set; } // SỐ lượng còn
        public int Status { get; set; }
        public long SalePrice { get; set; }
    }
}
