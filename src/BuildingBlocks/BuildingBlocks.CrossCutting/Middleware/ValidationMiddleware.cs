using System.Text.Json;
using BuildingBlocks.CrossCutting.Validation;
using Microsoft.AspNetCore.Http;

namespace BuildingBlocks.CrossCutting.Middleware
{
    public class ValidationMiddleware(RequestDelegate next, IValidationService validationService) : BaseMiddleware(next)
    {
        private readonly RequestDelegate _next = next;
        private readonly IValidationService _validationService = validationService;

        protected override async Task PreProcessAsync(HttpContext context)
        {
            context.Request.EnableBuffering();
            EnableBuffering(context);
        }

        protected override Task PostProcessAsync(HttpContext context)
        {
            // No post-processing needed for validation
            return Task.CompletedTask;
        }
    }
}
