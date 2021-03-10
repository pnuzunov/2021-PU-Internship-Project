namespace BudgetCalculator.BackEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPeriodicChecksTable : DbMigration
    {
        public override void Up()
        {            
            CreateTable(
                "dbo.PeriodicChecks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PeriodicChecks");
        }
    }
}
