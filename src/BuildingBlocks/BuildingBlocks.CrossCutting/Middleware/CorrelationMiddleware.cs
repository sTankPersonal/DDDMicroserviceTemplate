using BuildingBlocks.CrossCutting.Correlation;
using Microsoft.AspNetCore.Http;

namespace BuildingBlocks.CrossCutting.Middleware
{
    internal class CorrelationMiddleware(RequestDelegate next, ICorrelationService correlationAccessor) : BaseMiddleware(next)
    {
        private readonly ICorrelationService _correlationAccessor = correlationAccessor;

        protected override async Task PreProcessAsync(HttpContext context)
        {
            await _correlationAccessor.GetOrSetCorrelationId(context);
        }

        protected override async Task PostProcessAsync(HttpContext context)
        {
            await _correlationAccessor.SetCorrelationId(context);
        }
    }
}
