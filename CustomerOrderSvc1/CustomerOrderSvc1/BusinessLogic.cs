using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderSvc1
{
    public class BusinessLogic
    {
        public void ApplyDiscount(Customer customer, Order order)
        {
            if (customer.CustomerType == CustomerType.Premium)
            {
                order.Amount = order.Amount - ((order.Amount) * 10 / 100);
            }
            else if (customer.CustomerType == CustomerType.Special)
            {
                order.Amount = order.Amount - ((order.Amount) * 20 / 100);
            }
        }
    }
}
