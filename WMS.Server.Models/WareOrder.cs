using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Server.Models
{
    class WareOrder
    {
        [Key]
        public int id { get; set; }

        public DateTime? create_date { get; set; } = DateTime.Now;

        public DateTime? finish_date { get; set; }

        public OrderStatus status { get; set; } = 0;

        public string remarks { get; set; }

        protected string detail_list_string { get; set; }

        public bool is_enable { get; set; } = true;

        [NotMapped]
        public List<int> DetailsList
        {
            get
            {
                if (string.IsNullOrEmpty(this.detail_list_string))
                {
                    return null;
                }

                List<int> ret = new List<int>();
                var strList = this.detail_list_string.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                int tid = 0;
                foreach (var s in strList)
                {
                    if (int.TryParse(s, out tid) && tid != 0)
                    {
                        ret.Add(tid);
                    }
                }

                return ret;
            }
            set
            {
                this.detail_list_string = "";
                if (value != null && value.Count < 1)
                {
                    foreach (var item in value)
                    {
                        if (item > 0)
                        {
                            this.detail_list_string += item.ToString() + ';';
                        }
                    }
                }
            }

        }
    }
    public enum OrderStatus
    {
        Unknows = 0,
        Created = 1,
        Receive = 10,

        Finsihed = 90,
    }
}
