namespace WMS.Server.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class addDefaultValue : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "is_enable", c => c.Boolean(nullable: false, defaultValue: true));
            AddColumn("dbo.DeliveryOrders", "finish_date", c => c.DateTime(precision: 0));
            AddColumn("dbo.Products", "is_enable", c => c.Boolean(nullable: false, defaultValue: true));
            AddColumn("dbo.EnterOrders", "finish_date", c => c.DateTime(precision: 0));
            AddColumn("dbo.RoleAdministratorRelationships", "is_enable", c => c.Boolean(nullable: false));
            AlterColumn("dbo.WarehouseEmployeeRelationships", "is_enable", c => c.Boolean(nullable: false));
            DropColumn("dbo.DeliveryOrders", "finish_daet");
            DropColumn("dbo.EnterOrders", "finish_daet");
            DropColumn("dbo.RoleAdministratorRelationships", "is_enanle");
        }

        public override void Down()
        {
            AddColumn("dbo.RoleAdministratorRelationships", "is_enanle", c => c.Boolean(nullable: false, defaultValue: true));
            AddColumn("dbo.EnterOrders", "finish_daet", c => c.DateTime(precision: 0));
            AddColumn("dbo.DeliveryOrders", "finish_daet", c => c.DateTime(precision: 0));
            AlterColumn("dbo.WarehouseEmployeeRelationships", "is_enable", c => c.Boolean(nullable: false, defaultValue: true));
            DropColumn("dbo.RoleAdministratorRelationships", "is_enable");
            DropColumn("dbo.EnterOrders", "finish_date");
            DropColumn("dbo.Products", "is_enable");
            DropColumn("dbo.DeliveryOrders", "finish_date");
            DropColumn("dbo.Customers", "is_enable");
        }
    }
}
