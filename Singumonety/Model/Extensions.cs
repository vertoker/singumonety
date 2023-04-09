using Singumonety.Data.Operation;

namespace Singumonety.Model
{
    public static class Extensions
    {
        public static Dictionary<DateOnly, List<Operation>> Convert(List<Operation> operations)
        {
            var data = new Dictionary<DateOnly, List<Operation>>();

            foreach (var op in operations)
            {
                if (!data.ContainsKey(op.Date))
                    data.Add(op.Date, new List<Operation>());
                data[op.Date].Add(op);
            }

            return data;
        }
    }
}
