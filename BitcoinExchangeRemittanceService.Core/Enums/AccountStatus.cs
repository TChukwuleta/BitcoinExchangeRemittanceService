using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinExchangeRemittanceService.Core.Enums
{
    public enum AccountStatus
    {
        Active = 1,
        Inactive = 2,
        Dormant, 
        Deactivated,
        Closed
    }
}
