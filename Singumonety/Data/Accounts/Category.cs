namespace Singumonety.Data.Accounts
{
    public class Category : OperationAccount
    {
        public string Name { get; private set; }

        public Category(string name, bool active)
        {
            Name = name;
            Active = active;
        }
    }
}
