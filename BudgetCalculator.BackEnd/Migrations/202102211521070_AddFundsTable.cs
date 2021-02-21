namespace BudgetCalculator.BackEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFundsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FundsAlterations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Double(nullable: false),
                        Type = c.String(),
                        Date = c.DateTime(),
                        Periodic = c.Boolean(nullable: false),
                        Comment = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FundsAlterations");
        }
    }
}
