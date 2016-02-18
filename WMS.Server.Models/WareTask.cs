using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Server.Models
{
    class WareTask
    {
        [Key]
        public int id { get; set; }

        public DateTime? create_date { get; set; } = DateTime.Now;

        public DateTime? finsihe_date { get; set; }

        public int? employee_id { get; set; }

        [ForeignKey("employee_id")]
        public Employee Employee { get; set; }

        public int? warehouse_id { get; set; }

        [ForeignKey("warehouse_id")]
        public virtual Warehouse Warehouse { get; set; }

        public int? order_id { get; set; }

        [NotMapped]
        public WareOrder order { get; set; }

        public WareTaskType type { get; set; } = 0;

        public WareTaskStatus status { get; set; } = 0;

        public bool is_enable { get; set; } = true;

        public string remarks { get; set; }
    }


    public enum WareTaskType
    {
        Unknown = 0,
        Enter = 1,
        Delivery = 5,
    }

    public enum WareTaskStatus
    {
        Unknown = 0,
        Created = 1,
        Received = 5,
        Optioning = 10,
        Finished = 99,
        Cancelled = -1,
    }

}
