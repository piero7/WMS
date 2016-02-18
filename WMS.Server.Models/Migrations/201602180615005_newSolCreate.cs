namespace WMS.Server.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class newSolCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administrators",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    login_name = c.String(unicode: false),
                    password = c.String(unicode: false),
                    last_login_date = c.DateTime(precision: 0),
                    real_name = c.String(unicode: false),
                    remarks = c.String(unicode: false),
                    is_enable = c.Boolean(nullable: false, defaultValue: true),
                    employee_id = c.Int(),
                    authority_string = c.String(unicode: false),
                })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Employees", t => t.employee_id)
                .Index(t => t.employee_id);

            CreateTable(
                "dbo.Employees",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    name = c.String(unicode: false),
                    photo_path = c.String(unicode: false),
                    birthday = c.DateTime(precision: 0),
                    age = c.Int(nullable: false, defaultValue: 0),
                    describe = c.String(unicode: false),
                    inner_number = c.String(unicode: false),
                    token = c.String(unicode: false),
                    phone_number = c.String(unicode: false),
                    is_enable = c.Boolean(nullable: false, defaultValue: true),
                    is_working = c.Boolean(nullable: false, defaultValue: false),
                    status = c.Int(nullable: false, defaultValue: 0),
                    remarks = c.String(unicode: false),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.Customers",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    name = c.String(unicode: false),
                    address = c.String(unicode: false),
                    inner_number = c.String(unicode: false),
                    remarks = c.String(unicode: false),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.DeliveryOrderDetails",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    product_id = c.Int(),
                    deliver_order_id = c.Int(),
                    is_enable = c.Boolean(nullable: false, defaultValue: true),
                    count = c.Double(nullable: false, defaultValue: 0),
                    remarks = c.String(unicode: false),
                })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.DeliveryOrders", t => t.deliver_order_id)
                .ForeignKey("dbo.Products", t => t.product_id)
                .Index(t => t.product_id)
                .Index(t => t.deliver_order_id);

            CreateTable(
                "dbo.DeliveryOrders",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    create_date = c.DateTime(precision: 0),
                    finish_daet = c.DateTime(precision: 0),
                    status = c.Int(nullable: false),
                    remarks = c.String(unicode: false),
                    is_enable = c.Boolean(nullable: false, defaultValue: true),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.Products",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    name = c.String(unicode: false),
                    inner_number = c.String(unicode: false),
                    remarks = c.String(unicode: false),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.EnterOrderDetails",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    product_id = c.Int(),
                    enter_order_id = c.Int(),
                    is_enable = c.Boolean(nullable: false, defaultValue: true),
                    count = c.Double(nullable: false, defaultValue: 0),
                    remarks = c.String(unicode: false),
                })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.EnterOrders", t => t.enter_order_id)
                .ForeignKey("dbo.Products", t => t.product_id)
                .Index(t => t.product_id)
                .Index(t => t.enter_order_id);

            CreateTable(
                "dbo.EnterOrders",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    create_date = c.DateTime(precision: 0),
                    finish_daet = c.DateTime(precision: 0),
                    status = c.Int(nullable: false, defaultValue: 0),
                    remarks = c.String(unicode: false),
                    is_enable = c.Boolean(nullable: false, defaultValue: true),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.RoleAdministratorRelationships",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    role_id = c.Int(),
                    administrator_id = c.Int(),
                    is_enanle = c.Boolean(nullable: false, defaultValue: true),
                    remarks = c.String(unicode: false),
                })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Administrators", t => t.administrator_id)
                .ForeignKey("dbo.Roles", t => t.role_id)
                .Index(t => t.role_id)
                .Index(t => t.administrator_id);

            CreateTable(
                "dbo.Roles",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    name = c.String(unicode: false),
                    inner_number = c.String(unicode: false),
                    is_enable = c.Boolean(nullable: false, defaultValue: true),
                    remarks = c.String(unicode: false),
                    authority_string = c.String(unicode: false),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.WareTasks",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    create_date = c.DateTime(precision: 0),
                    finsihe_date = c.DateTime(precision: 0),
                    employee_id = c.Int(),
                    warehouse_id = c.Int(),
                    order_id = c.Int(),
                    type = c.Int(nullable: false, defaultValue: 0),
                    status = c.Int(nullable: false, defaultValue: 0),
                    is_enable = c.Boolean(nullable: false, defaultValue: true),
                    remarks = c.String(unicode: false),
                })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Employees", t => t.employee_id)
                .ForeignKey("dbo.Warehouses", t => t.warehouse_id)
                .Index(t => t.employee_id)
                .Index(t => t.warehouse_id);

            CreateTable(
                "dbo.Warehouses",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    name = c.String(unicode: false),
                    address = c.String(unicode: false),
                    is_enabel = c.Boolean(nullable: false, defaultValue: true),
                    inner_number = c.String(unicode: false),
                    token = c.String(unicode: false),
                    last_login_date = c.DateTime(precision: 0),
                    remarks = c.String(unicode: false),
                    status = c.Int(nullable: false, defaultValue: 0),
                })
                .PrimaryKey(t => t.id);

            CreateTable(
                "dbo.WarehouseEmployeeRelationships",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    employee_id = c.Int(),
                    warehouse_id = c.Int(),
                    is_enable = c.Boolean(nullable: false, defaultValue: true),
                    cancel_date = c.DateTime(precision: 0),
                    remarks = c.String(unicode: false),
                })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Employees", t => t.employee_id)
                .ForeignKey("dbo.Warehouses", t => t.warehouse_id)
                .Index(t => t.employee_id)
                .Index(t => t.warehouse_id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.WarehouseEmployeeRelationships", "warehouse_id", "dbo.Warehouses");
            DropForeignKey("dbo.WarehouseEmployeeRelationships", "employee_id", "dbo.Employees");
            DropForeignKey("dbo.WareTasks", "warehouse_id", "dbo.Warehouses");
            DropForeignKey("dbo.WareTasks", "employee_id", "dbo.Employees");
            DropForeignKey("dbo.RoleAdministratorRelationships", "role_id", "dbo.Roles");
            DropForeignKey("dbo.RoleAdministratorRelationships", "administrator_id", "dbo.Administrators");
            DropForeignKey("dbo.EnterOrderDetails", "product_id", "dbo.Products");
            DropForeignKey("dbo.EnterOrderDetails", "enter_order_id", "dbo.EnterOrders");
            DropForeignKey("dbo.DeliveryOrderDetails", "product_id", "dbo.Products");
            DropForeignKey("dbo.DeliveryOrderDetails", "deliver_order_id", "dbo.DeliveryOrders");
            DropForeignKey("dbo.Administrators", "employee_id", "dbo.Employees");
            DropIndex("dbo.WarehouseEmployeeRelationships", new[] { "warehouse_id" });
            DropIndex("dbo.WarehouseEmployeeRelationships", new[] { "employee_id" });
            DropIndex("dbo.WareTasks", new[] { "warehouse_id" });
            DropIndex("dbo.WareTasks", new[] { "employee_id" });
            DropIndex("dbo.RoleAdministratorRelationships", new[] { "administrator_id" });
            DropIndex("dbo.RoleAdministratorRelationships", new[] { "role_id" });
            DropIndex("dbo.EnterOrderDetails", new[] { "enter_order_id" });
            DropIndex("dbo.EnterOrderDetails", new[] { "product_id" });
            DropIndex("dbo.DeliveryOrderDetails", new[] { "deliver_order_id" });
            DropIndex("dbo.DeliveryOrderDetails", new[] { "product_id" });
            DropIndex("dbo.Administrators", new[] { "employee_id" });
            DropTable("dbo.WarehouseEmployeeRelationships");
            DropTable("dbo.Warehouses");
            DropTable("dbo.WareTasks");
            DropTable("dbo.Roles");
            DropTable("dbo.RoleAdministratorRelationships");
            DropTable("dbo.EnterOrders");
            DropTable("dbo.EnterOrderDetails");
            DropTable("dbo.Products");
            DropTable("dbo.DeliveryOrders");
            DropTable("dbo.DeliveryOrderDetails");
            DropTable("dbo.Customers");
            DropTable("dbo.Employees");
            DropTable("dbo.Administrators");
        }
    }
}
