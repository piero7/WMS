﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Server.Models
{
    /// <summary>
    /// 计费用户
    /// </summary>
    public class Customer
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; }

        public string address { get; set; }

        public string inner_number { get; set; }

        public bool is_enable { get; set; } = true;

        public string remarks { get; set; }
    }
}
