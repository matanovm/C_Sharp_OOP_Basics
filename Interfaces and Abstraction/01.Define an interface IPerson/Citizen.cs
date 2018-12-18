using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Define_an_interface_IPerson
{
	public class Citizen : IPerson
	{
		public Citizen(string name, int age)
		{
			Name = name;
			Age = age;
		}

		public string Name
		{
			get;
			private set;
		}

		public int Age
		{
			get;
			private set;
		}
	}
}
