namespace Singumonety.Data.Amount
{
    public class CurrencyAmount : IAmount
    {
        public decimal AmountFrom { get; private set; }
        public CurrencyCode CurrencyFrom { get; private set; }
        public decimal AmountTo { get; private set; }
        public CurrencyCode CurrencyTo { get; private set; }

        public CurrencyAmount(decimal amountFrom, CurrencyCode currencyFrom, decimal amountTo, CurrencyCode currencyTo)
        {
            AmountFrom = amountFrom;
            CurrencyFrom = currencyFrom;
            AmountTo = amountTo;
            CurrencyTo = currencyTo;
        }
    }
}
