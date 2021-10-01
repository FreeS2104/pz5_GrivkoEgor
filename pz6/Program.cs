using System;

namespace pz6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2;
            int n = int.Parse(Console.ReadLine());
            while (n % i != 0) 
            i += 1;
            Console.WriteLine(i);
            ////
           


        }
    }
}
