
using BuildingBlocks.CrossCutting.Correlation;
using Microsoft.AspNetCore.Http;

namespace BuildingBlocks.CrossCutting.Middleware
{
    internal class CorrelationMiddleware(RequestDelegate next, ICorrelationIdAccessor correlationService) : BaseMiddleware(next)
    {
        private readonly RequestDelegate _next = next;
        private readonly ICorrelationIdAccessor _correlationService = correlationService;
        protected override async Task PreProcessAsync(HttpContext context)
        {
            if (context.Request.Headers.TryGetValue("X-Correlation-ID", out var correlationId))
            {
                _correlationService.SetCorrelationId(correlationId);
            }
            else
            {
                var newCorrelationId = Guid.NewGuid().ToString();
                _correlationService.SetCorrelationId(newCorrelationId);
                context.Request.Headers.Add("X-Correlation-ID", newCorrelationId);
            }
            await Task.CompletedTask;
        }
        protected override async Task PostProcessAsync(HttpContext context)
        {
            context.Response.Headers.Add("X-Correlation-ID", _correlationService.GetCorrelationId() ?? string.Empty);
            await Task.CompletedTask;
        }
    }
}
