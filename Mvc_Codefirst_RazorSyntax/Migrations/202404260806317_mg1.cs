namespace Mvc_Codefirst_RazorSyntax.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblEmployees",
                c => new
                    {
                        empid = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        city = c.String(),
                        salary = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.empid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblEmployees");
        }
    }
}
