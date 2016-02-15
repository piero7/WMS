using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wms.Models
{
    class DeliveryOrder
    {
        [Key]
        public int id { get; set; }


        public DateTime create_date { get; set; }

        public DateTime finish_date { get; set; }

        private  string detail_list { get; set; }

        [NotMapped]
        public List<int> detailLIst 
    }



    public enum OrderStatus
    {
        Unknows = 0,
        Created = 1,
        Receive = 10,

        Finsihed = 90,
    }
}
