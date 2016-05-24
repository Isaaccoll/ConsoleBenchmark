using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Statistics;
using System.Diagnostics;

namespace ConsoleBenchmark
{
    class Program
    {
        static void Main()
        {
            List<double> someValues = new List<double>( new double[] { 51,63,36,43,34,62,73,39,53,79});
            Stopwatch sw = new Stopwatch();

            Benchmarks.addition addBenchmark = new Benchmarks.addition();
            Benchmarks.subtraction subtract = new Benchmarks.subtraction();

            Console.WriteLine("Standard Deviation from MathNet\n");

            sw.Start();
            var sd =  MathNet.Numerics.Statistics.Statistics.StandardDeviation(someValues);
            sw.Stop();
            Console.WriteLine("Calcuate Standard Deviation " + sd);
            Console.WriteLine("Time is: " + sw.ElapsedMilliseconds + " ms\n");
          

            Console.WriteLine("Standard Deviation ");
            double timing=0;
            double std=0;

            var returnedvalue = Benchmarks.Extended.StandardDeviation(someValues, out timing, out std);
            Console.WriteLine("Calculated Standard Div " + std);
            Console.WriteLine("Time is: " + timing + " ms");


            addBenchmark.additionBenchmark(2147483647);
            subtract.SubtractionBenchmark(2147483647);

            ExecuteBenchMark();

        }


        public static void ExecuteBenchMark()
        {
            const int count = 200000000;
            List<double> someValues = new List<double>(new double[] { 51, 63, 36, 43, 34, 62, 73, 39, 53, 79 });

            int[] a = { 1 };
            double d = 5;
            int i = 5;


            Benchmarks.TimeBenchmark.Timing(count, "array index", () => a[0],false);
            Benchmarks.TimeBenchmark.Timing(count, "double mult", () => d * 6, false);
            Benchmarks.TimeBenchmark.Timing(count, "double add ", () => d + 6, false);
            Benchmarks.TimeBenchmark.Timing(count, "int    mult", () => i * 6, false);
            Benchmarks.TimeBenchmark.Timing(count, "int    add ", () => i + 6, false);
            Benchmarks.TimeBenchmark.Timing(count, "int Div", () => i / 6, false);
            Benchmarks.TimeBenchmark.Timing(count, "int Sub", () => i - 6, false);
            Benchmarks.TimeBenchmark.Timing(count, "double Div", () => d / 6, false);
            Benchmarks.TimeBenchmark.Timing(count, "double Sub", () => d - 6,true);

           
        }
    }
}
