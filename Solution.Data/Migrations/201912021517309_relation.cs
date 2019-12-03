namespace Solution.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relation : DbMigration
    {
        public override void Up()
        {
           /* AddColumn("dbo.avis", "idEmplye", c => c.Int(nullable: false));
            CreateIndex("dbo.avis", "idEmplye");
            AddForeignKey("dbo.avis", "idEmplye", "dbo.employee", "id", cascadeDelete: true);*/
        }
        
        public override void Down()
        {
            /*
            DropForeignKey("dbo.avis", "idEmplye", "dbo.employee");
            DropIndex("dbo.avis", new[] { "idEmplye" });
            DropColumn("dbo.avis", "idEmplye");*/
        }
    }
}
