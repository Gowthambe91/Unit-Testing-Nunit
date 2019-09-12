using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CustomerOrderSvc1;

namespace CustomerOrderSvc1.Tests
{
    [TestFixture]
    public class PersonTests
    {        
        [TestCase(60,ExpectedResult = true)]
        [TestCase(59, ExpectedResult = false)]
        [TestCase(60.5, ExpectedResult = true)]
        [TestCase(59.9,ExpectedResult = false)]
        public void When_AgeGreaterOrEqual60_Expected_True(int Age)
        {
            //Arrange
            Person person = new Person();
            person.Age = Age;

            //Act
            bool result = person.SeniorCitizen();

            //Assert
            Assert.IsTrue(result);

        }


    }
}
