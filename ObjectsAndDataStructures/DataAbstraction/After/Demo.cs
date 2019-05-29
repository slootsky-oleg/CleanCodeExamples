using System;

namespace ObjectsAndDataStructures.DataAbstraction.After
{
	public class Demo
	{
		public void RunDemo()
		{
			var vehicle = InitVehicle();
			Console.WriteLine($"Starting. Fuel {vehicle.PercentFuelRemaining}%");	//100%

			vehicle.Drive(30);
			Console.WriteLine($"Starting. Fuel {vehicle.PercentFuelRemaining}%");	//100%

			vehicle.Drive(50);
			Console.WriteLine($"Starting. Fuel {vehicle.PercentFuelRemaining}%");	//100%
		}


		private IVehicle InitVehicle()
		{
			var tankCapacity = FuelVolume.From(40);
			var remainingFuel = FuelVolume.From(40);

			return new Vehicle(tankCapacity, remainingFuel);
		}
	}
}