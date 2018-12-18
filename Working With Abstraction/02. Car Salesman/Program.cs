﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Car_Salesman
{
	public class CarSalesman
	{
		static void Main(string[] args)
		{
			List<Car> cars = new List<Car>();
			List<Engine> engines = new List<Engine>();
			int engineCount = int.Parse(Console.ReadLine());

			for (int i = 0; i < engineCount; i++)
			{
				string input = Console.ReadLine();
				string[] parameters = input.Split(' ');

				string model = parameters[0];
				int power = int.Parse(parameters[1]);
				int displacement = -1;
				bool parseparameters = int.TryParse(parameters[2], out displacement);

				if (parameters.Length == 3 && parseparameters)
				{
					engines.Add(new Engine(model, power, displacement));
				}
				else if (parameters.Length == 3)
				{
					string efficiency = parameters[2];
					engines.Add(new Engine(model, power, efficiency));
				}
				else if (parameters.Length == 4)
				{
					string efficiency = parameters[3];
					engines.Add(new Engine(model, power, int.Parse(parameters[2]), efficiency));
				}
				else
				{
					engines.Add(new Engine(model, power));
				}
			}

			int carCount = int.Parse(Console.ReadLine());

			for (int i = 0; i < carCount; i++)
			{
				string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				string model = parameters[0];
				string engineModel = parameters[1];
				Engine engine = engines.FirstOrDefault(x => x._model == engineModel);
				int weight = -1;
				bool parameter = int.TryParse(parameters[2], out weight);

				if (parameters.Length == 3 && parameter)
				{
					cars.Add(new Car(model, engine, weight));
				}
				else if (parameters.Length == 3)
				{
					string color = parameters[2];
					cars.Add(new Car(model, engine, color));
				}
				else if (parameters.Length == 4)
				{
					string color = parameters[3];
					cars.Add(new Car(model, engine, int.Parse(parameters[2]), color));
				}
				else
				{
					cars.Add(new Car(model, engine));
				}
			}

			foreach (Car car in cars)
			{
				Console.WriteLine(car);
			}
		}

	}
}
