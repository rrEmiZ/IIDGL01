using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ConsoleApp23.Tests
{
    public class Calculator_Tests
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, 2, 1)]
        [InlineData(-1, -2, -3)]
        public void Add_for_a_and_b_returns_c(int a, int b, int c)
        {
            //Act
            var calc = new Calculator();
            int result = calc.Add(a, b);

            //Assert
            Assert.Equal(c, result);
        }



        [Fact]
        public void Add_for_1_and_2_returns_3()
        {
            //Parameters
            int a = 1;
            int b = 2;
            int c = 3;

            //Act
            var calc = new Calculator();
            int result = calc.Add(a, b);

            //Assert
            Assert.Equal(c, result);
        }

        [Fact]
        public void Add_for_N1_and_2_returns_1()
        {
            //Parameters
            int a = -1;
            int b = 2;
            int c = 1;

            //Act
            var calc = new Calculator();
            int result = calc.Add(a, b);

            //Assert
            Assert.Equal(c, result);
        }
    }
}
