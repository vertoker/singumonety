using Singumonety.Data;
using Singumonety.Data.Accounts;
using Singumonety.Data.Operation;

namespace Singumonety.Model
{
    public class AppDataHandler
    {
        public UserModel User { get; private set; }
        public CategoryModel Category { get; private set; }
        public CounterPartiesModel CounterParties { get; private set; }
        public LabelModel Label { get; private set; }


        public AppDataHandler(UserModel user, CategoryModel category, CounterPartiesModel counterParties, LabelModel label)
        {
            User = user;
            Category = category;
            CounterParties = counterParties;
            Label = label;
        }
    }
}
