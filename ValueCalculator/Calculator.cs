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
        private IList<Product> _products;

        public ValueCalculator(IList<Product> products)
        {
            _products = products;
        }

        public List<int> CalculateByGroup(string columnName, int countInGroup)
        {
            if (countInGroup <= 0)
            {
                throw new ArgumentException(string.Format("Invaild argument: {0}", countInGroup));
            }
            return new List<int>();
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public int Revenue { get; set; }
        public int SellPrice { get; set; }
    }

}
