using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleBenchmark.Benchmarks
{
    public static class Extended
    {
    public static double StandardDeviation(IEnumerable<double> values,out double timing,out double  sd)
        {
            // Old method
            Stopwatch sw = new Stopwatch();

            sw.Start();
            double avg = values.Average();
            sd = Math.Sqrt(values.Average(v => Math.Pow(v - avg, 2)));
            sw.Stop();

            timing = sw.Elapsed.TotalMilliseconds;

            return 0;
        }

    }
}
