using System;

namespace _02_Vehicle_Extension.Vehicle_Type
{
	public class Truck : Vehicle
	{
		public Truck(double fuelQuantity, double fuelConsumptionInLitersPerKm, double tankCapacity) : base(fuelQuantity,
		fuelConsumptionInLitersPerKm, tankCapacity)
		{
			this._fuelConsumptionInLitersPerKm += 1.6;
		}

		public override void Refuel(double litersAmount)
		{
			if (litersAmount <= 0)
			{
				throw new ArgumentException("Fuel must be a positive number");
			}
			if (FuelQuantity + litersAmount > _tankCapacity)
			{
				throw new ArgumentException($"Cannot fit {litersAmount} fuel in the tank");
			}
			this.FuelQuantity += litersAmount * 0.95;
		}

		public override void DriveEmpty(double distance)
		{

		}
	}
}
