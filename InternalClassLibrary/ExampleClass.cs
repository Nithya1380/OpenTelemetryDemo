using InternalClassLibrary.Telemetry;
using System;
using System.Collections.Generic;
using System.Text;

namespace InternalClassLibrary
{
    public class ExampleClass: IExampleClass
    {
        private readonly IInternalLibraryMetrics _internalLibraryMetrics;

        public ExampleClass(IInternalLibraryMetrics internalLibraryMetrics)
        {
            this._internalLibraryMetrics = internalLibraryMetrics;
        }

        public void ExampleMethod()
        {
            this._internalLibraryMetrics.IncrementExampleCounter();
        }
    }
}
