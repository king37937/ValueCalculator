using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueCalculator;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace ValueCalculator.Tests
{
    [TestClass()]
    public class ValueCalculatorTests
    {
        private static IList _products;
         
        [TestMethod()]
        public void CalculateByGroupTest_countInGroup_3_columnName_Cost_should_return_6_15_24_21()
        {
            //arrange
            var target = new ValueCalculator(_products);
            var columnName = "Cost";
            var countInGroup = 3;
            var expected = new int[6, 15, 24, 21];
            //act
            var actual = target.CalculateByGroup(columnName, countInGroup);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateByGroupTest_columnName_Revenue_countInGroup_4_should_return_50_66_60()
        {
            //arrange
            var target = new ValueCalculator(_products);
            var columnName = "Revenue";
            var countInGroup = 4;
            var expected = new int[50, 66, 60];
            //act
            var actual = target.CalculateByGroup(columnName, countInGroup);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateByGroupTest_columnName_Revenue_countInGroup_0_should_throw_ArgumentException()
        {
            //arrange
            var target = new ValueCalculator(_products);
            var columnName = "Revenue";
            var countInGroup = 0;

            //act
            Action actual = () => target.CalculateByGroup(columnName, countInGroup);

            //assert
            actual.ShouldThrow<ArgumentException>();
        }

        [TestMethod()]
        public void CalculateByGroupTest_columnName_Revenue_countInGroup_negative_1_should_throw_ArgumentException()
        {
            //arrange
            var target = new ValueCalculator(_products);
            var columnName = "Revenue";
            var countInGroup = -1;

            //act
            Action actual = () => target.CalculateByGroup(columnName, countInGroup);

            //assert
            actual.ShouldThrow<ArgumentException>();
        }

        [TestMethod()]
        public void CalculateByGroupTest_columnName_NotExist_countInGroup_5_should_throw_ArgumentException()
        {
            //arrange
            var target = new ValueCalculator(_products);
            var columnName = "NotExist";
            var countInGroup = 5;

            //act
            Action actual = () => target.CalculateByGroup(columnName, countInGroup);

            //assert
            actual.ShouldThrow<ArgumentException>();
        }

        [TestMethod()]
        public void CalculateByGroupTest_countInGroup_1_columnName_Cost_should_return_1_2_3_4_5_6_7_8_9_10_11()
        {
            //arrange
            var target = new ValueCalculator(_products);
            var columnName = "Cost";
            var countInGroup = 1;
            var expected = new int[1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11];
            //act
            var actual = target.CalculateByGroup(columnName, countInGroup);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateByGroupTest_countInGroup_11_columnName_Cost_should_return_66()
        {
            //arrange
            var target = new ValueCalculator(_products);
            var columnName = "Cost";
            var countInGroup = 11;
            var expected = new int[66];
            //act
            var actual = target.CalculateByGroup(columnName, countInGroup);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [ClassInitialize]
        public static void InitProducts(TestContext testContext)
        {
            _products = new List<Product>
            {
                new Product(1, 1, 11, 21),
                new Product(2,2,12,22),
                new Product(3,3,13,23),
                new Product(4,4,14,24),
                new Product(5,5,15,25),
                new Product(6,6,16,26),
                new Product(7,7,17,27),
                new Product(8,8,18,28),
                new Product(9,9,19,29),
                new Product(10,10,20,30),
                new Product(11,11,21,31)
            };
        }
    }


}