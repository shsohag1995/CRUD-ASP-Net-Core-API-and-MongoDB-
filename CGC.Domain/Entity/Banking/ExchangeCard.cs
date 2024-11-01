using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGC.Domain.Entity.Banking
{
    public class ExchangeCard :BaseEntity
    {
        public string? FromCurrency { get; set; } = string.Empty;
        public string? ToCurrency { get; set; } = string.Empty;
        public string? FromBank { get; set; }
        public string? ToBank { get; set;} = string.Empty;
        
    }
}
