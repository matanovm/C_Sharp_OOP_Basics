using _03.Wild_Farm.Animals.Animal_Type;
using _03.Wild_Farm.Food;
using System;

namespace _03.Wild_Farm.Animals
{
	class Tiger : Feline
	{
		public Tiger(string name, double weight, string livingRegion, string breed)
			: base(name, weight, livingRegion, breed) { }

		protected override Type[] PreferredFoods => new Type[] { typeof(Meat) };

		public override string MakeSound()
		{
			return "ROAR!!!";
		}
	}
}
