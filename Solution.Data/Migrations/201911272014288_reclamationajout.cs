namespace Solution.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reclamationajout : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.reclamations", "EmployeeId", c => c.Int());
            CreateIndex("dbo.reclamations", "EmployeeId");
            AddForeignKey("dbo.reclamations", "EmployeeId", "employee", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
           
        }
    }
}
