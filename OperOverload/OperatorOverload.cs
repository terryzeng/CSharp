using System;
namespace OperatorOverApplication
{
    class Box
    {
        private double length;
        private double breadth;
        private double height;

        public double getVolume()
        {
            return length * breadth * height;
        }

        public void setLength(double len)
        {
            length = len;
        }

        public void setBreadth(double bre)
        {
            breadth = bre;
        }

        public void setHeight(double hei)
        {
            height = hei;
        }

        //Overload + operator to add two Box objects
        public static Box operator+ (Box b, Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
            box.breadth = b.breadth + c.breadth;
            box.height = b.height + c.height;
            return box;
        }
    }

    class Tester
    {
        static void Main(string[] args)
        {
            Box Box1 = new Box();
            Box Box2 = new Box();
            Box Box3 = new Box();
            double volume = 0.0;

            //box1 specification
            Box1.setLength(6.0);
            Box1.setBreadth(7.0);
            Box1.setHeight(5.0);

            //box2 specification
            Box2.setLength(12.0);
            Box2.setBreadth(13.0);
            Box2.setHeight(10.0);
            
            //volume of box1
            volume = Box1.getVolume();
            Console.WriteLine("Volume of Box1: {0}", volume);

            //volume of box2
            volume = Box2.getVolume();
            Console.WriteLine("Volume of Box2: {0}", volume);

            //Add two object as follows:
            Box3 = Box1 + Box2;

            //volume of box3
            volume = Box3.getVolume();
            Console.WriteLine("Volume of Box3: {0}", volume);
            Console.ReadKey();
        }
    }
}
