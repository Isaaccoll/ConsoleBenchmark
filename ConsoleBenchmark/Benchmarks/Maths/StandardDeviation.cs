using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBenchmark.Benchmarks
{
    public static class Extended
    {
    public static double StandardDeviation(IEnumerable<double> values)
        {
                // Old method
                double avg = values.Average();
                return Math.Sqrt(values.Average(v => Math.Pow(v - avg, 2)));          
            
        }

    }
}
