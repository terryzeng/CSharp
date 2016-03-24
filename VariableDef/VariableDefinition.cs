using System;
namespace VariableDefinition
{
	class Program
	{
		static void Main(string[] args)
		{
			short a;
			int b;
			double c;

			/*actual initialization*/
			a = 10;
			b = 20;
			c = a + b;
			Console.WriteLine("a={0},b={1},c={2}",a,b,c);
			//Console.ReadLine();
			int num;
			Console.WriteLine("Please input number:");
			num = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("input num={0}",num);
			Console.ReadLine();
		}
	}
}
