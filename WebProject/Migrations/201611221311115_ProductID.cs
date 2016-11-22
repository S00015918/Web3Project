namespace WebProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductID : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderDetails", "ProductID", "dbo.Product");
            DropIndex("dbo.OrderDetails", new[] { "ProductID" });
            DropPrimaryKey("dbo.Product");
            AlterColumn("dbo.OrderDetails", "ProductID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Product", "ProductID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Product", "ProductID");
            CreateIndex("dbo.OrderDetails", "ProductID");
            AddForeignKey("dbo.OrderDetails", "ProductID", "dbo.Product", "ProductID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetails", "ProductID", "dbo.Product");
            DropIndex("dbo.OrderDetails", new[] { "ProductID" });
            DropPrimaryKey("dbo.Product");
            AlterColumn("dbo.Product", "ProductID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.OrderDetails", "ProductID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Product", "ProductID");
            CreateIndex("dbo.OrderDetails", "ProductID");
            AddForeignKey("dbo.OrderDetails", "ProductID", "dbo.Product", "ProductID", cascadeDelete: true);
        }
    }
}
