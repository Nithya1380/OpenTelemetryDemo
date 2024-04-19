using InternalClassLibrary.Telemetry;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace InternalClassLibrary.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddInternalLibrary(this IServiceCollection services)
        {
            services.AddSingleton<IInternalLibraryMetrics, InternalLibraryMetrics>();
            services.AddTransient<IExampleClass, ExampleClass>();
            return services;
        }
    }
}
