﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BKLedger_010.Models
{
    public class Core_ApplicationUser : IdentityUser
    {
        [InverseProperty("LedgerMember")]
        public ICollection<Core_LedgerMembership> MemberLedgers { get; set; }

        [InverseProperty("Owner")]
        public ICollection<Core_Ledger> OwnedLedgers { get; set; }

        [InverseProperty("Payee")]
        public ICollection<Core_Transaction> PayeeTransactions { get; set; }
        [InverseProperty("Payer")]
        public ICollection<Core_Transaction> PayerTransactions { get; set; }

        //[InverseProperty("CreatedBy")]
        //public ICollection<Core_Transaction> AuthoredTransactions { get; set; }
        //[InverseProperty("ModifiedBy")]
        //public ICollection<Core_Transaction> EditedTransactions { get; set; }

        //[InverseProperty("CreatedBy")]
        //public ICollection<Core_LedgerMembership> AuthoredLedgerMemberships { get; set; }
        //[InverseProperty("ModifiedBy")]
        //public ICollection<Core_LedgerMembership> EditedLedgerMemberships { get; set; }

        //[InverseProperty("CreatedBy")]
        //public ICollection<Core_Ledger> AuthoredLedgers { get; set; }

        //[InverseProperty("ModifiedBy")]
        //public ICollection<Core_Ledger> EditedLedgers { get; set; }

        public ICollection<Core_Transaction> GetAllTransactions()
        {
            ICollection<Core_Transaction> allTransactions = PayerTransactions.Concat(PayeeTransactions).ToList();
            return allTransactions;
            //throw new NotImplementedException();
        }
        public ICollection<Core_Transaction> GetLedgerTransactions(string ledgerId)
        {
            //Core_Ledger l = new Core_Ledger(ledgerId);
            //this.Transactions(l);
            throw new NotImplementedException();
        }
        public ICollection<Core_Transaction> GetLedgerTransactions(Core_Ledger ledger)
        {
            throw new NotImplementedException();
        }

    }

}