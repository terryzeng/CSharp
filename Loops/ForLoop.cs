using System;
namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 10; a < 20; a = a + 1)
            {
                Console.WriteLine("Value of a: {0}",a);
            }
            Console.ReadLine();
        }
    }
}
