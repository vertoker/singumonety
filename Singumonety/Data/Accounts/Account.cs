using Singumonety.Data.Amount;

namespace Singumonety.Data.Accounts
{
    public class Account : OperationAccount
    {
        public string Name { get; private set; }
        public decimal Balance { get; private set; }
        public CurrencyCode Currency { get; private set; }
        public User User { get; private set; }

        public Account(string name, decimal balance, CurrencyCode currency, User user, bool active)
        {
            Name = name;
            Balance = balance;
            Currency = currency;
            User = user;
            Active = active;
        }
    }
}
