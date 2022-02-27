namespace Supermarker
{
    internal class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }
        public float Quantity { get; set; }

        public override decimal ValueToPay()
        {
            decimal measurePrice = Price * Convert.ToDecimal(Quantity);
            decimal basicTax = measurePrice * Convert.ToDecimal(Tax);
            return measurePrice + basicTax;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tMeasurement........ :{$"{Measurement}",15}" +
                $"\n\tQuantity........... :{$"{Quantity:P2}",15}" +
                $"\n\tValue to pay....... :{$"{ValueToPay():C2}",15}";
        }
    }
}
