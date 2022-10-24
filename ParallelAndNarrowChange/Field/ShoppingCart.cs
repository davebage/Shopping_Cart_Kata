using System.Collections.Generic;
using System.Linq;

namespace ParallelAndNarrowChange.Field
{
    public class ShoppingCart{
        private decimal price;
        private List<decimal> _prices = new List<decimal>();

        public decimal CalculateTotalPrice(){
            return price;
        }

        public bool HasDiscount(){
            return _prices.Any(price => price > 100);
        }

        public void Add(int aPrice){
            this.price = aPrice;
            _prices.Add(aPrice);
        }

        public int NumberOfProducts(){
            return _prices.Count;
        }
    }
}
