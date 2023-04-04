namespace Singumonety.Data.Amount
{
    public class DefaultAmount : IAmount
    {
        public decimal Amount { get; private set; }
        public CurrencyCode Currency { get; private set; }

        public DefaultAmount(decimal amount, CurrencyCode currency)
        {
            Amount = amount;
            Currency = currency;
        }
    }
}
