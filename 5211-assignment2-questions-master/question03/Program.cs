using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace question03
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
              
                 sw.Start();
         
            string[] fruitsArray = new string[] {"Banana", "Grapefruit", "Tomato", "Oranges"};

          

            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            sw.Reset();

            sw.Start();
                
            List<string> fruitsArray2 = new List<string> {"Banana", "Grapefruit", "Tomato", "Oranges"};

              foreach(var fruit in fruitsArray) {
                Console.WriteLine(fruit);
            }

            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }
    }
}
