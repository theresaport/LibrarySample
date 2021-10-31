﻿using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace Library
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            //config.EnableCors();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
