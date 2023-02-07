using BitcoinExchangeRemittanceService.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinExchangeRemittanceService.Core.Entities
{
    public class SystemUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool Verified { get; set; }
        public string UserId { get; set; }
        public string PhoneNumber { get; set; }
        public Status Status { get; set; }
        public string StatusDescription { get { return Status.ToString(); } }
    }
}
