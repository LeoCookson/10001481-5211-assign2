using System;

namespace question02
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string[] fruits = new string[4] {"Apple \n", "Banana \n", "Coconut \n", "Mandarin \n"};

            foreach(var fruit in fruits) {
                Console.Write(fruit);
            }
        }
    }
}
