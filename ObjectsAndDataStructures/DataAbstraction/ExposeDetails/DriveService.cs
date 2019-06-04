using System;

namespace ObjectsAndDataStructures.DataAbstraction.ExposeDetails
{
	public class DriveService
	{
		public Vehicle Create()
		{
			var vehicle = new Vehicle();
			vehicle.TankCapacity = 40;	//What if  we put TankCapacity = 5?
			vehicle.RemainingFuel = 40;

			return vehicle;
		}


		public void Drive(Vehicle vehicle, double distance)
		{
			var consumedFuel = GetFuelConsumption(vehicle, distance);

			//validate remaining - consumedFuel > 0
			vehicle.RemainingFuel -= consumedFuel;
		}

		private double GetFuelConsumption(Vehicle vehicle, double distance)
		{
			throw new NotImplementedException();
		}
	}
}