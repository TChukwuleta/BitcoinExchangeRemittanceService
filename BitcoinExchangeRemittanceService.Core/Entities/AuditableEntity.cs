﻿using BitcoinExchangeRemittanceService.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinExchangeRemittanceService.Core.Entities
{
    public class AuditableEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public Status Status { get; set; }
        public string StatusDescription { get { return Status.ToString(); } }
    }
}
