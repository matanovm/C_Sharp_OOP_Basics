using System;

namespace _03.Ferrari
{
	public class Program
	{
		private const string Model = "488-Spider";

		public static void Main()
		{
			Ferrari ferrari = new Ferrari(Console.ReadLine());
			Console.WriteLine(ferrari);
		}
	}
}
