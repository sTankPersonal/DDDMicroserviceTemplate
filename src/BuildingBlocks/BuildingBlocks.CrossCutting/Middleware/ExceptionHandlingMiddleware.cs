using Microsoft.AspNetCore.Http;

namespace BuildingBlocks.CrossCutting.Middleware
{
    public class ExceptionHandlingMiddleware(RequestDelegate next) : BaseMiddleware(next)
    {
        private readonly RequestDelegate _next = next;

        protected override Task PostProcessAsync(HttpContext context)
        {
            throw new NotImplementedException();
        }

        protected override Task PreProcessAsync(HttpContext context)
        {
            throw new NotImplementedException();
        }
    }
}
