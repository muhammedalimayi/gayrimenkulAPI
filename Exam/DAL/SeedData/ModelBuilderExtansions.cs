using DAL.Domain.Advertisement;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DAL.SeedData
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Advertisement>()
               .HasData(
                   new Advertisement
                   {
                       Id = 1,
                       Title = "Test1",
                       Price = 500000,
                       Status = Enums.Status.ForRent,
                       Fitment = Enums.Fitment.Exist
                   }
               );

            modelBuilder.Entity<Advertisement>()
           .HasData(
               new Advertisement
               {
                   Id = 2,
                   Title = "Test2",
                   Price = 300000,
                   Status = Enums.Status.ForSale,
                   Fitment = Enums.Fitment.Exist
               }
           );

            modelBuilder.Entity<Advertisement>()
          .HasData(
              new Advertisement
              {
                  Id = 3,
                  Title = "Test3",
                  Price = 20000,
                  Status = Enums.Status.ForSale,
                  Fitment = Enums.Fitment.NotExist
              }
          );

            modelBuilder.Entity<Advertisement>()
    .HasData(
        new Advertisement
        {
            Id = 4,
            Title = "Test4",
            Price = 120000,
            Status = Enums.Status.ForRent,
            Fitment = Enums.Fitment.NotExist
        }
    );
        }
    }

}
