using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace IniciandoComAspNetCore.Middlewares
{
    public class MeuMiddleware
    {
        // Responsável por executar o próximo Middleware dentro do pipeline
        private readonly RequestDelegate _next;

        public MeuMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine("\n\r ### Antes ### \n\r");

            await _next(context);

            Console.WriteLine("\n\r ### Depois ### \n\r");
        }
    }
}
