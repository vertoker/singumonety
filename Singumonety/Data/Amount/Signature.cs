using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singumonety.Data.Amount
{
    public class Signature
    {
        public IAmount[] Differences { get; private set; }

        public Signature(IAmount[] differences)
        {
            Differences = differences;
        }
    }
}
