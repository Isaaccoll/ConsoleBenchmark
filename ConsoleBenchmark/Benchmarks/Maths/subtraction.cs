using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleBenchmark.Benchmarks
{
    class subtraction
    {

        public void SubtractionBenchmark(int iteration)
        {
            var startWatch = new Stopwatch();
            int i = 0;
            int b = iteration;

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            startWatch.Start();

            while (i < b)
            {
                b--;

            }
            startWatch.Stop();

            Console.WriteLine("Subtraction Benchmark\n");
            Console.WriteLine("Elapsed time " + startWatch.Elapsed.TotalMilliseconds + " ms");
            Console.ReadKey();
        }
    }
}
