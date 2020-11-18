using HealthAssist;
using HealthAssist.Extensions;
using HealthModules;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

[assembly: PreApplicationStartMethod(typeof(MvcApplication), "Register")]

namespace HealthAssist
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static void Register()
        {
            HttpApplication.RegisterModule(typeof(LogModule));
        }

        protected void Application_PreRequestHandlerExecute()
        {
            Debug.WriteLine("PreExecute");
        }

        protected void Application_PostRequestHandlerExecute()
        {
            Debug.WriteLine("PostExecute");
        }
        protected void Application_Start()
        {
            //ControllerBuilder.Current.SetControllerFactory(new ParameterControllerFactory());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ViewEngines.Engines.Insert(0,new ThemeViewEngine());
        }

        protected void Application_End()
        {
            Debug.WriteLine("End");
        }
    }
}
