using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab0
{
	internal class FizzBuzz
	{
		private int uppB = 10;
		public FizzBuzz(int a)
		{
			uppB = a;
		}

		public void Display()
		{
			for(int i=1; i<=uppB; i++)
			{
				if (i % 3 == 0 && i % 5 == 0)
				{
					Console.WriteLine("FizzBuzz\n");
				}
				else if (i % 3 == 0)
				{
					Console.WriteLine("Fizz\n");
				}
				else if (i % 5 == 0)
				{
					Console.WriteLine("Buzz\n");
				}
				else Console.WriteLine(i + "\n");
			}
		}
	}
}
