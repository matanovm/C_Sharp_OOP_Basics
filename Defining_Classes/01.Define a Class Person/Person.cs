﻿
namespace _01.Define_a_Class_Person
{
	public class Person
	{
		private string name;
		private int age;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public int Age
		{
			get { return age; }
			set { age = value; }
		}
		public string PrintNameAndAge()
		{
			return $"{this.name} {this.age}";
		}
	}
}
