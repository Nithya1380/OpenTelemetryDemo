using OpenTelemetry;
using OpenTelemetry.Resources;
using OpenTelemetry.Metrics;
using OpenTelemetry.Instrumentation.AspNetCore;
using InternalClassLibrary.Extensions;
using InternalClassLibrary.Constants;

namespace OpenTelemetryDemo.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection SetupOpenTelemetry(this IServiceCollection services) 
        {
            services.AddOpenTelemetry()
                    .ConfigureResource(resource => resource
                         .AddService(serviceName: "OpenTelemetryDemo"))
                    .WithMetrics(options => options
                        .AddAspNetCoreInstrumentation()
                        .AddMeter("OpenTelemetryDemoMeter", InstrumentationConstants.LIBRARY_METER_NAME)
                        //.AddInternalLibraryInstrumentation()
                        .AddConsoleExporter((exporterOptions, metricReaderOptions) =>
                         {
                            metricReaderOptions.PeriodicExportingMetricReaderOptions.ExportIntervalMilliseconds = 1000;
                         })
                        .AddPrometheusExporter()
                    );

            return services;
        }
    }
}
