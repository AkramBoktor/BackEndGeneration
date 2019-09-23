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
        public DbSet<CentralAdministration> CentralAdministrations { get; set; }
    }
}
