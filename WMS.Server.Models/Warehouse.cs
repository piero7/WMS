using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace WMS.Server.Models
{
    //[Serializable]
    public class Warehouse
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; }

        public string address { get; set; }

        public bool is_enable { get; set; } = true;

        public string inner_number { get; set; }

        public string token { get; set; }

        public DateTime last_login_date { get; set; } = DateTime.Now;

        public string remarks { get; set; }

        public WarehouseStatus status { get; set; } = 0;

    }

    public enum WarehouseStatus
    {
        /// <summary>
        /// 未知
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// 正常
        /// </summary>
        Normal = 1,
        /// <summary>
        /// 维护中
        /// </summary>
        Repairing = 10,
        /// <summary>
        /// 已关闭
        /// </summary>
        Closed = -1,
    }
}
