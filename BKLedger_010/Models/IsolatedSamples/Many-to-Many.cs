using BKLedger_010.Models.Core_10;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BKLedger_010.Models.IsolatedSamples
{
    public class M2M_Student : IAuditable
    {
        public virtual ICollection<M2M_StudentCourse> StudentCourses { get; set; }

        [Key]
        [Column("StudentId")]
        public string Id { get; set; }
        [Column("StudentName")]
        public string Name { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Created { get; set; }
        public string ModifiedById { get; set; }
        [ForeignKey("ModifiedById")]
        public Core_ApplicationUser ModifiedBy { get; set; }
        public string CreatedById { get; set; }
        [ForeignKey("CreatedById")]
        public Core_ApplicationUser CreatedBy { get; set; }
    }
    public class M2M_Course : IAuditable
    {
        public virtual ICollection<M2M_StudentCourse> StudentCourses { get; set; }

        [Key]
        [Column("CourseId")]
        public string Id { get; set; }
        [Column("CourseName")]
        public string Name { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Created { get; set; }
        public string ModifiedById { get; set; }
        [ForeignKey("ModifiedById")]
        public Core_ApplicationUser ModifiedBy { get; set; }
        public string CreatedById { get; set; }
        [ForeignKey("CreatedById")]
        public Core_ApplicationUser CreatedBy { get; set; }

    }
    public class M2M_StudentCourse : IAuditable
    {
        public string StudentId { get; set; }
        public M2M_Student Student { get; set; }
        public string CourseId { get; set; }
        public M2M_Course Course { get; set; }


        [Column("StudentCourseId")]
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Created { get; set; }

        public string CreatedById { get; set; }
        [ForeignKey("CreatedById")]
        public Core_ApplicationUser CreatedBy { get; set; }

        public string ModifiedById { get; set; }
        [ForeignKey("ModifiedById")]
        public Core_ApplicationUser ModifiedBy { get; set; }
    }

}
