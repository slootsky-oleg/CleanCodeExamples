using System;

namespace ObjectsAndDataStructures.DataAbstraction.Before
{
	public class Demo
	{
		public void RunDemo()
		{
			var vehicle = InitVehicle();
			var percentFuelRemaining = vehicle.RemainingFuel / vehicle.TankCapacity * 100;
			Console.WriteLine($"Starting. Fuel {percentFuelRemaining}%");	//100%

			Drive(vehicle, 30);
			percentFuelRemaining = vehicle.TankCapacity / vehicle.RemainingFuel * 100;	//What!?
			Console.WriteLine($"Driving. Fuel {percentFuelRemaining}%");


			vehicle.TankCapacity = 140;	//What?!

			Drive(vehicle, 50);
			percentFuelRemaining = vehicle.TankCapacity / vehicle.RemainingFuel * 100;	//What!?
			Console.WriteLine($"Driving. Fuel {percentFuelRemaining}%");
		}


		private Vehicle InitVehicle()
		{
			var vehicle = new Vehicle();
			vehicle.TankCapacity = 40;	//What if TankCapacity = 5?
			vehicle.RemainingFuel = 40;

			return vehicle;
		}


		private void Drive(Vehicle vehicle, double distance)
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