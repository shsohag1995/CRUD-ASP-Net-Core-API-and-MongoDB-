using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGC.Domain.Entity.Common
{
    public class ComplainRemark : BaseEntity
    {
        public string? ComplainId { get; set; }
        public string? Remarks { get; set;}
        public string? CreatedBy { get; set; }
    }
}
