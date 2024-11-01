using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGC.Domain.Entity.Common
{
    public class User:BaseEntity
    {

        public string Uid { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? RefUid { get; set; }
        public string? ParentUid { get; set; }
        public string? GParentUid { get; set; }
        public double? UserType { get; set; }
        public double? CGC { get; set; } = 0.00;
        public int ? Role { get; set; }
        public string? Token { get; set; } 
    }
}
