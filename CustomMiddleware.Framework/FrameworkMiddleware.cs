using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

namespace CustomMiddleware.Framework
{
    public class FrameworkMiddleware : OwinMiddleware
    {
        public FrameworkMiddleware(OwinMiddleware next) : base(next)
        {
        }

        public override Task Invoke(IOwinContext httpContext)
        {
            Debug.WriteLine($"{httpContext.Request.Method} request for {httpContext.Request.Path} contained {httpContext.Request.Headers.Count} headers");
            return Next.Invoke(httpContext);
        }
    }

    public static class FrameworMiddlewareExtension
    {
        public static IAppBuilder UseCustomeFrameworMiddleware(this IAppBuilder builder)
        {
            return builder.Use<FrameworkMiddleware>();
        }
    }
}

