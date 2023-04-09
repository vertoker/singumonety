using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singumonety.Data.Operation
{
    public class Label : Activable
    {
        public string Name { get; private set; }

        public Label(string name, bool active)
        {
            Name = name;
            Active = active;
        }
    }
}
