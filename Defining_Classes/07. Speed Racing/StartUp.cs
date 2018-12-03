using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Speed_Racing
{
	class StartUp
	{
	    private static object cars;

		public static void Main()
		{
			Queue<Car> cars = GetCars();
			DriveCars(cars);
			PrintCars(cars);
		}

		private static void PrintCars(Queue<Car> cars)
		{
			Console.WriteLine(string.Join(Environment.NewLine, cars
				.Select(c => $"{c.Model} {c.FuelAmount:F2} {c.DistanceTravelled}")));
		}

		private static void DriveCars(Queue<Car> cars)
		{
			string[] command = Console.ReadLine().Split();

			while (command[0] != "End")
			{
				Car currentCar = cars.Where(c => c.Model == command[1]).FirstOrDefault();

				if (currentCar != null)
				{
					currentCar.Drive(double.Parse(command[2]));
				}

				command = Console.ReadLine().Split();
			}
		}

		private static Queue<Car> GetCars()
		{
			Queue<Car> cars = new Queue<Car>();
			int numberOfCars = int.Parse(Console.ReadLine());

			while (cars.Count < numberOfCars)
			{
				string[] input = Console.ReadLine().Split();
				cars.Enqueue(new Car(input[0], double.Parse(input[1]), double.Parse(input[2])));
			}

			return cars;
		}
	}
}

