using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BKLedger_010.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<LedgerMember> LedgerMembers { get; set; }
    }
    public class LedgerMember
    {
        public string UserId { get; set; }
        
        public ApplicationUser LedgerUser { get; set; }
        public int LedgerId { get; set; }
        public Ledger Ledger { get; set; }
    }

    public class Ledger
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public virtual ICollection<LedgerMember> LedgerMembers { get; set; }

        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime Modified { get; set; }
    }
}
