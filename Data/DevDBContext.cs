using BikeStoreApi.Entities.Production;
using Microsoft.EntityFrameworkCore;
using System;


namespace BikeStoreApi.Data
{
    public class DevDBContext : DbContext
    {
        public DevDBContext(DbContextOptions<DevDBContext> options)
        : base(options)
        {
            /*
             The DbContextOptions instance carries configuration 
             information such as the connection string, database provider to use etc.
            */
        }

        // Each DbSet property in a DbContext class represents a table in the database

        public DbSet<Products> Products { get; set; }
        public DbSet<Brands> Brands { get; set; }
        public DbSet<Categories> Categories { get; set; }

    }
}
