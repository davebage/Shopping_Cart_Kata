using System.Collections.Generic;

namespace ParallelAndNarrowChange.Field
{
    public class ShoppingCart{
        private decimal price;
        private List<decimal> _prices = new List<decimal>();

        public decimal CalculateTotalPrice(){
            return price;
        }

        public bool HasDiscount(){
            return price > 100;
        }

        public void Add(int aPrice){
            this.price = aPrice;
            _prices.Add(aPrice);
        }

        public int NumberOfProducts(){
            return 1;
        }
    }
}
