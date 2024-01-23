using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    public abstract class BaseHandler : IHandler
    {
        private IHandler? _next;

        public void CallNext(string request)
        {
            if (_next != null)
            {
                _next.Handle(request);
            }
            else
            {
                Console.WriteLine($"left untouched.");
            }
        }

        public abstract void Handle(string request);

        public IHandler SetNext(IHandler next)
        {
            _next = next;
            return next;
        }
    }
}
