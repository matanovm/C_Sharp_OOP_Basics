
namespace _01.Define_a_Class_Person
{
	public class Person
	{
		private string name;
		private int age;
		string NameAndAge;

		private Person(string name, int age)
		{
			Name = name;
			Age = age;
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public int Age
		{
			get { return age; }
			set { age = value; }
		}

		public Person()
		{
			NameAndAge = name + age;
		}

		public string PrintNameAndAge()
		{
			return $"{this.name} {this.age}";
		}
	}
}
