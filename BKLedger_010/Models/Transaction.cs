using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BKLedger_MVC_023.Models
{
    public class Transaction
    {
        /// <summary>  
        /// Gets or sets the identifier.  
        /// </summary>  
        /// <value>The identifier.</value>  
        public int Id
        { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PayerID
        { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PayeeID
        { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public float Amount
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
