using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WMS.Server.WebApi.Areas.v1
{
    public class TestController : ApiController
    {
        [HttpGet]
        public string TestConnection()
        {
            return "ok2";
        }
    }
}
