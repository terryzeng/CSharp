using System;
namespace MiscOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //example of sizeof operators
            Console.WriteLine("The size of int is {0}", sizeof(int));
            Console.WriteLine("The size of short is {0}", sizeof(short));
            Console.WriteLine("The size of double is {0}", sizeof(double));

            //example of ternary operator
            int a, b;
            a = 10;
            b = (a == 1) ? 20 : 30;
            Console.WriteLine("Value of b is {0}",b);

            b = (a == 10) ? 20 : 30;
            Console.WriteLine("Value of b is {0}",b);
            Console.ReadLine();
        }
    }
}
