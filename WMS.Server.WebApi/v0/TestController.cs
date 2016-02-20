using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using WMS.Server.Models;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;
using System.Text;

namespace WMS.Server.WebApi.Areas.V0
{
    public class TestController : ApiController
    {
        /// <summary>
        /// 测试连接
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public Warehouse TestConnection()
        {
            return new Warehouse
            {
                name = "name",
                address = "address",
                is_enable = true,
                id = 123,
            };

        }

        [NonAction]
        public Dictionary<string, object> GetParms<T>(T obj)
        {
            var ret = new Dictionary<string, object>();
            var ps = typeof(T).GetProperties();
            foreach (var p in ps)
            {
                ret.Add(p.Name, p.GetValue(obj)?.ToString());
            }
            return ret;
        }
    }
}
