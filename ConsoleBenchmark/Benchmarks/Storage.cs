using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleBenchmark.Benchmarks
{
  
    public class Storage
    {
        
        public void writeFile(List<string> file)
        {
            System.IO.StreamWriter writefile = new StreamWriter(@"C: \Users\isaac.coll\Dropbox\1_DISSERTATION_WORK\LATEST SOFTWARE\Console_Benchmark\benchmarkText.txt");

            for (int i = 0; i <= file.Count - 1; i++)
            {
                writefile.WriteLine(file[i].ToString());

            }
            writefile.Close();

        }

    }
}
