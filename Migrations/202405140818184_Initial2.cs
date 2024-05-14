namespace Toomeet_Pos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("public.Categories", "Code", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("public.Categories", new[] { "Code" });
        }
    }
}
