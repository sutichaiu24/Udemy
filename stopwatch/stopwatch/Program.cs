using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace stopwatch
{
    class Program
    {
     static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
         

            Console.ReadKey();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Duration());
            Console.ReadKey();

        }
    }
}
