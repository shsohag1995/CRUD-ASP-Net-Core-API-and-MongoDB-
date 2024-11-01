using CGC.Domain.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGC.Infrastructure.Data
{
    public class Type
    {
        private static readonly List<UserType> userTypes = new List<UserType>
        {
             new  UserType(1,"Admin"),
             new  UserType(2,"Partner"),
              new UserType(1,"Client"),

        };
        private static readonly List<ComplainStatus> complainStatus = new List<ComplainStatus>
        { 
            //new ComplainStatus("Pending"),
            new ComplainStatus("Solved"),
            new ComplainStatus("Failed"),
            new ComplainStatus("Closed")

        };

    }
}
