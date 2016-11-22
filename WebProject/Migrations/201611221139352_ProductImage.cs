namespace WebProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductImage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "ImageFile", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Product", "ImageFile");
        }
    }
}
