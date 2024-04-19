using InternalClassLibrary.Constants;
using OpenTelemetry.Metrics;
using System;
using System.Collections.Generic;
using System.Text;

namespace InternalClassLibrary.Extensions
{
    public static class TelemetryExtensions
    {
        public static MeterProviderBuilder AddInternalLibraryInstrumentation(this MeterProviderBuilder builder)
        {
            builder.AddMeter(InstrumentationConstants.LIBRARY_METER_NAME);
            return builder;
        }
    }
}
