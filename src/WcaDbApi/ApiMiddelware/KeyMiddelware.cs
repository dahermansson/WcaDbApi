using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcaDbApi.Repositories.Interfaces;

namespace WcaDbApi.ApiMiddelware
{
    public class KeyMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IKeyRepository _context;

        public KeyMiddleware(RequestDelegate next, IKeyRepository context)
        {
            _next = next;
            _context = context;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Path.StartsWithSegments("/api"))
            {
                if (!context.Request.Query.Keys.Contains("key"))
                {
                    context.Response.StatusCode = 400;              
                    await context.Response.WriteAsync("key is missing");
                    return;
                }
                Guid key;
                if(!Guid.TryParse(context.Request.Query["key"], out key) || !_context.VerifyKey(key))
                {
                    context.Response.StatusCode = 400;
                    await context.Response.WriteAsync("Key is missing");
                    return;
                }
            }
            await _next.Invoke(context);
        }
    }
    public static class ApiKeyExtension
    {
        public static IApplicationBuilder UseApiKey(this IApplicationBuilder app)
        {
            app.UseMiddleware<KeyMiddleware>();
            return app;
        }
    }
}
