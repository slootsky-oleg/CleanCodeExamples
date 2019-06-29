using System;

namespace ObjectsAndDataStructures.DataAndObjectAntiSymmetry.Procedural
{
	public class DriveService
	{
		public Vehicle Create()
		{
			var vehicle = new Vehicle();
			vehicle.TankCapacity = 40;
			vehicle.RemainingFuel = 40;

			return vehicle;
		}


		public void Drive(Vehicle vehicle, double distance)
		{
			var consumedFuel = GetFuelConsumption(vehicle, distance);

			//validate remaining - consumedFuel > 0
			vehicle.RemainingFuel -= consumedFuel;
		}

		public void FillTank(Vehicle vehicle, double volume)
		{
			//Validate Is not overfilled
			vehicle.RemainingFuel += volume;
		}

		private double GetFuelConsumption(Vehicle vehicle, double distance)
		{
			throw new NotImplementedException();
		}
	}
}