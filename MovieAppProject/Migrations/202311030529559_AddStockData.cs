namespace MovieAppProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddStockData : DbMigration
    {
        public override void Up()
        {
            Sql("update movies set Stock = 10 where Id = 1 ");
            Sql("update movies set Stock = 2 where Id = 2 ");
            Sql("update movies set Stock = 33 where Id = 3 ");
        }

        public override void Down()
        {
        }
    }
}
