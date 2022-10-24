using System.Collections.Generic;
using System.Linq;

namespace ParallelAndNarrowChange.Field
{
    public class ShoppingCart{
        private readonly List<decimal> _prices = new List<decimal>();

        public decimal CalculateTotalPrice(){
            return _prices.Sum(price => price);
        }

        public bool HasDiscount(){
            return _prices.Any(price => price > 100);
        }

        public void Add(int aPrice){
            _prices.Add(aPrice);
        }

        public int NumberOfProducts(){
            return _prices.Count;
        }
    }
}
