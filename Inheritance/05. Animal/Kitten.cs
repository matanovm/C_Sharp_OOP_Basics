using _6.Animals;


namespace _05.Animals
{
	public class Kitten : Animal
	{
		public Kitten(string name, int age)
		: base(name, age, "Female") { }

		public override string ProduceSound()
		{
			return "Meow";
		}
	}
}
