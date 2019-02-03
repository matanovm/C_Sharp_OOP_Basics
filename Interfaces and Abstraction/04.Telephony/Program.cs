using System;

namespace _04.Telephony
{
	class Program
	{
		static void Main(string[] args)
		{
			Smartphone smartphone = new Smartphone(Console.ReadLine().Split(' '), Console.ReadLine().Split(' '));

			foreach (string number in smartphone.PhoneNumbersArray)
			{
				Console.WriteLine(smartphone.CallNumber(number));
			}

			foreach (string site in smartphone.SitesArray)
			{
				Console.WriteLine(smartphone.BrowseSite(site));
			}
		}
	}
}
