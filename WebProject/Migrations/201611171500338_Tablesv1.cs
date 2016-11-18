namespace WebProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tablesv1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customer", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customer", "Password");
        }
    }
}
