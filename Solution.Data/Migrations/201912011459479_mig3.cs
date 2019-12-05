namespace Solution.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {   
            CreateTable(
                "dbo.conge",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        dateDebut = c.DateTime(storeType: "date"),
                        dateFin = c.DateTime(storeType: "date"),
                        typeConge = c.Int(),
                        valider = c.Boolean(storeType: "bit"),
                        employe_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.employee", t => t.employe_id)
                .Index(t => t.employe_id);
            
          
            
        }
        
        public override void Down()
        {
           
        }
    }
}
