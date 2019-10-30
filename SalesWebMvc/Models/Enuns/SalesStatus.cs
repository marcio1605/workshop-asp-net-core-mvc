using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models.Enuns
{
    public enum SalesStatus : int
    {
        Pending = 0,
        Billed= 1,
        Canceled = 2
    }
}
