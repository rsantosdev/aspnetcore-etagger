using AspnetCore.ETagger.Middleware;
using Microsoft.AspNetCore.Builder;

namespace AspnetCore.ETagger.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static void UseETagger(this IApplicationBuilder app)
        {
            app.UseMiddleware<ETagMiddleware>();
        }
    }
}
