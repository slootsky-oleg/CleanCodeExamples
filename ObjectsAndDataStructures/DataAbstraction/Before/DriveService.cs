using System;

namespace ObjectsAndDataStructures.DataAbstraction.Before
{
	public class DriveService
	{
		public Vehicle Create()
		{
			var vehicle = new Vehicle();
			vehicle.TankCapacity = 40;	//What if TankCapacity = 5?
			vehicle.RemainingFuel = 40;

			return vehicle;
		}


		public void Drive(Vehicle vehicle, double distance)
		{
			var consumedFuel = GetFuelConsumption(vehicle, distance);

			vehicle.RemainingFuel -= consumedFuel;
		}

		private double GetFuelConsumption(Vehicle vehicle, double distance)
		{
			throw new NotImplementedException();
		}
	}
}