namespace _03.Oldest_Family_Member
{
	using System;
	using System.Reflection;

	public class StartUp
	{
		public static void Main()
		{

			Family family = new Family();
			int membersNumber = int.Parse(Console.ReadLine());

			while (membersNumber > 0)
			{
				var personData = Console.ReadLine().Split();
				var member = new Person(personData[0], int.Parse(personData[1]));
				family.AddMember(member);

				membersNumber--;
			}

			Person oldestMember = family.GetOldestMember();
			Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
		}
	}
}