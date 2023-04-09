using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singumonety.Model.Reports
{
    public class ReportsHandler
    {
        public SignatureModel Signature { get; set; }

        public ReportsHandler(SignatureModel signature)
        {
            Signature = signature;
        }
    }
}
