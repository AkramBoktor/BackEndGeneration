using LookUpTable.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LookUpTable.DAL
{
    public class CentralAdminDbContext:DbContext
    {
        public CentralAdminDbContext(DbContextOptions options):base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CentralAdministration>().HasData(
                new CentralAdministration { Name = "Test 1" },
                new CentralAdministration { Name = "Test 2" },
                new CentralAdministration { Name = "Test 3" }
                );
        }
        public DbSet<CentralAdministration> CentralAdministrations { get; set; }
    }
}
