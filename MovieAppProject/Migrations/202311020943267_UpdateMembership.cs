namespace MovieAppProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class UpdateMembership : DbMigration
    {
        public override void Up()
        {
            Sql("update MembershipTypes set Name = 'Monthly' where Id = 1");
            Sql("update MembershipTypes set Name = 'Yearly' where Id = 2");
            Sql("update MembershipTypes set Name = 'daily1' where Id = 3");


        }

        public override void Down()
        {
        }
    }
}
