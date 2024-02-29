using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
    public class ConfirmState : IStateOrder
    {
        private readonly Order _order;

        public ConfirmState(Order order)
        {
            _order = order;
        }
        public void Cancel()
        {
            _order.State = new CancelState(_order);
        }

        public void Confirm()
        {
            throw new NotImplementedException();
        }

        public void Deliver()
        {
            throw new NotImplementedException();
        }

        public void Process()
        {
            _order.State = new ProcessState(_order);
        }

        public void Return()
        {
            throw new NotImplementedException();
        }

        public void Ship()
        {
            throw new NotImplementedException();
        }
    }
}
