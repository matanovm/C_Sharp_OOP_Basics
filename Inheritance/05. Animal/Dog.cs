using _6.Animals;


namespace _05.Animals
{
	public class Dog : Animal
	{

		public Dog(string name, int age, string gender)
			: base(name, age, gender) { }

		public override string ProduceSound()
		{
			return "Woof!";
		}
	}
}
