﻿using System;

namespace _01.Define_an_interface_IPerson
{
	class Program
	{
		static void Main(string[] args)
		{
			string name = Console.ReadLine();
			int age = int.Parse(Console.ReadLine());
			IPerson person = new Citizen(name, age);
			Console.WriteLine(person.Name);
			Console.WriteLine(person.Age);
		}
	}
}
