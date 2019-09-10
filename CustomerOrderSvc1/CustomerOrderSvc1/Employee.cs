using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderSvc1
{
    public abstract class Employee
    {
        public string Name { get; set; }

        public bool ContainsIllegalChars()
        {
            if (this.Name.Contains("$"))
            {
                return true;
            }

            return false;
        }

        public abstract Employee CreateEmployee();
    }

    public class Manager : Employee
    {
        public override Employee CreateEmployee()
        {
            return new Manager();
        }
    }

    public class DeliveryManager : Employee
    {
        public override Employee CreateEmployee()
        {
            return new DeliveryManager();
        }
    }
}
