using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderSvc1
{
        public enum CustomerType
        {
            Basic,
            Premium,
            Special
        }
        public class Customer
        {
            public int CustomerID { get; set; }
            public string CustomerName { get; set; }

            public CustomerType CustomerType { get; set; }
        }
}
