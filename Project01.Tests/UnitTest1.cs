using System;
using Xunit;
using System.IO;

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

        [Fact]
        public void IsLeapYear1200(){
            //Act
            bool leapYear = Program.IsLeapYear(1200);

            //Assert
            Assert.False(leapYear);
        }

        [Fact]
        public void Main_prints_yay(){
            //Arrange
            StringWriter writer = new StringWriter();
            Console.SetOut(writer);

            //Act
            Program.Main(new String[]{"2020"});
            var output = writer.GetStringBuilder().ToString().Trim();

            //Assert
            Assert.Equal("yay", output);
        }

        [Fact]
        public void Main_prints_nay(){
            //Arrange
            StringWriter writer = new StringWriter();
            Console.SetOut(writer);

            //Act
            Program.Main(new String[]{"2021"});
            var output = writer.GetStringBuilder().ToString().Trim();

            //Assert
            Assert.Equal("nay", output);
        }

        [Fact]
        public void Main_prints_error(){
            //Arrange
            StringWriter writer = new StringWriter();
            Console.SetOut(writer);

            //Act
            Program.Main(new String[]{"Hello World!"});
            var output = writer.GetStringBuilder().ToString().Trim();

            //Assert
            Assert.Equal("Please only input integers", output);
        }
    }
}
