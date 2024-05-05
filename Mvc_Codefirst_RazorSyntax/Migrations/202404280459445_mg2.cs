namespace Mvc_Codefirst_RazorSyntax.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblcountries",
                c => new
                    {
                        cid = c.Int(nullable: false, identity: true),
                        cname = c.String(),
                    })
                .PrimaryKey(t => t.cid);
            
            CreateTable(
                "dbo.tblstates",
                c => new
                    {
                        sid = c.Int(nullable: false, identity: true),
                        cid = c.Int(nullable: false),
                        sname = c.String(),
                    })
                .PrimaryKey(t => t.sid);
            
            AddColumn("dbo.tblEmployees", "country", c => c.Int(nullable: false));
            AddColumn("dbo.tblEmployees", "state", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblEmployees", "state");
            DropColumn("dbo.tblEmployees", "country");
            DropTable("dbo.tblstates");
            DropTable("dbo.tblcountries");
        }
    }
}
