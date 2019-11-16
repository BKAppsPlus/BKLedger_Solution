using System;
using System.ComponentModel.DataAnnotations;

namespace BKLedger_010.Models.Test.SchoolViewModels
{
    public class EnrollmentDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime? EnrollmentDate { get; set; }

        public int StudentCount { get; set; }
    }
}