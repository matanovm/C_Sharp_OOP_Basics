using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Car_Salesman
{
	public class CarSalesman
	{
		static void Main(string[] args)
		{
			int count = int.Parse(Console.ReadLine());
			List<Engine> engines = new List<Engine>();
			List<Car> cars = new List<Car>();

			for (int i = 0; i < count; i++)
			{
				string[] parameter = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
				string model = parameter[0];
				int power = int.Parse(parameter[1]);

				if (parameter.Length == 2)
				{
					engines.Add(new Engine(model, power));
				}
				else if (parameter.Length == 3)
				{
					if (parameter[2].All(Char.IsDigit))
					{
						int displacement = int.Parse(parameter[2]);
						engines.Add(new Engine(model, power, displacement));
					}
					else
					{
						string efficiency = parameter[2];
						engines.Add(new Engine(model, power, efficiency));
					}
				}
				else if (parameter.Length == 4)
				{
					int displacement = int.Parse(parameter[2]);
					string efficiency = parameter[3];

					engines.Add(new Engine(model, power, displacement, efficiency));
				}
			}

			count = int.Parse(Console.ReadLine());

			for (int i = 0; i < count; i++)
			{
				string[] parameters = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

				string model = parameters[0];
				Engine engine = engines.First(e => e.Model == parameters[1]);

				if (parameters.Length == 2)
				{
					cars.Add(new Car(model, engine));
				}
				else if (parameters.Length == 3)
				{
					if (parameters[2].All(Char.IsDigit))
					{
						int weight = int.Parse(parameters[2]);

						cars.Add(new Car(model, engine, weight));
					}
					else
					{
						string color = parameters[2];

						cars.Add(new Car(model, engine, color));
					}
				}
				else if (parameters.Length == 4)
				{
					int weight = int.Parse(parameters[2]);
					string color = parameters[3];

					cars.Add(new Car(model, engine, weight, color));
				}
			}

			cars.ForEach(Console.WriteLine);
		}
	}
}

