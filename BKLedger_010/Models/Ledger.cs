using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BKLedger_010.Models
{
    public class Core_ApplicationUser : IdentityUser
    {
        public ICollection<Core_LedgerMember> LedgerMembers { get; set; }
    }
    public class Core_LedgerMember
    {
        public string LedgerUserId { get; set; }
        public Core_ApplicationUser LedgerUser { get; set; }
        public int LedgerId { get; set; }
        public Core_Ledger Ledger { get; set; }
    }

    public class Core_Ledger
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Core_LedgerMember> LedgerMembers { get; set; }

        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime Modified { get; set; }
    }
}
