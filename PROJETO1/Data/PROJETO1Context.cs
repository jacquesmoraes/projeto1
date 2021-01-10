using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PROJETO1.Models;

namespace PROJETO1.Data
{
    public class PROJETO1Context : DbContext
    {
        public PROJETO1Context (DbContextOptions<PROJETO1Context> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecords { get; set; }
    }
}
