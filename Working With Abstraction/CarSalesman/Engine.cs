using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Car_Salesman
{
	public class Engine
	{
		private string model;
		private int _power;
		private int? _displacement;
		private string _efficiency;

		public Engine(string model, int power)
		{
			this.Model = model;
			this._power = power;
		}

		public Engine(string model, int power, int? displacement)
			: this(model, power)
		{
			this._displacement = displacement;
		}

		public Engine(string model, int power, string efficiency)
			: this(model, power)
		{
			this._efficiency = efficiency;
		}

		public Engine(string model, int power, int? displacement, string efficiency)
			: this(model, power)
		{
			this._displacement = displacement;
			this._efficiency = efficiency;
		}

		public string Model
		{
			get { return model; }
			private set { model = value; }
		}


		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.AppendLine($"  {Model}:");
			builder.AppendLine($"    Power: {_power}");
			builder.AppendLine($"    Displacement: {(_displacement == null ? "n/a" : _displacement.ToString())}");
			builder.AppendLine($"    Efficiency: {(_efficiency == null ? "n/a" : _efficiency.ToString())}");

			return builder.ToString();
		}
	}
}
