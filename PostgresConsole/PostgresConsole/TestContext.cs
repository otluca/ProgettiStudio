using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgresConsole
{
    internal class TestContext: DbContext
    {
        public DbSet<TableTest> TableTests { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                   => optionsBuilder
                        .UseNpgsql("Host=localhost;Username=postgres;Password=03481964;Database=TestDatabase");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TableTest>().HasKey("IdTableTest");

        }

    }
}
