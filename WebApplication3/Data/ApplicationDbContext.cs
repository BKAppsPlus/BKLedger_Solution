using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<conv1_OneClass> conv1_OneClass { get; set; }
        public DbSet<conv1_ManyStudent> conv1_ManyStudent { get; set; }

        public DbSet<conv2_OneClass> conv2_OneClass { get; set; }
        public DbSet<conv2_ManyStudent> conv2_ManyStudent { get; set; }
        public DbSet<conv3_OneClass> conv3_OneClass { get; set; }
        public DbSet<conv3_ManyStudent> conv3_ManyStudent { get; set; }
        public DbSet<conv4_OneClass> conv4_OneClass { get; set; }
        public DbSet<conv4_ManyStudent> conv4_ManyStudent { get; set; }

        public DbSet<conv0mm_ManyClass> conv0mm_ManyClass { get; set; }
        public DbSet<conv0mm_ManyStudent> conv0mm_ManyStudent { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<conv0mm_Class_X_Student>()
                .HasKey(cXs => new { cXs.PesonId, cXs.KelasIdee });
            builder.Entity<conv0mm_Class_X_Student>()
                .HasOne(cXs => cXs.Person)
                .WithMany(p => p.ClassEnrollments)
                .HasForeignKey(e => e.PesonId);
            builder.Entity<conv0mm_Class_X_Student>()
                .HasOne(cXs => cXs.Kelas)
                .WithMany(k => k.StudentEnrollments)
                .HasForeignKey(e => e.KelasIdee);

            base.OnModelCreating(builder);
        }


    }
}
