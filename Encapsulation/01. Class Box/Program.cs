using System;
using System.Reflection;
using System.Linq;

namespace _01.Class_Box
{
	class Program
	{
		public static void Main()
		{
			Type boxType = typeof(Box);
			FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
			Console.WriteLine(fields.Count());

			double length = double.Parse(Console.ReadLine());
			double width = double.Parse(Console.ReadLine());
			double height = double.Parse(Console.ReadLine());
			Box box = null;

			try
			{
				box = new Box(length, width, height);
			}
			catch (ArgumentException ex)
			{
				Console.WriteLine(ex.Message);
				return;
			}

			Console.WriteLine($"Surface Area - {box.SurfaceArea():F2}");
			Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea():F2}");
			Console.WriteLine($"Volume - {box.Volume():F2}");
		}
	}
}
