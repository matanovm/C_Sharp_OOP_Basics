using System.Collections.Generic;
using System;
using System.Text;

namespace _01.Raw_Data
{
		public class Car
		{
			public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType, double tire1Pressure, int tire1Age, double tire2Pressure, int tire2Age, double tire3Pressure, int tire3age, double tire4Pressure, int tire4age)
			{
				this.model = model;
				this.engineSpeed = engineSpeed;
				this.enginePower = enginePower;
				this.cargoWeight = cargoWeight;
				this.cargoType = cargoType;
				this.tires = new Dictionary<double, int>[] { Dictionary.Create(tire1Pressure, tire1Age), Dictionary.Create(tire2Pressure, tire2Age), Dictionary.Create(tire3Pressure, tire3age), Dictionary.Create(tire4Pressure, tire4age) };
			}
			public string model;
			public int engineSpeed;
			public int enginePower;
			public int cargoWeight;
			public string cargoType;
			public Dictionary<double, int>[] tires;
		}

}

