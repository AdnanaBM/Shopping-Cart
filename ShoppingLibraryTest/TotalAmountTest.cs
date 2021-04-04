using NUnit.Framework;
using ShoppingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Assert = Xunit.Assert;
using TheoryAttribute = Xunit.TheoryAttribute;

namespace ShoppingLibraryTest
{
    public class TotalAmountTest
    {
        [Theory]
        [InlineData(25, 2, 27)]
        [InlineData(22, 6.25, 28.25)]
        [InlineData(double.MaxValue, 5, double.MaxValue)]
        public void Add_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            // Arrange

            // Act
            double actual = TotalAmount.Add(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        
        public void TotalPriceOfaProduct_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            // Arrange

            // Act
            double actual = TotalAmount.TotalPriceOfaProduct(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }
        
        [Theory]

        [InlineData(11, true)]
        [InlineData(9,false)]
        public void TotalAmountBigger_SimpleValuesShouldCompare(double x, bool expected)
        {
            // Arrange

            // Act
            bool actual = TotalAmount.TotalAmountBigger(x);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 4, 4)]
        [InlineData(double.MaxValue, 5, double.MaxValue)]
        public void RemoveItem_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            // Arrange
            

            // Act
            double actual = TotalAmount.RemoveItem(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        
    }

}

