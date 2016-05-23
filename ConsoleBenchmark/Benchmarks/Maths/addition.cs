using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleBenchmark.Benchmarks
{
    class addition
    {
        public void additionBenchmark(int iteration)
        {

            var startWatch = new Stopwatch();
            int i = 0;
            int b = 0;

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            startWatch.Start();

            while (i < iteration)
            {
                b++;
                i++;
            }
            startWatch.Stop();

            Console.WriteLine("Addition Benchmark\n");
            Console.WriteLine("Elapsed time " + startWatch.Elapsed.TotalMilliseconds + " ms");
            Console.ReadKey();

           

         
        }
    }
}
