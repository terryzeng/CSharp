using System;
namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            while (a < 20)
            {
                Console.WriteLine("Value of a : {0}", a);
                a++;
                if (a > 15)
                {
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
