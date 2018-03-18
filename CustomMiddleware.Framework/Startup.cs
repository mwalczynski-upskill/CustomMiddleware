using System.Web.Http;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(CustomMiddleware.Framework.Startup))]

namespace CustomMiddleware.Framework
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            WebApiConfig.Register(config);
            app.UseCustomeFrameworMiddleware();
            app.UseWebApi(config);
        }
    }
}