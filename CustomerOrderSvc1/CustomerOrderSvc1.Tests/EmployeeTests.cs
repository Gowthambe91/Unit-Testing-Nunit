using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerOrderSvc1;
using NUnit.Framework;

namespace CustomerOrderSvc1.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void When_ContainsIllegalChar_Expected_True() {

            //Arrange
            Employee employee = new Manager();

            employee.Name = "Gow$tham";

            //Act
            bool result = employee.ContainsIllegalChars();

            //Assert
            Assert.IsTrue(result);
        }
    }

    public class ManagerTests : EmployeeTests
    {
        
    }
}
