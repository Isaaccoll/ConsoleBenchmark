using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleBenchmark.Benchmarks
{
   public class TimeBenchmark
    {
       static List<string> addToList = new List<string>();

        

        public static void Timing<T>(int count, string desc, Func<T> action,bool writeToFile)
        {
            action();
           
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
                action();

            double seconds = sw.Elapsed.TotalSeconds;

            Console.WriteLine("{0} took {1} seconds", desc, seconds);
          //  Console.ReadKey();
            var addvalue = (desc + " took " + seconds +" seconds");
            addToList.Add(addvalue);

            if(writeToFile==true)
            {
                Storage file = new Storage();

                file.writeFile(addToList);  
            }
        }
    }
}
