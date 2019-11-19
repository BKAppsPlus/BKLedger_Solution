using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BKLedger_010.Models
{
    public interface IAuditable
    {
        //string Id { get; set; }
        string Name { get; set; }
        DateTime Modified { get; set; }
        DateTime Created { get; set; }
        string ModifiedBy { get; set; }
        string CreatedBy { get; set; }

    }

    //[Column("StudentName")]
    //public string Name { get; set; }
    //public DateTime Modified { get; set; }
    //public DateTime Created { get; set; }
    //public string ModifiedBy { get; set; }
    //public string CreatedBy { get; set; }
}
