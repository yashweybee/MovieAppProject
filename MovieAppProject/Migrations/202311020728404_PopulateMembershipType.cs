namespace MovieAppProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class PopulateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(Id,SignUpFee,DurationInMonth,DiscountRate) VALUES(1,0,0,0)");
            Sql("INSERT INTO MembershipTypes(Id,SignUpFee,DurationInMonth,DiscountRate) VALUES(2,10,1,21)");
            Sql("INSERT INTO MembershipTypes(Id,SignUpFee,DurationInMonth,DiscountRate) VALUES(3,11,4,32)");
        }

        public override void Down()
        {
        }
    }
}
