using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BKLedger_010.Models;

namespace BKLedger_010.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Core_Transaction> Core_Transactions { get; set; }
        public DbSet<Core_Ledger> Core_Ledgers { get; set; }
        public DbSet<Core_LedgerMember> Core_LedgerMember { get; set; }


        public DbSet<BKLedger_010.Models.Test.Course> Courses { get; set; }
        public DbSet<BKLedger_010.Models.Test.Enrollment> Enrollments { get; set; }
        public DbSet<BKLedger_010.Models.Test.Student> Students { get; set; }
        public DbSet<BKLedger_010.Models.Test.Department> Departments { get; set; }
        public DbSet<BKLedger_010.Models.Test.Instructor> Instructors { get; set; }
        public DbSet<BKLedger_010.Models.Test.OfficeAssignment> OfficeAssignments { get; set; }
        public DbSet<BKLedger_010.Models.Test.CourseAssignment> CourseAssignments { get; set; }
        public DbSet<BKLedger_010.Models.Test.Person> People { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Core_LedgerMember>()
                .HasKey(lm => new { lm.LedgerUserId, lm.LedgerId });
            builder.Entity<Core_LedgerMember>()
                .HasOne(lm => lm.LedgerUser)
                .WithMany(lu => lu.LedgerMembers)
                .HasForeignKey(lm => lm.LedgerUserId);
            builder.Entity<Core_LedgerMember>()
                .HasOne(lm => lm.Ledger)
                .WithMany(l => l.LedgerMembers)
                .HasForeignKey(lm => lm.LedgerId);


            ////One to Many:
            //builder.Entity<O2M_Company>()
            //    .HasMany(c => c.Employees)
            //    .WithOne(e => e.Company)
            //    .IsRequired();
            ////or:
            ////builder.Entity<Employee>()
            ////    .HasOne(e => e.Company)
            ////    .WithMany(c => c.Employees);

            ////Many to Many:

            //builder.Entity<M2M_StudentCourse>()
            //    .HasKey(sc => new { sc.CourseId, sc.StudentId });
            //builder.Entity<M2M_StudentCourse>()
            //    .HasOne(sc => sc.Student)
            //    .WithMany(s => s.StudentCourses)
            //    .HasForeignKey(sc => sc.StudentId);
            //builder.Entity<M2M_StudentCourse>()
            //    .HasOne(sc => sc.Course)
            //    .WithMany(c => c.StudentCourses)
            //    .HasForeignKey(sc => sc.CourseId);

            ////TEST MODEL:
            ////Teacher One to many Courses:
            //builder.Entity<Test_Teacher>()
            //    .HasMany(t => t.CourseAssignments)
            //    .WithOne(c => c.Teacher);
            ////Students Many to many Courses:
            //builder.Entity<Test_Enrolment>()
            //    .HasKey(e => new {e.StudentId, e.CourseId });
            //builder.Entity<Test_Enrolment>()
            //    .HasOne(e => e.Student)
            //    .WithMany(s => s.CoursesEnrolled)
            //    .HasForeignKey(ce => ce.StudentId);
            //builder.Entity<Test_Enrolment>()
            //    .HasOne(e => e.Course)
            //    .WithMany(c => c.EnrolledStudents)
            //    .HasForeignKey(es => es.CourseId);

            builder.Entity<BKLedger_010.Models.Test.Course>().ToTable("Test_Course");
            builder.Entity<BKLedger_010.Models.Test.Enrollment>().ToTable("Test_Enrollment");
            builder.Entity<BKLedger_010.Models.Test.Student>().ToTable("Test_Student");
            builder.Entity<BKLedger_010.Models.Test.Department>().ToTable("Test_Department");
            builder.Entity<BKLedger_010.Models.Test.Instructor>().ToTable("Test_Instructor");
            builder.Entity<BKLedger_010.Models.Test.OfficeAssignment>().ToTable("Test_OfficeAssignment");
            builder.Entity<BKLedger_010.Models.Test.CourseAssignment>().ToTable("Test_CourseAssignment");
            builder.Entity<BKLedger_010.Models.Test.Person>().ToTable("Test_Person");

            builder.Entity<BKLedger_010.Models.Test.CourseAssignment>()
                .HasKey(c => new { c.CourseID, c.InstructorID });
            base.OnModelCreating(builder);
        }

        

        public DbSet<BKLedger_010.Models.IsolatedSamples.O2M_Company> O2M_Company { get; set; }
        public DbSet<BKLedger_010.Models.IsolatedSamples.O2M_EmployeeOfCompany> O2M_EmployeeOfCompany { get; set; }



    }
}
