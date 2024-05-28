using Autofac;
using MVC_LOGIN_AND_REGISTER.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MVC_LOGIN_AND_REGISTER
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            // Register the Autofac container builder
            var builder = new ContainerBuilder();


            // Register dependencies
            builder.RegisterType<ApplicationDbContext>().AsSelf().InstancePerRequest();


            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
