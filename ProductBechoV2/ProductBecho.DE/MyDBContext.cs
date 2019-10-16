using Microsoft.EntityFrameworkCore;
using ProductBecho.DE.DataEntities;
using System;

namespace ProductBecho.DE
{
    public class ProductBechoContext:DbContext
    {
        public ProductBechoContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
