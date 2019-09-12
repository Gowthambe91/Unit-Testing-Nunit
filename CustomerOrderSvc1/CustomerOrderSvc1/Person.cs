using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderSvc1
{
    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public bool SeniorCitizen()
        {
            if (this.Age >= 60)
            {
                return true;
            }

            return false;
        }
    }
}
