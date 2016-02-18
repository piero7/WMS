using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Server.Models
{
    class WarehouseEmployeeRelationship
    {
        public int id { get; set; }

        public int? employee_id { get; set; }

        [ForeignKey("employee_id ")]
        public virtual Employee Employee { get; set; }

        public int? warehouse_id { get; set; }

        [ForeignKey("warehouse_id")]
        public virtual Warehouse Warehouse { get; set; }

        public bool is_enable { get; set; } = true;

        public DateTime? cancel_date { get; set; }

        public string remarks { get; set; }
    }
}
