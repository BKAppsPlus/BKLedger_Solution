using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BKLedger_010.Models.IsolatedSamples
{
    public class M2M_Student
    {
        [Key]
        public string StudentID { get; set; }


        public virtual ICollection<M2M_StudentCourse> StudentCourses { get; set; }


        [Column("StudentName")]
        public string Name { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Created { get; set; }
        public string ModifiedBy { get; set; }
        public string CreatedBy { get; set; }
    }
    public class M2M_Course
    {
        [Key]
        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public virtual ICollection<M2M_StudentCourse> StudentCourses { get; set; }

    }
    public class M2M_StudentCourse
    {
        public string StudentId { get; set; }
        public M2M_Student Student { get; set; }
        public string CourseId { get; set; }
        public M2M_Course Course { get; set; }
    }

}
