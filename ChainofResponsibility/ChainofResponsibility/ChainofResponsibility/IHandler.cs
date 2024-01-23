using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    public interface IHandler
    {
        IHandler SetNext(IHandler next);
        void Handle(string request);
        void CallNext(string request);
    }
}
