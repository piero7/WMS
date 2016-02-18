using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Server.Models
{
    class DeliveryOrderDetail
    {
        [Key]
        public int id { get; set; }

        public int? product_id { get; set; }

        [ForeignKey("product_id")]
        public virtual Product Product { get; set; }

        public int? deliver_order_id { get; set; }

        [ForeignKey("deliver_order_id")]
        public virtual DeliveryOrder DeliveryOrder { get; set; }

        public bool is_enable { get; set; }

        public double count { get; set; }

        public string remarks { get; set; }
    }
}
