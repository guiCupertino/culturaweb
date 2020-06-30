using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CulturaWeb.Configuration
{
    public static class SwaggerConfig
    {
        public static IServiceCollection AddSwaggerConfig(this IServiceCollection services)
        {

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                             new Microsoft.OpenApi.Models.OpenApiInfo
                             {
                                 Title = "Cultura Web",
                                 Version = "v1",
                                 Description = "CulturaWeb - Locações",
                                 Contact = new OpenApiContact
                                 {
                                     Name = "CulturaWeb Serviçoes & Locações",
                                     Email = "guilherme_cupertino@hotmail.com",
                                     Url = new Uri("https://example.com/terms"),
                                 },
                             });

            });

            return services;
        }

        public static IApplicationBuilder UseSwaggerConfig(this IApplicationBuilder applicationBulder)
        {

            applicationBulder.UseSwagger();
            applicationBulder.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api CulturaWeb v1"));

            var option = new RewriteOptions();
            option.AddRedirect("^$", "swagger");
            applicationBulder.UseRewriter(option);

            return applicationBulder;
        }
    }
}
