namespace Supermarker
{
    internal class FixedPriceProduct : Product
    {
        public override decimal ValueToPay()
        {
            decimal tax = Price * Convert.ToDecimal(Tax);
            return Price + tax;
        }

        public override string ToString()
        {
            return $"{ base.ToString()}" +
                   $"\n\tValue to pay....... :{$"{ValueToPay():C2}",15}";
        }
    }
}
