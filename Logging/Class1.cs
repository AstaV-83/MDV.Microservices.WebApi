using System;
using System.Collections.Generic;
using System.Text;

namespace Logging
{
    public class TelemetryAttribute : Attribute
    {
        public string ClassName { get; set; }
        public string Method { get; set; }
        public TelemetryAttribute(string className, string method)
        {
            Method = method;
            ClassName = className;
            Console.WriteLine($"Telemetry logging call {className}  {method}");
        }
    }
}
