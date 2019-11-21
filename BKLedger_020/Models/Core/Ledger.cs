using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BKLedger_010.Models.Core
{
    public class Core_Ledger : IAuditable
    {
        public Core_ApplicationUser Owner { get; set; }
        public string CreatedById { get; set; }
        public string ModifiedById { get; set; }
        //[InverseProperty("Ledger")] 
        public virtual ICollection<Core_LedgerMembership> LedgerMembers { get; set; }
        public virtual ICollection<Core_Transaction> Transactions { get; set; }

        [Column("LedgerId")]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [Column("LedgerName")]
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        [ForeignKey("CreatedById")]
        public Core_ApplicationUser CreatedBy { get; set; }
        [ForeignKey("ModifiedById")]
        public Core_ApplicationUser ModifiedBy { get; set; }
    }
}
