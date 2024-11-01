using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGC.Domain.Entity.Common
{
    public class MenuPermission:BaseEntity
    {
        public string RoleId { get; set; }
        public string MenuId { get; set; }
        public bool IsView { get; set; }
        public bool IsInsert { get; set; }
        public bool IsUpdate { get; set; }
        public bool IsSoftDelete { get; set; } 
        public bool IsDelete { get; set; }
    }
}
