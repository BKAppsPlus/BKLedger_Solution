using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class conv2_OneClass
    {
        [Key]
        public int Class0Id { get; set; }
        public string ClassName { get; set; }
        public string Section { get; set; }

        public ICollection<conv2_ManyStudent> Students { get; set; }
    }
    public class conv2_ManyStudent
    {
        [Key]
        public int Student0Id { get; set; }
        public string StudentName { get; set; }

    }
}
