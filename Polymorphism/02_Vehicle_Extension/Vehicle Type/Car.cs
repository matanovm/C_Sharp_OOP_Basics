namespace _02_Vehicle_Extension.Vehicle_Type
{
	public class Car : Vehicle
	{
		public Car(double fuelQuantity, double fuelConsumptionInLitersPerKm, double tankCapacity) : base(fuelQuantity,
	   fuelConsumptionInLitersPerKm, tankCapacity)
		{
			this._fuelConsumptionInLitersPerKm += 0.9;
		}

		public override void DriveEmpty(double distance)
		{

		}
	}
}
