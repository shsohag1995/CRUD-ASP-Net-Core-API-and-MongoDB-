using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGC.Domain.Entity.Common
{
    public class Complain:BaseEntity
    {
        public string ComplainerId { get; set; }
        public string ComplainToId { get; set; }
        public string Description { get; set; }
        public string ComplainStatus { get; set; }
        public bool Action { get; set; }
    }
}
