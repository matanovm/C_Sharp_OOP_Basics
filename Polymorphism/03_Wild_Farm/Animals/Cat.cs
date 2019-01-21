using System;
using _03.Wild_Farm.Animals.Animal_Type;
using _03.Wild_Farm.Food;

namespace _03.Wild_Farm.Animals
{
	class Cat : Feline
	{
		public Cat(string name, double weight, string livingRegion, string breed)
			: base(name, weight, livingRegion, breed) { }

		protected override Type[] PreferredFoods => new Type[] { typeof(Meat), typeof(Vegetable) };
		protected override double WeightIncreaseMultiplier => 0.30;

		public override string MakeSound()
		{
			return "Meow";
		}
	}
}
