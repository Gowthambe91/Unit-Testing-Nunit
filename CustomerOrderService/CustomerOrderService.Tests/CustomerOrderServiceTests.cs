using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderService.Tests
{
    
    [TestFixture]
    class CustomerOrderServiceTests
    {
        [Test] // Attributes the method to be a Test Method
        public void When_PremiumCustomer_Expect_10PercentDiscount()
        {
            //A Test Case Body is divided into 3 parts - AAA => Arrange, Act, Assert

            //Arrange for Premium Case
            Customer customer = new Customer()
            {
                CustomerID = 1,
                CustomerName = "Gowtham",
                CustomerType = CustomerType.Premium
            };

            Order order = new Order
            {
                OrderID = 1,
                ProductID = 1,
                ProductQuantity = 10,
                Amount = 100
            };

            BusinessLogic businessLogic = new BusinessLogic();

            //Act
            businessLogic.ApplyDiscount(customer, order);

            //Assert
            Assert.AreEqual(90, order.Amount);
        }

        [Test]
        public void When_SpecialCustomer_Expect_20PercentDiscount()
        {
            //A Test Case Body is divided into 3 parts - AAA => Arrange, Act, Assert

            //Arrange for Premium Case
            Customer customer = new Customer()
            {
                CustomerID = 1,
                CustomerName = "Gowtham",
                CustomerType = CustomerType.Special
            };

            Order order = new Order
            {
                OrderID = 1,
                ProductID = 1,
                ProductQuantity = 10,
                Amount = 100
            };

            BusinessLogic businessLogic = new BusinessLogic();

            //Act
            businessLogic.ApplyDiscount(customer, order);

            //Assert
            Assert.AreEqual(80, order.Amount);
        }

        [Test]
        public void When_BasicCustomer_Expect_NoDiscount()
        {
            //A Test Case Body is divided into 3 parts - AAA => Arrange, Act, Assert

            //Arrange for Premium Case
            Customer customer = new Customer()
            {
                CustomerID = 1,
                CustomerName = "Gowtham",
                CustomerType = CustomerType.Basic
            };

            Order order = new Order
            {
                OrderID = 1,
                ProductID = 1,
                ProductQuantity = 10,
                Amount = 100
            };

            BusinessLogic businessLogic = new BusinessLogic();

            //Act
            businessLogic.ApplyDiscount(customer, order);

            //Assert
            Assert.AreEqual(100, order.Amount);
        }
    }
}
