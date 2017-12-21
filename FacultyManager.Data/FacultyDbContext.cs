using FacultyManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyManager.Data
{
    public class FacultyDbContext : DbContext
    {
        public FacultyDbContext() 
            : base ("FacultyManagerDb")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<FacultyDbContext, Configuration>("FacultyDbContext"));
            Database.SetInitializer(new FacultyDbInitializer());
        }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
