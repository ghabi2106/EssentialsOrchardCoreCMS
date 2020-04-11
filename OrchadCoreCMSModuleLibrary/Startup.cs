using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace OrchadCoreCMSModuleLibrary
{
    public class Startup
    {
        public void Configure(IEndpointRouteBuilder endpoint)
        {
            endpoint.MapGet("/library", async context =>
            {
                await context.Response.WriteAsync("Modular Library!");
            });
        }
    }
}
