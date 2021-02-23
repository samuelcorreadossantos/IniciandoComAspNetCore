using IniciandoComAspNetCore.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace IniciandoComAspNetCore.Extensions
{
    public static class CustomMiddlewaresExtension
    {
        public static IApplicationBuilder UseMeuMiddleware(this IApplicationBuilder applicationBuilder) => applicationBuilder.UseMiddleware<MeuMiddleware>();
    }
}
