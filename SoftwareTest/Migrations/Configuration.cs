namespace SoftwareTest.Migrations
{
    using SoftwareTest.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SoftwareTest.Contexts.AppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SoftwareTest.Contexts.AppContext context)
        {
            context.Couriers.AddOrUpdate(x => x.id,
                new Courier() { id = 1, name = "Cargo4You", maxWeight = 20, minWeight = 0, minSize = 0, maxSize = 2000 },
                new Courier() { id = 2, name = "ShipFaster", maxWeight = 30, minWeight = 10, minSize = 0, maxSize = 1700 },
                new Courier() { id = 3, name = "MaltaShip", maxWeight = 150, minWeight = 10, minSize = 500, maxSize = 6000}

                );
        }
    }
}
