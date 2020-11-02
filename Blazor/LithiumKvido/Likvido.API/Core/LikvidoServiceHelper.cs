using System.Net.Http;
using Likvido.API.Models;
using Likvido.API.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Likvido.API
{
    /// <summary>
    /// Static service helpers, and extensions
    /// </summary>
    public static class LikvidoServiceHelper
    {
        
        public static void AddLikvidoApi(this IServiceCollection services, LikvidoConfiguration configuration)
        {
            services.AddSingleton(configuration);
            services.AddScoped<InvoicesService>();
            services.AddScoped<AuthentificationService>();
            services.AddScoped<CreditorsService>();
        }

    }
}