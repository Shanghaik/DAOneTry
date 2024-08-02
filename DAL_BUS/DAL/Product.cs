using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BUS.DAL
{
    public class Product
    {
        [Key] 
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; } // Mô tả
        public string ImgURL { get; set; } // Link ảnh
        public string From { get; set; }
        public long Price { get; set; }
        public int TotalAmount { get; set; } // SỐ lượng còn
        public int Status { get; set; }
        public Guid? SaleID { get; set; }
        // Navigation
        public virtual List<BillDetails> BillDetails { get; set; }
        public virtual Sale Salep { get; set; }
    }
}
