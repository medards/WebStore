using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebStore.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WebStore.Models
{
    public class StoreContext : DbContext
    {
        public StoreContext() : base("StoreContext")
        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}