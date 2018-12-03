using System;

namespace _02.Creating_Constructors
{
	class StartUp
	{
		static void Main(string[] args)
		{
			
			string name = Console.ReadLine();
			int age = int.Parse(Console.ReadLine());

			var person = new Person();
			Person personWithAge = new Person(age);
			Person personWithNameAndAge = new Person(name, age);
			
			Console.WriteLine("{0} {1}", person.Name, person.Age);
			Console.WriteLine("{0} {1}", personWithAge.Name, personWithAge.Age);
			Console.WriteLine("{0} {1}", personWithNameAndAge.Name, personWithNameAndAge.Age);
		}
	}
}
