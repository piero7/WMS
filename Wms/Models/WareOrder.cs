using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wms.Models
{
    class WareOrder
    {
        [Key]
        public int id { get; set; }

        public DateTime?  create_date { get; set; }

        public DateTime? finish_daet { get; set; }

        public OrderStatus status { get; set; }

        public string remarks { get; set; }

        protected string detail_list_string { get; set; }

        [Notmapped]
        public List<int> DetailsList
        {
            get
            {
               if(string.IsNullOrEmpty(this.detail_list_string))
                {
                    return null;
                }

                List<int> ret = new List<int>();
                this.
            }
        }
    }
}
