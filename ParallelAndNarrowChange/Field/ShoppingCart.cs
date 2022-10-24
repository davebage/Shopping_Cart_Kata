using System.Collections.Generic;
using System.Linq;

namespace ParallelAndNarrowChange.Field
{
    public class Product
    {
        private readonly decimal _price;

        public Product(decimal price)
        {
            _price = price;
        }
    }
    public class ShoppingCart{
        private readonly List<decimal> _prices = new List<decimal>();
        private readonly List<Product> _products = new List<Product>();

        public decimal CalculateTotalPrice(){
            return _prices.Sum(price => price);
        }

        public bool HasDiscount(){
            return _prices.Any(price => price > 100);
        }

        public void Add(int aPrice){
            _prices.Add(aPrice);
            _products.Add(new Product(aPrice));
        }

        public int NumberOfProducts(){
            return _products.Count;
        }
    }
}
