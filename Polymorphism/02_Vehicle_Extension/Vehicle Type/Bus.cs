﻿using System;

namespace _02_Vehicle_Extension.Vehicle_Type
{
	public class Bus : Vehicle
	{
		public Bus(double fuelQuantity, double fuelConsumptionInLitersPerKm, double tankCapacity) : base(fuelQuantity,
		fuelConsumptionInLitersPerKm, tankCapacity)
		{
			this._fuelConsumptionInLitersPerKm += 1.4;
		}

		public override void DriveEmpty(double distance)
		{
			if (this.FuelQuantity > distance * (this._fuelConsumptionInLitersPerKm - 1.4))
			{
				this.FuelQuantity -= distance * (this._fuelConsumptionInLitersPerKm - 1.4);
			}
			else
			{
				throw new ArgumentException($"{this.GetType().Name} needs refueling");
			}
		}
	}
}
