using System;
using System.Collections.Generic;
using System.Linq;

namespace ParallelAndNarrowChange.Field
{
    public class ShoppingCart{
        private readonly List<Product> _products = new List<Product>();

        public decimal CalculateTotalPrice(){
            return _products.Sum(product => product.GetPrice());
        }

        public bool HasDiscount(){
            return _products.Any(product => product.IsExpensive());
        }

        public void Add(int aPrice){
            _products.Add(new Product(aPrice));
        }

        public int NumberOfProducts(){
            return _products.Count;
        }
    }
}
