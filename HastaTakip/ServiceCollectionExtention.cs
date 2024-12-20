using HastaTakip.Interfaces;
using HastaTakip.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaTakip
{
    public static class ServiceCollectionExtention
    {
        // ServiceCollection'a IDatabaseService ve DatabaseService ekleyen extension method
        public static IServiceCollection AddDatabaseService(this IServiceCollection services)
        {
            // Burada, IDatabaseService'e DatabaseService implementasyonunu ekliyoruz.
            services.AddSingleton<IDatabaseService>(provider => new DatabaseService());

            // Extension method'un sonunda services geri döndürülüyor
            return services;
        }
    }
}
