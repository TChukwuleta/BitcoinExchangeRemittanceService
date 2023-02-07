using BitcoinExchangeRemittanceService.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinExchangeRemittanceService.Core.Entities
{
    public class Account : AuditableEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public decimal OpeningBalance { get; set; }
        public decimal ClosingBalance { get; set; }
        public decimal AvailableBalance { get; set; }
        public decimal LedgerBalance { get; set; }
        public CurrencyType CurrencyType { get; set; }
        public string CurrencyTypeDescription { get { return CurrencyType.ToString(); } }
        public AccountStatus AccountStatus { get; set; }
        public string AccountStatusDescription { get { return AccountStatus.ToString(); } }
        public AccountType AccountType { get; set; }
        public string AccountTypeDescription { get { return AccountType.ToString(); } }
        public decimal MinimumFundingAmount { get; set; }
        public decimal MaximumFundingAmount { get; set; }
        public decimal MinimumWithdrawalAmount { get; set; }
        public decimal MaximumWithdrawalAmount { get; set; }
        public string UserId { get; set; }
    }
}
