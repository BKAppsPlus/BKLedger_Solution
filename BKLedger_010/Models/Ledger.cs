using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BKLedger_010.Models
{
    public class Ledger
    {
        public int Id
        { get; set; }
        public string Name
        { get; set; }
        public bool IsActive
        { get; set; }
        public string CreatedBy
        { get; set; }
        public DateTime Created
        { get; set; }
        public string ModifiedBy
        { get; set; }
        public DateTime Modified
        { get; set; }
    }
}
