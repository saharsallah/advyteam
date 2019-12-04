namespace Solution.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class haya : DbMigration
    {
        public override void Up()
        {
           /* MoveTable(name: "advyteam.attestationtest", newSchema: "dbo");
            MoveTable(name: "advyteam.autotest", newSchema: "dbo");
            MoveTable(name: "advyteam.note", newSchema: "dbo");
            MoveTable(name: "advyteam.questiontest", newSchema: "dbo");
            CreateTable(
                "dbo.avis",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        avis1 = c.String(unicode: false),
                        avis2 = c.String(unicode: false),
                        avis3 = c.String(unicode: false),
                        avis4 = c.String(unicode: false),
                        avis5 = c.String(unicode: false),
                        dateAvis = c.DateTime(precision: 0),
                        etat = c.Boolean(),
                        rep1 = c.String(unicode: false),
                        rep10 = c.String(unicode: false),
                        rep11 = c.String(unicode: false),
                        rep12 = c.String(unicode: false),
                        rep13 = c.String(unicode: false),
                        rep14 = c.String(unicode: false),
                        rep15 = c.String(unicode: false),
                        rep2 = c.String(unicode: false),
                        rep3 = c.String(unicode: false),
                        rep4 = c.String(unicode: false),
                        rep5 = c.String(unicode: false),
                        rep6 = c.String(unicode: false),
                        rep7 = c.String(unicode: false),
                        rep8 = c.String(unicode: false),
                        rep9 = c.String(unicode: false),
                        idEmplye = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.employee", t => t.idEmplye, cascadeDelete: true)
                .Index(t => t.idEmplye);
            */
        }
        
        public override void Down()
        {
           /* DropForeignKey("dbo.avis", "idEmplye", "dbo.employee");
            DropIndex("dbo.avis", new[] { "idEmplye" });
            DropTable("dbo.avis");
            MoveTable(name: "dbo.questiontest", newSchema: "advyteam");
            MoveTable(name: "dbo.note", newSchema: "advyteam");
            MoveTable(name: "dbo.autotest", newSchema: "advyteam");
            MoveTable(name: "dbo.attestationtest", newSchema: "advyteam"); */
        }
    }
}
