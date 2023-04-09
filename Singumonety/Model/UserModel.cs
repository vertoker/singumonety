using Java.Nio.Channels;
using Singumonety.Model;
using Singumonety.Data;
using Singumonety.Data.Accounts;
using Singumonety.Data.Operation;

namespace Singumonety.Model
{
    public class UserModel
    {
        public Dictionary<DateOnly, List<Operation>> Operations { get; private set; }
        public List<Account> Accounts { get; private set; }
        public User User { get; private set; }

        public UserModel()
        {
            Operations = new Dictionary<DateOnly, List<Operation>>();
            Accounts = new List<Account>();
        }

        public UserModel(List<Operation> operations, List<Account> accounts)
        {
            Operations = Extensions.Convert(operations);
            Accounts = accounts;
        }

        public void AddOperation(Operation operation)
        {
            if (!Operations.ContainsKey(operation.Date))
                Operations.Add(operation.Date, new List<Operation>());
            Operations[operation.Date].Add(operation);
        }
    }
}


