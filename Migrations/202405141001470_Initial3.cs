namespace Toomeet_Pos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial3 : DbMigration
    {
        public override void Up()
        {
            DropIndex("public.Categories", new[] { "Code" });
        }
        
        public override void Down()
        {
            CreateIndex("public.Categories", "Code", unique: true);
        }
    }
}
