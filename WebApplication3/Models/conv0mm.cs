using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class conv0mm_ManyClass
    {
        [Key]
        public int ClassIdee { get; set; }
        public string ClassName { get; set; }
        public string Section { get; set; }
        public conv0mm_ManyStudent Mobser { get; set; }
        public conv0mm_ManyStudent TopDog { get; set; }
        public virtual ICollection<conv0mm_Class_X_Student> StudentEnrollments { get; set; }
    }
    public class conv0mm_ManyStudent
    {
        [Key]
        public int DudeIdee { get; set; }
        public string StudentName { get; set; }

        public virtual ICollection<conv0mm_Class_X_Student> ClassEnrollments { get; set; }
    }
    public class conv0mm_Class_X_Student
    {
        public int PesonId { get; set; }
        public conv0mm_ManyStudent Person { get; set; }
        public int KelasIdee { get; set; }
        public conv0mm_ManyClass Kelas { get; set; }
    }

}
