using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AppConsole.Entities
{
    class CustomerDbContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder option)
        {
            option.UseSqlServer(@"server=(localdb)\projectsv13;Database=CustomersDb;"
                                + "Trusted_Connection=True;");
        }

    }
}
