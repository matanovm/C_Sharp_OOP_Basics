﻿namespace _03.Ferrari
{
	public interface ICar
	{
		string Model { get; }

		string DriverName { get; }

		string ApplyBrakes();

		string PushGasPedal();
	}
}
