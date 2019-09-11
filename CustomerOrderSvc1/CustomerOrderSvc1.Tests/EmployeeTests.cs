using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerOrderSvc1;
using NUnit.Framework;

namespace CustomerOrderSvc1.Tests
{
    [TestFixture]
    [TestFixture(CustomerType.Basic,100.00, TypeArgs = new Type[] { typeof(CustomerType), typeof(double)})]
    public class EmployeeTests<T1,T2>
    {
        private T1 customerType;
        private T2 doubleValue;

        public EmployeeTests(T1 customerType, T2 doubleValue )
        {
            this.customerType = customerType;
            this.doubleValue = doubleValue;
        }

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

        [Test]
        public void When_ContainsExpectedType_Expected_CustomerTypeAndDouble()
        {
            Assert.That(customerType, Is.TypeOf<CustomerType>());
            Assert.That(doubleValue, Is.TypeOf<double>());
        }
    }

    /*Test Fixture gets inherited, though i didn't give explicitly, i can see commenting the inheritance of EmployeeTests, not 
     * showing in the Left pane */

    public class ManagerTests
    {
        public void When_Expected_True() {

            Assert.That(1 == 1);
        }
    }


}
