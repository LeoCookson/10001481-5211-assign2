using System;

namespace question04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print out the reverse timestables (highest number first) for:");

            var number = int.TryParse(Console.ReadLine(), out int Number);

            for(var i = 11; i >= 0; i--) {
                int a = i + 1;
                Console.WriteLine($"{a} x {Number} = {a * Number}");
            }
        }
    }
}
