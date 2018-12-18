using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Ferrari
{
	public class Program
	{
		private const string Model = "488-Spider";

		public static void Main()
		{
			string driverName = Console.ReadLine();

			Ferrari ferrari = new Ferrari(driverName, Model);

			Console.Write($"{ferrari.Model}");

			Console.Write(ferrari.Brakes());

			Console.Write(ferrari.Gas());

			Console.Write($"{ferrari.Driver}");

			Console.WriteLine();
		}
	}
}
