﻿using _02_Vehicle_Extension.Vehicle_Type;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Vehicle_Extension
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Vehicle> vehicleList = new List<Vehicle>();

			for (int i = 0; i < 3; i++)
			{
				string[] vehicleData = Console.ReadLine().Split(' ');

				switch (vehicleData[0])
				{
					case "Car":
						vehicleList.Add(new Car(double.Parse(vehicleData[1]), double.Parse(vehicleData[2]), double.Parse(vehicleData[3])));
						break;
					case "Truck":
						vehicleList.Add(new Truck(double.Parse(vehicleData[1]), double.Parse(vehicleData[2]), double.Parse(vehicleData[3])));
						break;
					case "Bus":
						vehicleList.Add(new Bus(double.Parse(vehicleData[1]), double.Parse(vehicleData[2]), double.Parse(vehicleData[3])));
						break;
				}
			}

			int actionsCount = int.Parse(Console.ReadLine());

			for (int i = 0; i < actionsCount; i++)
			{
				string[] actionData = Console.ReadLine().Split(' ');

				switch (actionData[0])
				{
					case "Drive":
						DriveVehicle(vehicleList.First(v => v.GetType().Name == actionData[1]), double.Parse(actionData[2]), actionData[0]);
						break;
					case "Refuel":
						var vehicle = vehicleList.First(v => v.GetType().Name == actionData[1]);
						try
						{
							vehicle.Refuel(double.Parse(actionData[2]));
						}
						catch (ArgumentException exception)
						{
							Console.WriteLine(exception.Message);
						}
						break;
					case "DriveEmpty":
						DriveVehicle(vehicleList.First(v => v.GetType().Name == actionData[1]), double.Parse(actionData[2]), actionData[0]);
						break;
				}
			}

			Vehicle car = vehicleList.First(v => v.GetType().Name == "Car");
			Vehicle truck = vehicleList.First(v => v.GetType().Name == "Truck");
			Vehicle bus = vehicleList.First(v => v.GetType().Name == "Bus");

			Console.WriteLine($"Car: {car.GetFuelAmount():f2}");
			Console.WriteLine($"Truck: {truck.GetFuelAmount():f2}");
			Console.WriteLine($"Bus: {bus.GetFuelAmount():f2}");

		}

		public static void DriveVehicle(Vehicle vehicle, double distance, string driveCondition)
		{
			try
			{
				if (driveCondition == "Drive")
				{
					vehicle.Drive(distance);
				}
				else if (driveCondition == "DriveEmpty")
				{
					vehicle.DriveEmpty(distance);
				}
				Console.WriteLine($"{vehicle.GetType().Name} travelled {distance} km");
			}
			catch (ArgumentException exception)
			{
				Console.WriteLine(exception.Message);
			}
		}
	}
}

