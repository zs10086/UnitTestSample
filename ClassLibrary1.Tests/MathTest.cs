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
            var num = 1;
            var num2 = 2;

            //Act
            bool result = Math.IsOdd(num);
            bool result2 = Math.IsOdd(num2);

            //Assert
            Assert.True(result);
            Assert.False(result2);
        }
    }
}
