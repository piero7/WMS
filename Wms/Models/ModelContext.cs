using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Server.Models
{
    class ModelContext : DbContext
    {
        public ModelContext() : base("MyContext")
        {

        }

        #region organization
        public DbSet<Warehouse> WareHouseSet { get; set; }

        public DbSet<Employee> EnployeeSet { get; set; }

        public DbSet<WarehouseEmployeeRelationship> Warehouse_Employee_RelationshipSet { get; set; }
        #endregion


        #region order
        public DbSet<DeliveryOrder> Delivery_OrderSet { get; set; }

        public DbSet<EnterOrder> Enter_OrderSet { get; set; }
        #endregion


        #region system
        public DbSet<Administrator> AdministratorSet { get; set; }

        public DbSet<Role> RoleSet { get; set; }

        public DbSet<RoleAdministratorRelationship> Role_Administrator_RelationshipSet { get; set; }
        #endregion


    }
}
