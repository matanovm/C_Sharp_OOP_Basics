using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Vehicle_Extension
{
	public class Validator
	{
		public static void CheckPositiveNumber(double value)
		{
			if (value < 0)
			{
				Console.WriteLine("Fuel must be a positive number");
			}
		}
	}
}
