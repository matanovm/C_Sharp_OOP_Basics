using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Raw_Data
{
	public class StartUp
	{
		public static void Main()
		{
		Queue<Car> cars = GetCars();
			PrintCars(cars);
		}

		private static void PrintCars(Queue<Car> cars)
		{
			string command = Console.ReadLine();

			Console.WriteLine(string.Join(Environment.NewLine, cars
						.Where(c => c.Cargo.Type == command && command == "fragile"
							? c.Tires
								.Where(t => t.Pressure < 1)
								.FirstOrDefault() != null
							: c.Engine.Power > 250)
						.Select(c => c.Model)));
		}

		private static Queue<Car> GetCars()
		{
			Queue<Car> cars = new Queue<Car>();
			int numberOfCars = int.Parse(Console.ReadLine());

			while (cars.Count < numberOfCars)
			{
				string[] input = Console.ReadLine().Split();
				
				 //“<Model> <EngineSpeed> <EnginePower> <CargoWeight> <CargoType> <Tire1Pressure> <Tire1Age> <Tire2Pressure> <Tire2Age> <Tire3Pressure> <Tire3Age> <Tire4Pressure> <Tire4Age>” 
				 
				Engine engine = new Engine(int.Parse(input[1]), int.Parse(input[2]));
				Cargo cargo = new Cargo(int.Parse(input[3]), input[4]);
				Tire[] tires = new Tire[]
				{
					new Tire(int.Parse(input[6]), double.Parse(input[5])),
					new Tire(int.Parse(input[8]), double.Parse(input[7])),
					new Tire(int.Parse(input[10]), double.Parse(input[9])),
					new Tire(int.Parse(input[12]), double.Parse(input[11])),
				};

				cars.Enqueue(new Car(input[0], engine, cargo, tires));
			}

			return cars;
		}
	}
}

