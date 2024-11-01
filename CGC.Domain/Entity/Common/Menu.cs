using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGC.Domain.Entity.Common
{
    public class Menu:BaseEntity
    {
        public int Uid { get; set; }
        public string Name { get; set; }
        public bool? IsParent { get; set; }
        public int ParentUid { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
    }
}
