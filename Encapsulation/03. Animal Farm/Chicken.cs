﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animal_Farm
{
	public class Chicken
	{
		public const int MinAge = 0;
		public const int MaxAge = 15;

		private string _name;
		private int _age;

		public Chicken(string name, int age)
		{
			this.Name = name;
			this.Age = age;
		}

		public string Name
		{
			get { return _name; }

			private set
			{
				if (string.IsNullOrEmpty(value) || value == " ")
				{
					throw new ArgumentException("Name cannot be empty.");
				}
				_name = value;
			}
		}

		public int Age
		{
			get { return _age; }

			private set
			{
				if (value < MinAge || value > MaxAge)
				{
					throw new ArgumentException("Age should be between 0 and 15.");
				}
				_age = value;
			}
		}

		public double ProductPerDay()
		{
			return this.CalculateProductPerDay();
		}
		private double CalculateProductPerDay()
		{
			switch (this.Age)
			{
				case 0:
				case 1:
				case 2:
				case 3:
					return 1.5;
				case 4:
				case 5:
				case 6:
				case 7:
					return 2;
				case 8:
				case 9:
				case 10:
				case 11:
					return 1;
				default:
					return 0.75;
			}
		}
	}
}