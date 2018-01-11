namespace testPreperation.Migrations.ApplicationDbMigration
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<testPreperation.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\ApplicationDbMigration";
        }

        protected override void Seed(testPreperation.Models.ApplicationDbContext context)
        {

        }
    }
}
