using System;
using System.Web.Http;
using System.Web.Routing;

namespace Taschenrechner.webapi
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            GlobalConfiguration.Configure(config =>
            {
                config.MapHttpAttributeRoutes();
            });


            RouteTable.Routes.MapHttpRoute(name: "HelloWorld", routeTemplate: "HelloWorld/{action}",
            defaults: new
            {
                controller = "HelloWorld",
                id = System.Web.Http.RouteParameter.Optional
            }
            );
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}