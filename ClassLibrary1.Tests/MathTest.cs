using System;
using Xunit;

namespace ClassLibrary1.Tests
{
    public class MathTest
    {
        [Fact]
        public void IsOddTest()
        {
            //Arrange
            var num = 2;

            //Act
            bool result = Math.IsOdd(num);

            //Assert
            Assert.True(result);
        }
    }
}
