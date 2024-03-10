using DAL.Domain.Advertisement;
using DAL.SeedData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class Db_Context : DbContext
    {
        public Db_Context()
        {
        }

        public Db_Context(DbContextOptions<Db_Context> options) : base(options)
        {

        }
        public DbSet<Advertisement> Advertisements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();

        }
    }
}
