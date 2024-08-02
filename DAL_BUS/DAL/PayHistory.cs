using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BUS.DAL
{
    public class PayHistory // Lần thanh toán
    {
        [Key]
        public Guid Id { get; set; }
        public Guid BillID { get; set; }
        public Guid PaymentId { get; set; }
        public long Value { get; set; }
        public string Note { get; set; }
        // Navi
        public virtual Payment Payment { get; set; }
        public virtual Bill Bill { get; set; }
    }
}
