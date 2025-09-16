using Microsoft.AspNetCore.Http;

namespace BuildingBlocks.CrossCutting.Middleware
{
    public abstract class BaseMiddleware(RequestDelegate next)
    {
        private readonly RequestDelegate _next = next;

        public async Task InvokeAsync(HttpContext context)
        {
            await PreProcessAsync(context);
            await _next(context);
            await PostProcessAsync(context);
        }
        protected abstract Task PreProcessAsync(HttpContext context);
        protected abstract Task PostProcessAsync(HttpContext context);
    }
}
