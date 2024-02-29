using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatePattern.States;

namespace StatePattern
{
    public class Order
    {
        public Order() { 
            State = new DraftState(this);
        }
        public IStateOrder State { get; set; }
        public List<OrderLine> Lines { get; set; } = new List<OrderLine>();

        public void Confirm()
        {
            State.Confirm();
        }
        public void Cancel()
        {
            State.Cancel();
        }
        public void Process()
        {
            State.Process();
        }
        public void Ship()
        {
            State.Ship();
        }
        public void Deliver()
        {
            State.Deliver();
        }
        public void Return()
        {
            State.Return();
        }
    }
}
