using System;
using ObjectsAndDataStructures.DataAbstraction.HideDetails.Values;

namespace ObjectsAndDataStructures.DataAbstraction.HideDetails
{
	public class Car : IVehicle
	{
		private readonly Tank tank;

		public double PercentFuelRemaining => tank.RemainingPercent;

		public Car(FuelVolume tankCapacity, FuelVolume fuelRemaining)
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