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
            base.OnModelCreating(builder);
        }

    }
}
