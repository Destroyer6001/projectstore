namespace Supermarker
{
    internal class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public List<Product> Products { get; set; }



        public override decimal ValueToPay()
        {
            decimal priceAccumulator = 0;
            decimal discountproduct;

            foreach (Product product in Products)
            {
                priceAccumulator += product.ValueToPay();
            }

            discountproduct = priceAccumulator * Convert.ToDecimal(Discount);
            return priceAccumulator - discountproduct;
        }

        public override string ToString()
        {
            List<string> productChain = new List<string>();

            foreach (Product product in Products)
            {
                productChain.Add(product.Description);
            }

            return $"{Id}-{Description}" +
                $"\n\tProducts............ :{$"{string.Join("", productChain)}",15}" +
                $"\n\tDiscond............. :{$"{Discount:P2}",15}" +
                $"\n\tValue to pay........ :{$"{ValueToPay():C2}",15}";
        }
    }
}

