using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class conv3_OneClass
    {
        [Key]
        public int ClassIdee { get; set; }
        public string ClassName { get; set; }
        public string Section { get; set; }

        public ICollection<conv3_ManyStudent> StudentsInThisClass { get; set; }
    }
    public class conv3_ManyStudent
    {
        [Key]
        public int DudeIdee { get; set; }
        public string StudentName { get; set; }

        public conv3_OneClass ClassOfTheStudent { get; set; }
    }
}
