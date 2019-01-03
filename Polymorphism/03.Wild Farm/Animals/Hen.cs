using _03.Wild_Farm.Animals.Animal_Type;


namespace _03.Wild_Farm.Animals
{
	class Hen : Bird
	{
		public Hen(string name, double weight, double wingSize)
			: base(name, weight, wingSize) { }

		protected override double WeightIncreaseMultiplier => 0.35;

		public override string MakeSound()
		{
			return "Cluck";
		}
	}
}
