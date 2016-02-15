using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Server.Models
{
    class WareTaks
    {
        [Key]
        public int id { get; set; }

        public DateTime? create_date { get; set; }
    }
}
