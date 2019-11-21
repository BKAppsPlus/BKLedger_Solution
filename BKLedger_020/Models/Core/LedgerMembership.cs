using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BKLedger_010.Models.Core
{
    public class Core_LedgerMembership : IAuditable
    {
        public string LedgerMemberId { get; set; }
        //[ForeignKey("LedgerMemberId")]
        public Core_ApplicationUser LedgerMember { get; set; }

        public string LedgerId { get; set; }
        [ForeignKey("LedgerId")]
        //[ForeignKey("LedgerId")]
        public Core_Ledger Ledger { get; set; }

        public string CreatedById { get; set; }
        public string ModifiedById { get; set; }

        [Column("LedgerMembershipId")]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [Column("LedgerMembershipName")]
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        [ForeignKey("CreatedById")]
        public Core_ApplicationUser CreatedBy { get; set; }
        [ForeignKey("ModifiedById")]
        public Core_ApplicationUser ModifiedBy { get; set; }
    }
}
