using System;
using System.Diagnostics;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine(Fibonnacci(55));
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }
        public static int Fibonnacci(int i)
        {
            if (i == 0)
            {
                return 0;
            }
            if (i == 1)
            {
                return 1;
            }
            return Fibonnacci(i - 1) + Fibonnacci(i - 2);
        }
    }

    
}
