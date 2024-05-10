namespace Toomeet_Pos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Brands",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Image = c.String(),
                        StoreId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("public.Stores", t => t.StoreId, cascadeDelete: true)
                .Index(t => new { t.StoreId, t.Name }, unique: true);
            
            CreateTable(
                "public.Products",
                c => new
                    {
                        SkuCode = c.String(nullable: false, maxLength: 128),
                        StoreId = c.Long(nullable: false),
                        Name = c.String(nullable: false),
                        BarCode = c.String(nullable: false, maxLength: 13),
                        UnitOfMeasure = c.String(),
                        Weight = c.Double(nullable: false),
                        RetailPrice = c.Double(nullable: false),
                        BulkPurchasePrice = c.Double(nullable: false),
                        PurchasePrice = c.Double(nullable: false),
                        Image = c.String(),
                        CostPrice = c.Double(nullable: false),
                        InventoryQuantity = c.Int(nullable: false),
                        CustomAttribute1 = c.String(),
                        CustomAttribute2 = c.String(),
                        CustomAttribute3 = c.String(),
                        Status = c.Int(nullable: false),
                        Description = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        Brand_Id = c.Long(),
                        Category_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.SkuCode, t.StoreId })
                .ForeignKey("public.Brands", t => t.Brand_Id)
                .ForeignKey("public.Categories", t => t.Category_Id, cascadeDelete: true)
                .ForeignKey("public.Stores", t => t.StoreId, cascadeDelete: true)
                .Index(t => t.StoreId)
                .Index(t => t.Brand_Id)
                .Index(t => t.Category_Id);
            
            CreateTable(
                "public.Categories",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        StoreId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("public.Stores", t => t.StoreId, cascadeDelete: true)
                .Index(t => new { t.StoreId, t.Name }, unique: true);
            
            CreateTable(
                "public.Stores",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Photo = c.Binary(),
                        Description = c.String(maxLength: 1000),
                        Address = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        Owner_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("public.Staffs", t => t.Owner_Id)
                .Index(t => t.Name, unique: true)
                .Index(t => t.Owner_Id);
            
            CreateTable(
                "public.Staffs",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Phone = c.String(nullable: false, maxLength: 11),
                        Description = c.String(maxLength: 200),
                        Photo = c.Binary(),
                        Email = c.String(maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 100),
                        Name = c.String(nullable: false, maxLength: 50),
                        Birthday = c.DateTime(nullable: false),
                        Address = c.String(),
                        Gender = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        WorkplaceId = c.Long(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        Role_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("public.Roles", t => t.Role_Id, cascadeDelete: true)
                .ForeignKey("public.Stores", t => t.WorkplaceId, cascadeDelete: true)
                .Index(t => t.Phone, unique: true)
                .Index(t => t.Email, unique: true)
                .Index(t => t.WorkplaceId)
                .Index(t => t.Role_Id);
            
            CreateTable(
                "public.Roles",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 200),
                        StoreId = c.Long(nullable: false),
                        Customer_Id = c.Long(nullable: false),
                        InvetoryInspection_Id = c.Long(nullable: false),
                        Manage_Id = c.Long(nullable: false),
                        Order_Id = c.Long(nullable: false),
                        Product_Id = c.Long(nullable: false),
                        Staff_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("public.RoleCustomers", t => t.Customer_Id, cascadeDelete: true)
                .ForeignKey("public.RoleInvetoryInspections", t => t.InvetoryInspection_Id, cascadeDelete: true)
                .ForeignKey("public.RoleManages", t => t.Manage_Id, cascadeDelete: true)
                .ForeignKey("public.RoleOrders", t => t.Order_Id, cascadeDelete: true)
                .ForeignKey("public.RoleProducts", t => t.Product_Id, cascadeDelete: true)
                .ForeignKey("public.RoleStaffs", t => t.Staff_Id, cascadeDelete: true)
                .ForeignKey("public.Stores", t => t.StoreId, cascadeDelete: true)
                .Index(t => new { t.StoreId, t.Name }, unique: true)
                .Index(t => t.Customer_Id)
                .Index(t => t.InvetoryInspection_Id)
                .Index(t => t.Manage_Id)
                .Index(t => t.Order_Id)
                .Index(t => t.Product_Id)
                .Index(t => t.Staff_Id);
            
            CreateTable(
                "public.RoleCustomers",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ViewAssignedCustomers = c.Boolean(nullable: false),
                        ViewAllCustomers = c.Boolean(nullable: false),
                        CreateCustomer = c.Boolean(nullable: false),
                        DeleteCustomer = c.Boolean(nullable: false),
                        EditCustomer = c.Boolean(nullable: false),
                        ExportCustomerFile = c.Boolean(nullable: false),
                        ImportCustomerFile = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "public.RoleInvetoryInspections",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ViewInVentoryCount = c.Boolean(nullable: false),
                        CreateInventoryCount = c.Boolean(nullable: false),
                        EditInventoryCount = c.Boolean(nullable: false),
                        BalanceInventory = c.Boolean(nullable: false),
                        DeleteInventoryCount = c.Boolean(nullable: false),
                        ExportInventoryCountFile = c.Boolean(nullable: false),
                        ImportInventoryCountFile = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "public.RoleManages",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        PermissionManagement = c.Boolean(nullable: false),
                        PaymentManagement = c.Boolean(nullable: false),
                        OrderProcessManagement = c.Boolean(nullable: false),
                        EditPrintingTemplate = c.Boolean(nullable: false),
                        ViewActiveLog = c.Boolean(nullable: false),
                        EditStoreInformation = c.Boolean(nullable: false),
                        GeneralConfiguration = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "public.RoleOrders",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ViewAssignedOrder = c.Boolean(nullable: false),
                        ViewAllOrder = c.Boolean(nullable: false),
                        CreateOrder = c.Boolean(nullable: false),
                        EditOrder = c.Boolean(nullable: false),
                        ApproveOrder = c.Boolean(nullable: false),
                        CancelOrder = c.Boolean(nullable: false),
                        ExportOrderFile = c.Boolean(nullable: false),
                        ImportOrderFile = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "public.RoleProducts",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        CreateProduct = c.Boolean(nullable: false),
                        ViewProduct = c.Boolean(nullable: false),
                        EditProduct = c.Boolean(nullable: false),
                        DeleteProduct = c.Boolean(nullable: false),
                        ExportProductFile = c.Boolean(nullable: false),
                        ImportProductFile = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "public.RoleStaffs",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ViewAllStaff = c.Boolean(nullable: false),
                        CreateStaff = c.Boolean(nullable: false),
                        EditStaff = c.Boolean(nullable: false),
                        RemoveStaff = c.Boolean(nullable: false),
                        ImportStaffFile = c.Boolean(nullable: false),
                        ExportStaffFile = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("public.Brands", "StoreId", "public.Stores");
            DropForeignKey("public.Products", "StoreId", "public.Stores");
            DropForeignKey("public.Products", "Category_Id", "public.Categories");
            DropForeignKey("public.Categories", "StoreId", "public.Stores");
            DropForeignKey("public.Staffs", "WorkplaceId", "public.Stores");
            DropForeignKey("public.Stores", "Owner_Id", "public.Staffs");
            DropForeignKey("public.Staffs", "Role_Id", "public.Roles");
            DropForeignKey("public.Roles", "StoreId", "public.Stores");
            DropForeignKey("public.Roles", "Staff_Id", "public.RoleStaffs");
            DropForeignKey("public.Roles", "Product_Id", "public.RoleProducts");
            DropForeignKey("public.Roles", "Order_Id", "public.RoleOrders");
            DropForeignKey("public.Roles", "Manage_Id", "public.RoleManages");
            DropForeignKey("public.Roles", "InvetoryInspection_Id", "public.RoleInvetoryInspections");
            DropForeignKey("public.Roles", "Customer_Id", "public.RoleCustomers");
            DropForeignKey("public.Products", "Brand_Id", "public.Brands");
            DropIndex("public.Roles", new[] { "Staff_Id" });
            DropIndex("public.Roles", new[] { "Product_Id" });
            DropIndex("public.Roles", new[] { "Order_Id" });
            DropIndex("public.Roles", new[] { "Manage_Id" });
            DropIndex("public.Roles", new[] { "InvetoryInspection_Id" });
            DropIndex("public.Roles", new[] { "Customer_Id" });
            DropIndex("public.Roles", new[] { "StoreId", "Name" });
            DropIndex("public.Staffs", new[] { "Role_Id" });
            DropIndex("public.Staffs", new[] { "WorkplaceId" });
            DropIndex("public.Staffs", new[] { "Email" });
            DropIndex("public.Staffs", new[] { "Phone" });
            DropIndex("public.Stores", new[] { "Owner_Id" });
            DropIndex("public.Stores", new[] { "Name" });
            DropIndex("public.Categories", new[] { "StoreId", "Name" });
            DropIndex("public.Products", new[] { "Category_Id" });
            DropIndex("public.Products", new[] { "Brand_Id" });
            DropIndex("public.Products", new[] { "StoreId" });
            DropIndex("public.Brands", new[] { "StoreId", "Name" });
            DropTable("public.RoleStaffs");
            DropTable("public.RoleProducts");
            DropTable("public.RoleOrders");
            DropTable("public.RoleManages");
            DropTable("public.RoleInvetoryInspections");
            DropTable("public.RoleCustomers");
            DropTable("public.Roles");
            DropTable("public.Staffs");
            DropTable("public.Stores");
            DropTable("public.Categories");
            DropTable("public.Products");
            DropTable("public.Brands");
        }
    }
}
