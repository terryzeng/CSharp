using System;
namespace BoxApplication
{
    class Box
    {
        public double length;
        public double breadth;
        public double height;
    }

    class Boxtester
    {
        static void Main(string[] args)
        {
            Box Box1 = new Box();
            Box Box2 = new Box();
            double volume = 0.0;

            //Box1 specification
            Box1.height = 5.0;
            Box1.length = 6.0;
            Box1.breadth = 7.0;

            //Box2 specification
            Box2.height = 10.0;
            Box2.length = 12.0;
            Box2.breadth = 13.0;

            //volume of Box1
            volume = Box1.height * Box1.length * Box1.breadth;
            Console.WriteLine("Volume of Box1: {0}", volume);

            //volume of Box2
            volume = Box2.height * Box2.length * Box2.breadth;
            Console.WriteLine("Volume of Box2: {0}",volume);
            Console.ReadKey();
        }
    }
}
