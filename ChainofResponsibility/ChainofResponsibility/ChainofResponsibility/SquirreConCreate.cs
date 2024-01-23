using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    public class SquirreConCreate : BaseHandler
    {
        public override void Handle(string request)
        {
            if (request == "Nut")
            {
                Console.WriteLine($"Squirrel: I'll eat the {request}.");
            }
            else
            {
                CallNext(request);
            }
        }
    }
}
