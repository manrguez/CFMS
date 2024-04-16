using Microsoft.AspNetCore.Http;
using System.Net;
using System.Threading.Tasks;
using System;

namespace CFMS.Logger
{
    public class ExceptionHandler
    {
        private readonly RequestDelegate _next;
        private readonly ILoggerService _logger;
        public ExceptionHandler(RequestDelegate next, ILoggerService logger)
        {
            _logger = logger;
            _next = next;
        }
        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                _logger.LogError($"ERROR: {ex}");
                httpContext.Response.Redirect("/Home/Error");               
            }
        }        
    }
}
