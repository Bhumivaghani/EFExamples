using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFExamples.Models
{
    public class EFContext : DbContext
    {
        public EFContext() : base("EFDbContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<EFContext, EFExamples.Migrations.Configuration>("EFDbContext"));
        }

        public DbSet<Student> students { get; set; }
        public DbSet<Standard> standards { get; set; }
    }
}