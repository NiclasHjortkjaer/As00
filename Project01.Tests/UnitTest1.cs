using System;
using Xunit;

namespace Project01.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void IsLeapYear2016()
        {
            //Arrange
            

            //Act
            bool leapYear = Program.IsLeapYear(2016);

            //Assert
            Assert.True(leapYear);
        }

        [Fact]
        public void IsLeapYear2100()
        {
            //Act
            bool leapYear = Program.IsLeapYear(2100);

            //Assert
            Assert.False(leapYear);
        }

        [Fact]
        public void IsLeapYear2400()
        {
            //Act
            bool leapYear = Program.IsLeapYear(2400);

            //Assert
            Assert.True(leapYear);
        }
    }
}
