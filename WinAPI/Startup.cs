using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WinAPI.Startup))]

namespace WinAPI
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                "default",
                "api/{controller}",
                new {controller = "Chapter"}
                );
            config.Formatters.XmlFormatter.UseXmlSerializer = true;
            config.Formatters.Remove(config.Formatters.JsonFormatter);

            //add the WebAPI framework in the OWIN pipeline:
            app.UseWebApi(config);
        }
    }
}
