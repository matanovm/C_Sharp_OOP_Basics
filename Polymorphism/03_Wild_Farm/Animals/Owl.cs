using _03.Wild_Farm.Animals.Animal_Type;
using _03.Wild_Farm.Food;
using System;

namespace _03.Wild_Farm.Animals
{
	class Owl : Bird
	{
		public Owl(string name, double weight, double wingSize)
			: base(name, weight, wingSize) { }

		protected override Type[] PreferredFoods
		{
			get
			{
				return new Type[] { typeof(Meat) };
			}
		}

		protected override double WeightIncreaseMultiplier => 0.25;

		public override string MakeSound()
		{
			return "Hoot Hoot";
		}
	}
}
