using System;
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

        public decimal GetPrice()
        {
            return _price;
        }
    }

    public class ShoppingCart{
        private readonly List<Product> _products = new List<Product>();
        private const decimal EXPENSIVE_PRICE = 100;

        public decimal CalculateTotalPrice(){
            return _products.Sum(product => product.GetPrice());
        }

        public bool HasDiscount(){
            return _products.Any(product => product.GetPrice() > EXPENSIVE_PRICE);
        }

        public void Add(int aPrice){
            _products.Add(new Product(aPrice));
        }

        public int NumberOfProducts(){
            return _products.Count;
        }
    }
}
