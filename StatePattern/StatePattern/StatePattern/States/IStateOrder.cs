using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
    public interface IStateOrder
    {
        void Confirm();
        void Cancel();
        void Process();
        void Ship();
        void Deliver();
        void Return();
    }
}
