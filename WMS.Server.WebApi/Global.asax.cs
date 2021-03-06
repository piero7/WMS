﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WMS.Server.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            ////GlobalConfiguration.Configuration.Services.Replace(typeof(System.Web.Http.Dispatcher.IHttpControllerSelector),
            ////                                       new AreaHttpControllerSelector(
            ////                                           GlobalConfiguration.Configuration));
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            GlobalConfiguration.Configuration.Services.Replace(typeof(System.Web.Http.Dispatcher.IHttpControllerSelector), new AreaHttpControllerSelector(GlobalConfiguration.Configuration));
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SupportedMediaTypes.Clear();
        }
    }
}
