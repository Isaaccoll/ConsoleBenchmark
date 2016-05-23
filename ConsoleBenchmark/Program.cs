using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Statistics;

namespace ConsoleBenchmark
{
    class Program
    {
        static void Main()
        {
            List<double> someValues = new List<double>( new double[] { 51,63,36,43,34,62,73,39,53,79});

            Benchmarks.addition addBenchmark = new Benchmarks.addition();
            Benchmarks.subtraction subtract = new Benchmarks.subtraction();

           var sd =  MathNet.Numerics.Statistics.Statistics.StandardDeviation(someValues);

            var returnedvalue = Benchmarks.Extended.StandardDeviation(someValues);

            Console.WriteLine("Returnded Value " + returnedvalue);

            addBenchmark.additionBenchmark(2147483647);
            subtract.SubtractionBenchmark(2147483647);

           
        }
    }
}
