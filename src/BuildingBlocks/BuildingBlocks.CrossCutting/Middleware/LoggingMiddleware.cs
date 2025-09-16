
using BuildingBlocks.CrossCutting.Logging;
using Microsoft.AspNetCore.Http;

namespace BuildingBlocks.CrossCutting.Middleware
{
    public class LoggingMiddleware(RequestDelegate next, ILoggingService loggingService) : BaseMiddleware(next)
    {
        protected readonly RequestDelegate _next = next;
        protected readonly ILoggingService _loggingService = loggingService;

        protected override async Task PreProcessAsync(HttpContext context)
        {
            _loggingService.LogInformation($"Request: {context.Request.Method} {context.Request.Path}");
            await Task.CompletedTask;
        }

        protected override async Task PostProcessAsync(HttpContext context)
        {
            _loggingService.LogInformation($"Response: {context.Response.StatusCode}");
            await Task.CompletedTask;
        }
    }
}
