using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wms.Models
{
    class Role
    {
        public int id { get; set; }

        public string name { get; set; }

        public string inner_number { get; set; }

        public bool is_enable { get; set; }

        public string remarks { get; set; }

        public string authority_string { get; set; }
    }
}
