using System;
using ObjectsAndDataStructures.DataAbstraction.HideDetails.Values;

namespace ObjectsAndDataStructures.DataAbstraction.HideDetails
{
	public class Vehicle : IVehicle
	{
		private readonly Tank tank;

		public double PercentFuelRemaining => tank.RemainingPercent;

		public Vehicle(FuelVolume tankCapacity, FuelVolume fuelRemaining)
		{
			tank = new Tank(tankCapacity, fuelRemaining);
		}

		public void Drive(double distance)
		{
			var consumed = GetFuelConsumption(distance);
			tank.Consume(consumed);
		}

		private FuelVolume GetFuelConsumption(double distance)
		{
			throw new NotImplementedException();
		}
	}
}