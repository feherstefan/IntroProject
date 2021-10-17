using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Type first number");
		double x = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Type m,/,s,a");
		string z = Console.ReadLine();
		Console.WriteLine("Type second number");
		double y = Convert.ToDouble(Console.ReadLine());
		
		if (z == "s")
		{
			Console.WriteLine("Answer: {0}", x + y);
		}
		if (z == "a")
		{
			Console.WriteLine("Answer: {0}", (x + y)/2 );
		}
		if (z == "m")
		{
			Console.WriteLine("Answer: {0}", x * y );
		}
		if (z == "div")
		{
			if (x % y == 0)
				Console.WriteLine("y divizor pt x");
		}
		if (z == "con")
        {
			if (y == x + 1)
				Console.WriteLine("Nr e cons");
        }
		if (z == "max")
        {
			if (x > y)
				Console.WriteLine("x");
			else
				Console.WriteLine("y");
        }
		
	}
}
/*min e acelasi lucru dar invers
if (z == "max")
{
   if (x > y)
	   Console.WriteLine("x");
   else
	   Console.WriteLine("y");
}
*/