namespace ParallelAndNarrowChange.Field
{
    public class Product
    {
        private const decimal EXPENSIVE_PRICE = 100;
        private readonly decimal _price;

        public Product(decimal price)
        {
            _price = price;
        }

        public decimal GetPrice()
        {
            return _price;
        }

        public bool IsExpensive()
        {
            return _price >= EXPENSIVE_PRICE;
        }
    }
}