using api2;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Test
{
    public class Test
    {
        [Test]
        public void TestValidateEmail(string email, bool expectedResult)
        {
            // Arrange
            var accountController = new ugyfel();

            // Act
            var actualResult = ugyfel.ValidateEmail(email);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
