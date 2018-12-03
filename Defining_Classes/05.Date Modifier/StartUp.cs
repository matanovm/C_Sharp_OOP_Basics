using System;

namespace _05.Date_Modifier
{
	class StartUp
	{
		static void Main(string[] args)
		{
			string firstDate = Console.ReadLine();
			string secondDate = Console.ReadLine();
			Console.WriteLine(Modifier.GetDaysBetweenDates(firstDate, secondDate));
		}
	}
}
