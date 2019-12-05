namespace Solution.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Solution.Data.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            // SetSqlGenerator("MySql.Data.MySqlClient", new MySql.Data.Entity.MySqlMigrationSqlGenerator());
            SetSqlGenerator("MySql.Data.MySqlClient", new myMigrationSQLGenerator());
        }

        protected override void Seed(Solution.Data.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
