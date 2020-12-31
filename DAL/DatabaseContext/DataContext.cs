
using DAL.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DatabaseContext
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Product> products { get; set; }
        public DbSet<Prize> Prizes { get; set; }

        public DbSet<CustomerReservation> customerReservations { get; set; }


    }
}
