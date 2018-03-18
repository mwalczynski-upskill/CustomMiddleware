using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace CustomMiddleware.Core
{
    public class CoreMiddleware
    {
        private readonly RequestDelegate next;

        public CoreMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {      
            Debug.WriteLine($"{httpContext.Request.Method} request for {httpContext.Request.Path} contained {httpContext.Request.Headers.Count} headers");
            return this.next(httpContext);
        }
    }

    public static class CoreMiddlewareExtension
    {
        public static IApplicationBuilder UseCustomeCoreMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CoreMiddleware>();
        }
    }
}
