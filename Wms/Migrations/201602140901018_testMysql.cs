namespace Wms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class testMysql : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Warehouses",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    name = c.String(unicode: false),
                    address = c.String(unicode: false),
                    is_enabel = c.Boolean(nullable: false, defaultValue: true),
                    inner_number = c.String(unicode: false),
                    remarks = c.String(unicode: false),
                })
                .PrimaryKey(t => t.id);

        }

        public override void Down()
        {
            DropTable("dbo.Warehouses");
        }
    }
}
