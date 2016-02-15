using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Server.Models
{
    class RoleAdministratorRelationship
    {
        [Key]
        public int id { get; set; }

        public int? role_id { get; set; }

        [ForeignKey("role_id")]
        public virtual Role Role { get; set; }

        public int? administretor_id { get; set; }

        [ForeignKey("administrator_id")]
        public virtual Administrator Administrator { get; set; }

        public bool is_enanle { get; set; }

        public string remarks { get; set; }
    }
}
