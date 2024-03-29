﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BKLedger_010.Models.Core
{
    public class Core_Transaction : IAuditable
    {
        public string LedgerId { get; set; }
        public string PayerID { get; set; }
        public string PayeeID { get; set; }
        public float Amount { get; set; }
        public string CreatedById { get; set; }
        public string ModifiedById { get; set; }

        [ForeignKey("LedgerId")]
        public Core_Ledger Ledger { get; set; }
        [ForeignKey("PayerID")]
        public Core_ApplicationUser Payer { get; set; }
        [ForeignKey("PayeeID")]
        public Core_ApplicationUser Payee { get; set; }

        
        [Column("TransactionId")]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Created { get; set; }
        [ForeignKey("CreatedById")]
        public Core_ApplicationUser CreatedBy { get; set; }
        [ForeignKey("ModifiedById")]
        public Core_ApplicationUser ModifiedBy { get; set; }
    }
}
