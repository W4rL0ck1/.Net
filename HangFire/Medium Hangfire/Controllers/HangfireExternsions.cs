using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Hangfire;
using Newtonsoft.Json;
using Hangfire.MemoryStorage;

namespace Hangfire.Controllers
{
    public static class HangfireExtension 
    {
        public static IServiceCollection ConfigureHangfire(this IServiceCollection services, IWebHostEnvironment hostingEnvironment, IConfiguration configuration)
        {
            if (hostingEnvironment == null) throw new ArgumentNullException(nameof(hostingEnvironment));
            if (configuration == null) throw new ArgumentNullException(nameof(configuration));

            if (hostingEnvironment.IsDevelopment())
            {
                return ConfigureForDevelopment(services);
            }

            return ConfigureForProduction(services, configuration);
        }

        private static IServiceCollection ConfigureForDevelopment(IServiceCollection services)
        {
            services.AddHangfire(op =>
            {
                op.UseMemoryStorage();
            });

            return services;
        }

        private static IServiceCollection ConfigureForProduction(IServiceCollection services, IConfiguration configuration)
        {
            services.AddHangfire(op =>
            {
                op.UseSqlServerStorage(configuration.GetConnectionString("DefaultConnection"));

            });

            return services;
        }
    }
   
}