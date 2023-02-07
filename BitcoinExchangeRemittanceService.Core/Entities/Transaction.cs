using BitcoinExchangeRemittanceService.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinExchangeRemittanceService.Core.Entities
{
    public class Transaction : AuditableEntity
    {
        public Guid TxnId { get; set; } = Guid.NewGuid();
        public string UserId { get; set; }
        public decimal Amount { get; set; }
        public TransactionType TransactionType { get; set; }
        public string TransactionTypeDescription { get { return TransactionType.ToString(); } }
        public string TransactionReference { get; set; }
        public TransactionStatus TransactionStatus { get; set; }
        public string TransactionStatusDescription { get { return TransactionStatus.ToString(); } }
    }
}
