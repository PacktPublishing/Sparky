﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Sparky
{
    public class CalculatorXUnitTests
    {
        [Fact]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            //Arrange
            Calculator calc = new();

            //Act
            int result = calc.AddNumbers(10, 20);


            //Assert
            Assert.Equal(30, result);
        }

        [Fact]
        public void IsOddChecker_InputEvenNumber_ReturnFalse()
        {
            Calculator calc = new();

            bool isOdd = calc.IsOddNumber(10);
            Assert.False(isOdd);
        }

        [Theory]
        [InlineData(11)]
        [InlineData(13)]
        public void IsOddChecker_InputOddNumber_ReturnTrue(int a)
        {
            Calculator calc = new();

            bool isOdd = calc.IsOddNumber(a);
            Assert.True(isOdd);
        }

        [Theory]
        [InlineData(10, false)]
        [InlineData(11, true)]
        public void IsOddChecker_InputNumber_ReturnTrueIfOdd(int a, bool expectedResult)
        {
            Calculator calc = new();
            var result = calc.IsOddNumber(a);
            Assert.Equal(expectedResult, result);
        }

        //[Fact]
        //[TestCase(5.4, 10.5)] //15.9
        //[TestCase(5.43, 10.53)] // 15.93
        //[TestCase(5.49, 10.59)] // 16.08
        //public void AddNumbersDouble_InputTwoDouble_GetCorrectAddition(double a, double b)
        //{
        //    //Arrange
        //    Calculator calc = new();

        //    //Act
        //    double result = calc.AddNumbersDouble(a, b);


        //    //Assert
        //    Assert.AreEqual(15.9, result, .2);
        //    //15.7-16.1
        //}


        //[Fact]
        //public void OddRanger_InputMinAndMaxRange_ReturnsValidOddNumberRange()
        //{
        //    Calculator calc = new();
        //    List<int> expectedOddRange = new() { 5, 7, 9 }; //5-10

        //    //act
        //    List<int> result = calc.GetOddRange(5, 10);

        //    //Assert
        //    Assert.That(result, Is.EquivalentTo(expectedOddRange));
        //    //Assert.AreEqual( expectedOddRange, result);
        //    //Assert.Contains(7, result);
        //    Assert.That(result, Does.Contain(7));
        //    Assert.That(result, Is.Not.Empty);
        //    Assert.That(result.Count, Is.EqualTo(3));
        //    Assert.That(result, Has.No.Member(6));
        //    Assert.That(result, Is.Ordered);
        //    Assert.That(result, Is.Unique);
        //}
    }
}
