using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderSvc1
{
    public class Order
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int ProductQuantity { get; set; }
        public decimal Amount { get; set; }
    }
}
