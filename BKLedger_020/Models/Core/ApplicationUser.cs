using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BKLedger_010.Models.Core
{
    public class Core_ApplicationUser : IdentityUser
    {
        //[InverseProperty("LedgerMember")]
        public ICollection<Core_LedgerMembership> AssignedLedgers { get; set; }

        [InverseProperty("Owner")]
        public ICollection<Core_Ledger> OwnedLedgers { get; set; }

        [InverseProperty("Payee")]
        public ICollection<Core_Transaction> PayeeTransactions { get; set; }
        [InverseProperty("Payer")]
        public ICollection<Core_Transaction> PayerTransactions { get; set; }

        //public ICollection<Core_Transaction> GetAllTransactions()
        //{
        //    ICollection<Core_Transaction> allTransactions = PayerTransactions.Concat(PayeeTransactions).ToList();
        //    return allTransactions;
        //    //throw new NotImplementedException();
        //}
        //public ICollection<Core_Transaction> GetLedgerTransactions(string ledgerId)
        //{
        //    //Core_Ledger l = new Core_Ledger(ledgerId);
        //    //this.Transactions(l);
        //    throw new NotImplementedException();
        //}
        //public ICollection<Core_Transaction> GetLedgerTransactions(Core_Ledger ledger)
        //{
        //    throw new NotImplementedException();
        //}

    }

}
