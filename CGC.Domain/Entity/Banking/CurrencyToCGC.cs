using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGC.Domain.Entity.Banking
{
    public class CurrencyToCGC:BaseEntity
    {
        public string Currency { get; set; }
        public double CurrencyToCgcs { get; set; }

    }
}
