using _6.Animals;


namespace _05.Animals
{
	public class Cat : Animal
	{
		public Cat(string name, int age, string gender)
			: base(name, age, gender) { }

		public override string ProduceSound()
		{
			return "Meow meow";
		}
	}
}
