using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Server.Models
{
    public class RoleAdministratorRelationship
    {
        [Key]
        public int id { get; set; }

        public int? role_id { get; set; }

        [ForeignKey("role_id")]
        public virtual Role Role { get; set; }

        public int? administrator_id { get; set; }

        [ForeignKey("administrator_id")]
        public virtual Administrator Administrator { get; set; }

        public bool is_enable { get; set; } = true;

        public string remarks { get; set; }
    }
}
