using _6.Animals;


namespace _05.Animals
{
	public class Frog : Animal
	{

		public Frog(string name, int age, string gender)
			: base(name, age, gender) { }

		public override string ProduceSound()
		{
			return "Ribbit";
		}
	}
}
