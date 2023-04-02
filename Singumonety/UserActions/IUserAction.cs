using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singumonety.UserActions
{
    public interface IUserAction
    {
        public void Undo();
        public void Redo();
    }
}
