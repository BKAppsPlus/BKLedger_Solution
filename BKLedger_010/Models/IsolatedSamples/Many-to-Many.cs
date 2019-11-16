using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BKLedger_010.Models.IsolatedSamples
{
    public class M2M_Student
    {
        [Key]
        public int StudentID { get; set; }
        public string StudentName { get; set; }

        public virtual ICollection<M2M_StudentCourse> StudentCourses { get; set; }
    }
    public class M2M_Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public virtual ICollection<M2M_StudentCourse> StudentCourses { get; set; }

    }
    public class M2M_StudentCourse
    {
        public int StudentId { get; set; }
        public M2M_Student Student { get; set; }
        public int CourseId { get; set; }
        public M2M_Course Course { get; set; }
    }

}
