using Singumonety.Data.Accounts;
using Singumonety.Data.Amount;

namespace Singumonety.Data.Operation
{
    public class Operation : Activable
    {
        public DateOnly Date { get; private set; }
        public OperationType Type { get; private set; }
        public Account Source { get; private set; }
        public OperationAccount FromTo { get; private set; }
        public IAmount Amount { get; private set; }
        public string Notes { get; private set; }
        public Label[] Labels { get; private set; }

        public Operation(DateOnly date, OperationType type, Account source, OperationAccount fromTo, IAmount amount, string notes, Label[] labels, bool active)
        {
            Date = date;
            Type = type;
            Source = source;
            FromTo = fromTo;
            Amount = amount;
            Notes = notes;
            Labels = labels;
            Active = active;
        }
    }
}
