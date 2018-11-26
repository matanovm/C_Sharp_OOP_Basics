using System;
using System.Reflection;

namespace _02.Creating_Constructors
{
	class StartUp
	{
		static void Main(string[] args)
		{
			Type personType = typeof(Person);
			ConstructorInfo emptyConstructor = personType.GetConstructor(new Type[] { });
			ConstructorInfo NoNameAge = personType.GetConstructor(new[] { typeof(int) });
			ConstructorInfo nameAge = personType.GetConstructor(new[] { typeof(string), typeof(int) });
			bool swapped = false;

			if (nameAge == null)
			{
				nameAge = personType.GetConstructor(new[] { typeof(int), typeof(string) });
				swapped = true;
			}

			string name = Console.ReadLine();
			int age = int.Parse(Console.ReadLine());

			Person Person = (Person)emptyConstructor.Invoke(new object[] { });
			Person personWithAge = (Person)NoNameAge.Invoke(new object[] { age });
			Person personWithAgeAndName = swapped ? (Person)nameAge.Invoke(new object[] { age, name }) : (Person)nameAge.Invoke(new object[] { name, age });

			Console.WriteLine("{0} {1}", Person.Name, Person.Age);
			Console.WriteLine("{0} {1}", personWithAge.Name, personWithAge.Age);
			Console.WriteLine("{0} {1}", personWithAgeAndName.Name, personWithAgeAndName.Age);
		}
	}
}
