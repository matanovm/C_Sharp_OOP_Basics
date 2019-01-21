using System;

namespace _02_Vehicle_Extension
{
	public abstract class Vehicle
	{
		protected double _fuelQuantity { get; set; }
		protected double _fuelConsumptionInLitersPerKm { get; set; }
		protected double _tankCapacity { get; }

		protected Vehicle(double fuelQuantity, double fuelConsumptionInLitersPerKm, double tankCapacity)
		{
			if (fuelQuantity <= tankCapacity)
			{
				this._fuelQuantity = fuelQuantity;
			}
			this._fuelConsumptionInLitersPerKm = fuelConsumptionInLitersPerKm;
			this._tankCapacity = tankCapacity;
		}

		public void Drive(double distance)
		{
			if (this._fuelQuantity > distance * _fuelConsumptionInLitersPerKm)
			{
				this._fuelQuantity -= distance * _fuelConsumptionInLitersPerKm;
			}
			else
			{
				throw new ArgumentException($"{this.GetType().Name} needs refueling");
			}
		}

		public virtual void Refuel(double litersAmount)
		{
			if (litersAmount <= 0)
			{
				throw new ArgumentException("Fuel must be a positive number");
			}
			if (_fuelQuantity + litersAmount > _tankCapacity)
			{
				throw new ArgumentException($"Cannot fit {litersAmount} fuel in the tank");
			}
			this._fuelQuantity += litersAmount;
		}

		public abstract void DriveEmpty(double distance);

		public double GetFuelAmount()
		{
			return this._fuelQuantity;
		}

	}
}
