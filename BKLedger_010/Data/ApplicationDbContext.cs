using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BKLedger_010.Models;
using BKLedger_010.Models.IsolatedSamples;
using BKLedger_010.Models.Test;
using BKLedger_010.Models.Core;

namespace BKLedger_010.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        #region Core

        public DbSet<Core_Transaction> Core_Transactions { get; set; }
        public DbSet<Core_Ledger> Core_Ledgers { get; set; }
        //public DbSet<Core_LedgerMembership> Core_LedgerMemberships { get; set; }
        
        #endregion

        #region Test

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
        public DbSet<CourseAssignment> CourseAssignments { get; set; }
        public DbSet<Person> People { get; set; }
        
        #endregion

        #region M2m O2M MODEL
        public DbSet<O2M_Company> O2M_Company { get; set; }
        public DbSet<O2M_EmployeeOfCompany> O2M_EmployeeOfCompany { get; set; }


        public DbSet<M2M_Course> M2M_Course { get; set; }
        public DbSet<M2M_Student> M2M_Student { get; set; }
        public DbSet<M2M_StudentCourse> M2M_StudentCourse { get; set; }
        #endregion


        protected override void OnModelCreating(ModelBuilder builder)
        {
            #region Core Model

            //Many to Many between 
            //builder.Entity<Core_LedgerMembership>()
            //    .HasKey(lm => new { lm.Id });
            //builder.Entity<Core_LedgerMembership>()
            //    .HasOne(lm => lm.LedgerUser)
            //    .WithMany(lu => lu.LedgerMembers)
            //    .HasForeignKey(lm => lm.LedgerUserId);
            //builder.Entity<Core_LedgerMembership>()
            //    .HasOne(lm => lm.Ledger)
            //    .WithMany(l => l.LedgerMemberships)
            //    .HasForeignKey(lm => lm.LedgerId);
            #endregion

            #region M2m O2M MODEL
            ////One to Many:
            //builder.Entity<O2M_Company>()
            //    .HasMany(c => c.Employees)
            //    .WithOne(e => e.Company)
            //    .IsRequired();
            ////or:
            ////builder.Entity<Employee>()
            ////    .HasOne(e => e.Company)
            ////    .WithMany(c => c.Employees);

            // Many to Many Srudents' Courses

            builder.Entity<M2M_StudentCourse>()
                .HasKey(sc => new { sc.Id });
            builder.Entity<M2M_StudentCourse>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.StudentId);
            builder.Entity<M2M_StudentCourse>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.StudentCourses)
                .HasForeignKey(sc => sc.CourseId);
            #endregion
            
            #region TEST MODEL
            //Teacher One to many Courses:


            builder.Entity<Course>().ToTable("Test_Course");
            builder.Entity<Enrollment>().ToTable("Test_Enrollment");
            builder.Entity<Student>().ToTable("Test_Student");
            builder.Entity<Department>().ToTable("Test_Department");
            builder.Entity<Instructor>().ToTable("Test_Instructor");
            builder.Entity<OfficeAssignment>().ToTable("Test_OfficeAssignment");
            builder.Entity<CourseAssignment>().ToTable("Test_CourseAssignment");
            builder.Entity<Person>().ToTable("Test_Person");

            builder.Entity<CourseAssignment>()
                .HasKey(c => new { c.CourseID, c.InstructorID });

            builder.Entity<Instructor>()
                .HasMany(t => t.CourseAssignments)
                .WithOne(c => c.Instructor);
            //Students Many to many Courses:
            builder.Entity<Enrollment>()
                .HasKey(e => new { e.StudentId, e.CourseId });
            builder.Entity<Enrollment>()
                .HasOne(e => e.Student)
                .WithMany(s => s.Enrollments)
                .HasForeignKey(ce => ce.StudentId);
            builder.Entity<Enrollment>()
                .HasOne(e => e.Course)
                .WithMany(c => c.Enrollments)
                .HasForeignKey(es => es.CourseId);
            #endregion

            base.OnModelCreating(builder);
        }
    }
}
