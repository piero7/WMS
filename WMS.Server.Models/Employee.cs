using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Server.Models
{
    class Employee
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; }

        public string photo_path { get; set; }

        public DateTime? birthday { get; set; }

        public int age { get; set; }

        public string describe { get; set; }

        public string inner_number { get; set; }

        public string token { get; set; }

        public string phone_number { get; set; }

        public bool is_enable { get; set; }

        /// <summary>
        /// 是否在工作时间中
        /// </summary>
        public bool is_working { get; set; }

        /// <summary>
        /// 工作状态（预留）
        /// </summary>
        public EmployeeStatus status { get; set; }

        public string remarks { get; set; }

    }

    public enum EmployeeStatus
    {
        Unknown = 0,
    }
}
