using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueCalculator
{
    public class ValueCalculator
    {
        private IList _products;

        public ValueCalculator(IList products)
        {
            _products = products;
        }

        public List<int> CalculateByGroup(string columnName, int countInGroup)
        {
            return new List<int>();
        }
    }

    public class Product
    {
        private int _id;
        private int _cost;
        private int _revenue;
        private int _sellPrice;

        public Product(int id, int cost, int revenue, int sellPrice)
        {
            _id = id;
            _cost = cost;
            _revenue = revenue;
            _sellPrice = sellPrice;
        }
    }

}
