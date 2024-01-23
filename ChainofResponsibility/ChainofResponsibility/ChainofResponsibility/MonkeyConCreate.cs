using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    public class MonkeyConCreate : BaseHandler
    {
        public override void Handle(string request)
        {
            if (request == "Banana")
            {
                Console.WriteLine($"Monkey: I'll eat the {request}.");
            }
            else
            {
                CallNext(request);
            }
        }
    }
}
