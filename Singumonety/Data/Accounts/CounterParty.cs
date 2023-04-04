namespace Singumonety.Data.Accounts
{
    public class CounterParty : OperationAccount
    {
        public string Name { get; }
        public decimal Balance { get; }
        public CurrencyCode Currency { get; }

        public CounterParty(string name, decimal balance, CurrencyCode currency, bool active)
        {
            Name = name;
            Balance = balance;
            Currency = currency;
            Active = active;
        }
    }
}
