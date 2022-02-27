namespace Supermarker
{
    internal class Invoice : IPay
    {
        private List<Product> _products;

        public Invoice()
        {
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);

        }


        public decimal ValueToPay()
        {
            decimal valueaccumulator = 0;

            foreach (Product Product in _products)
            {
                valueaccumulator += Product.ValueToPay();
            }

            return valueaccumulator;
        }

        public override string ToString()
        {
            return $"RECEIPT" +
                $"\n\t--------------------------------------------------" +
                $"\n{string.Join("\n", _products)}" +
                $"\n\t--------------------------------------------------" +
                $"\n\tTotal{$"{ValueToPay():C2}",32}";
        }
    }
}
