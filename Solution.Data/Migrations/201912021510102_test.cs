namespace Solution.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {/*
            DropColumn("dbo.avis", "id_emp");*/
        }
        
        public override void Down()
        {/*
            AddColumn("dbo.avis", "id_emp", c => c.Int());*/
        }
    }
}
