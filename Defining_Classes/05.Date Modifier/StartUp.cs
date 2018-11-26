using System;

namespace _05.Date_Modifier
{
	class StartUp
	{
		static void Main(string[] args)
		{
			var firstDate = Console.ReadLine();
			var secondDate = Console.ReadLine();
			Console.WriteLine(Modifier.GetDaysBetweenDates(firstDate, secondDate));
		}
	}
}
