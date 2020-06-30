using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CulturaWeb.Configuration
{
    public static class ApiConfig
    {
        public static IServiceCollection WebApiConfig(this IServiceCollection services)
        {
            return services;
        }

        public static IApplicationBuilder WebApiConfiguration(this IApplicationBuilder application)
        {
            application.UseHttpsRedirection();
            return application;
        }
    }
}
