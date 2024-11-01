using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGC.Domain.Entity.Banking
{
    public class Currency:BaseEntity
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public double ToCGC { get; set; }
    }
}
