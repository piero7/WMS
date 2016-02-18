using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Server.Models
{
    class Administrator
    {
        [Key]
        public int id { get; set; }

        public string login_name { get; set; }

        /// <summary>
        /// 密文密码！
        /// </summary>
        public string password { get; set; }

        public DateTime? last_login_date { get; set; }

        public string real_name { get; set; }

        public string remarks { get; set; }

        public bool is_enable { get; set; }

        public int? employee_id { get; set; }

        [ForeignKey("employee_id")]
        public virtual Employee Employee { get; set; }

        /// <summary>
        /// 权限字符串（预留）
        /// </summary>
        public string authority_string { get; set; }
    }
}
