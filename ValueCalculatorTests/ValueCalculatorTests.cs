using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValueCalculator;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var products = _products;
            var target = new ValueCalculator(products);
            var countInGroup = 3;
            var columnName = "Cost";
            var expected = new int[6, 15, 24, 21];
            //act
            var actual = target.CalculateByGroup(countInGroup, columnName);

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