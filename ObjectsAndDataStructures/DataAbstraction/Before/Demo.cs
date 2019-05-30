using System;

namespace ObjectsAndDataStructures.DataAbstraction.Before
{
	public class Demo
	{
		public void RunDemo()
		{
			var service = new DriveService();

			var vehicle = new Vehicle();
			vehicle.TankCapacity = 40;	//What if TankCapacity = 5?
			vehicle.RemainingFuel = 40;

			var percentFuelRemaining = vehicle.RemainingFuel / vehicle.TankCapacity * 100;
			Console.WriteLine($"Starting. Fuel {percentFuelRemaining}%");	//100%

			service.Drive(vehicle, 30);
			percentFuelRemaining = vehicle.TankCapacity / vehicle.RemainingFuel * 100;	//What!?
			Console.WriteLine($"Driving. Fuel {percentFuelRemaining}%");


			vehicle.TankCapacity = 140;	//What?!

			service.Drive(vehicle, 50);
			percentFuelRemaining = vehicle.TankCapacity / vehicle.RemainingFuel * 100;	//What!?
			Console.WriteLine($"Driving. Fuel {percentFuelRemaining}%");
		}
	}
}