using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    public class DogConCreate : BaseHandler
    {
        public override void Handle(string request)
        {
            if (request == "MeatBall")
            {
                Console.WriteLine($"Dog: I'll eat the {request}.");
            }
            else
            {
                CallNext(request);
            }
        }
    }
}
