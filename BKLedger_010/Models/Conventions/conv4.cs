using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BKLedger_010.Models.Conventions
{
    public class conv4_OneClass
    {
        [Key]
        public int ClassIdee { get; set; }
        public string ClassName { get; set; }
        public string Section { get; set; }

        public ICollection<conv4_ManyStudent> AllStudentsInThisClass { get; set; }
    }
    public class conv4_ManyStudent
    {
        [Key]
        public int DudeIdee { get; set; }
        public string StudentName { get; set; }

        public int KelaslassIdee { get; set; }
        public conv4_OneClass ClassOfTheStudent { get; set; }
    }



}
