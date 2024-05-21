namespace Toomeet_Pos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Orders",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        CustomerName = c.String(),
                        CustomerAddress = c.String(),
                        AmountGivenByCustomer = c.Double(nullable: false),
                        Change = c.Double(nullable: false),
                        CustomerDebt = c.Double(nullable: false),
                        Total = c.Double(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        Staff_Id = c.Long(nullable: false),
                        Store_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("public.Staffs", t => t.Staff_Id, cascadeDelete: true)
                .ForeignKey("public.Stores", t => t.Store_Id, cascadeDelete: true)
                .Index(t => t.Staff_Id)
                .Index(t => t.Store_Id);
            
            AddColumn("public.Products", "Order_Id", c => c.Long());
            CreateIndex("public.Products", "Order_Id");
            AddForeignKey("public.Products", "Order_Id", "public.Orders", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("public.Orders", "Store_Id", "public.Stores");
            DropForeignKey("public.Orders", "Staff_Id", "public.Staffs");
            DropForeignKey("public.Products", "Order_Id", "public.Orders");
            DropIndex("public.Orders", new[] { "Store_Id" });
            DropIndex("public.Orders", new[] { "Staff_Id" });
            DropIndex("public.Products", new[] { "Order_Id" });
            DropColumn("public.Products", "Order_Id");
            DropTable("public.Orders");
        }
    }
}
