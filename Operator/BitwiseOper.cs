using System;
namespace BitwiseOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 60;
            int b = 13;
            int c = 0;

            c = a & b;
            Console.WriteLine("Line 1 - Value of c is {0}", c);

            c = a | b;
            Console.WriteLine("Line 2 - Value of c is {0}", c);

            c = a ^ b;
            Console.WriteLine("Line 3 - Value of c is {0}", c);

            c = ~a;
            Console.WriteLine("Line 4 - value of c is {0}", c);

            c = a << 2;
            Console.WriteLine("Line 5 - value of c is {0}", c);

            c = a >> 2;
            Console.WriteLine("Line 6 - value of c is {0}", c);
            Console.ReadLine();
        }
    }
}
