namespace WebStore.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebStore.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebStore.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebStore.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Products.AddOrUpdate(p => p.Name,
                new Product
                {
                    Name = "Book",
                    Category = "Books",
                    Price = "15.6",
                    Description = "Bla bla ful texta bla",
                    Image = "Book.jpeg",
                },
                new Product
                {
                    Name = "Shovel",
                    Category = "Tools",
                    Price = "30.2",
                    Description = "Text about shovels.",
                    Image = "Shovel.jpeg",
                }
                );
        }
    }
}
