using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecordEmployeeData.Models
{
    public class RecordEmployeeDataContext : DbContext
    {
        public RecordEmployeeDataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<EmployeeData> Employees { get; set; }
    }
}
