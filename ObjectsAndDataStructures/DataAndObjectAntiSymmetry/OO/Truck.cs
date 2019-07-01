using System;
using ObjectsAndDataStructures.DataAndObjectAntiSymmetry.OO.Values;

namespace ObjectsAndDataStructures.DataAndObjectAntiSymmetry.OO
{
	public class Truck : IVehicle
	{
		private readonly Tank tank;

		public double PercentFuelRemaining => tank.RemainingPercent;

		public Truck(FuelVolume tankCapacity, FuelVolume fuelRemaining)
		{
			tank = new Tank(tankCapacity, fuelRemaining);
		}

		public void Drive(double distance)
		{
			var consumed = GetFuelConsumption(distance);
			tank.Consume(consumed);
		}

		public void FillTank(FuelVolume volume)
		{
			//ValidateFuelType();
			tank.Fill(volume);
		}

		private FuelVolume GetFuelConsumption(double distance)
		{
			throw new NotImplementedException();
		}
	}
}