using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class LinkedMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<LinkedMiddleware> logger;
        private readonly IConfiguration configuration;

        public LinkedMiddleware(RequestDelegate next, ILogger<LinkedMiddleware> logger, IConfiguration configuration)
        {
            _next = next;
            this.logger = logger;
            this.configuration = configuration;
        }

        public Task Invoke(HttpContext httpContext)
        {
            logger?.LogInformation(configuration["mensaje"] );
           
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class LinkedMiddlewareExtensions
    {
        public static IApplicationBuilder UseLinkedMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LinkedMiddleware>();
        }
    }
}
