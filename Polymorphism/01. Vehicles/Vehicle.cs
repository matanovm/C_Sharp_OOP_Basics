﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Vehicles
{
	public abstract class Vehicle
	{
		private double _fuelQuantity;
		private double _fuelConsumption;

		protected Vehicle(double fuelQuantity, double fuelConsumption)
		{
			FuelQuantity = fuelQuantity;
			FuelConsumption = fuelConsumption;
		}

		public double FuelConsumption
		{
			get
			{
				return _fuelConsumption;
			}
			set
			{
				_fuelConsumption = value;
			}
		}

		public double FuelQuantity
		{
			get
			{
				return _fuelQuantity;
			}
			set
			{
				_fuelQuantity = value;
			}
		}

		public abstract void Drive(double distance);

		public abstract void Refuel(double liters);

		public override string ToString()
		{
			return $"{GetType().Name}: {FuelQuantity:F2}";
		}
	}
}
