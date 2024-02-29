using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public enum OrderState
    {
        Draft,
        Confirmed,
        Canceled,
        UnderProcessing,
        Shiped,
        Delivered,
        Returned
    };
}
