using DomainLayer.Model;
using DomainLayer.Models;
using Identity.Assignments;
using Microsoft.AspNetCore.Identity;
 using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
 using Microsoft.EntityFrameworkCore;
using System;

namespace Identity.Auth
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }


       public DbSet<Department> Departments { get; set; }

        public DbSet<SubjectGpa> SubjectGpas { get; set; }

        public DbSet<Result> Results { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Grade> Grades { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Student> Students { get; set; }
        public DbSet<FileDetail> FileDetails { get; set; }
        public DbSet<Attendence> Attendences { get; set; }

    }



}
