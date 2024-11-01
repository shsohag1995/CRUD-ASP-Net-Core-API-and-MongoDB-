using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGC.Domain.Entity.Common
{
    public class ComplainStatus
    {
        public ComplainStatus(string name) {
         Name = name;
        }
        public string Name { get; set; }
    }
}
