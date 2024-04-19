using System;
using System.Diagnostics.Metrics;

namespace InternalClassLibrary.Telemetry
{
    public class InternalLibraryMetrics : IInternalLibraryMetrics
    {
        private Counter<long> ExampleCounter { get; }
        public InternalLibraryMetrics()
        {
            Meter kafkaMeter = new Meter(Constants.InstrumentationConstants.LIBRARY_METER_NAME, "1.0");
            this.ExampleCounter = kafkaMeter.CreateCounter<long>("InternalClassLibrary.ExampleCounter", description: "Example Counter from InternalClassLibrary");

        }
        public void IncrementExampleCounter() => this.ExampleCounter.Add(1);
    }
}
