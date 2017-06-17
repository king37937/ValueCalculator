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
        private static IList<Product> _products;

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
                new Product{Id = 1, Cost = 1, Revenue = 11, SellPrice = 21},
                new Product{Id = 2, Cost = 2, Revenue = 12, SellPrice = 22},
                new Product{Id = 3, Cost = 3, Revenue = 13, SellPrice = 23},
                new Product{Id = 4, Cost = 4, Revenue = 14, SellPrice = 24},
                new Product{Id = 5, Cost = 5, Revenue = 15, SellPrice = 25},
                new Product{Id = 6, Cost = 6, Revenue = 16, SellPrice = 26},
                new Product{Id = 7, Cost = 7, Revenue = 17, SellPrice = 27},
                new Product{Id = 8, Cost = 8, Revenue = 18, SellPrice = 28},
                new Product{Id = 9, Cost = 9, Revenue = 19, SellPrice = 29},
                new Product{Id = 10, Cost= 10, Revenue = 20, SellPrice = 30},
                new Product{Id = 11, Cost= 11, Revenue = 21, SellPrice = 31}
            };
        }
    }


}