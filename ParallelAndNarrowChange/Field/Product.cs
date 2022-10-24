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
}