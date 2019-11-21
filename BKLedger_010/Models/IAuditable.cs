using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BKLedger_010.Models
{
    public interface IAuditable
    {
        string Id { get; set; }
        string Name { get; set; }
        DateTime Modified { get; set; }
        DateTime Created { get; set; }

        Core_ApplicationUser ModifiedBy { get; set; }

        Core_ApplicationUser CreatedBy { get; set; }

    }
    //[Key]
    //[Column("<TABLE>Id")]
    //public string Id { get; set; } = Guid.NewGuid().ToString();
    //[Column("<TABLE>Name")]
    //public string Name { get; set; }
    //public DateTime Modified { get; set; }
    //public DateTime Created { get; set; }
    //public string ModifiedById { get; set; }
    //[ForeignKey("ModifiedById")]
    //public Core_ApplicationUser ModifiedBy { get; set; }
    //public string CreatedById { get; set; }
    //[ForeignKey("CreatedById")]
    //public Core_ApplicationUser CreatedBy { get; set; }
}
