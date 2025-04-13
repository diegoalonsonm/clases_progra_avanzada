using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Inventario.UI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        //protected void Application_Error()
        //{
        //    Exception exception = Server.GetLastError();
        //    // Log the exception or handle it as needed
        //    // For example, you can log it to a file or a logging service
        //    // LogException(exception);
        //    // Clear the error and redirect to an error page
        //    Server.ClearError();
        //    Response.Redirect("~/Error");
        //}
    }
}
