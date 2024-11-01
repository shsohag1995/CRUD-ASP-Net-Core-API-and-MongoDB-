using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGC.Domain.Entity.Banking
{
    public class Bank:BaseEntity
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Type { get; set; }// = "Global" or "Local";
        public int Title { get; set;}
        public string CountryId { get; set; }
        public string BankCommissionRate { get; set; }
    }
}
