namespace MovieAppProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddGenre1 : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres( GrName) values( 'Action')");
            Sql("Insert into Genres( GrName) values( 'Romance')");
        }

        public override void Down()
        {
        }
    }
}
