using System;
using ObjectsAndDataStructures.DataAbstraction.HideDetails.Values;

namespace ObjectsAndDataStructures.DataAbstraction.HideDetails
{
	public class Demo
	{
		public void RunDemo()
		{
			var tankCapacity = FuelVolume.From(40);
			var remainingFuel = FuelVolume.From(40);
			IVehicle car = new Car(tankCapacity, remainingFuel);
			Console.WriteLine($"Starting. Fuel {car.PercentFuelRemaining}%");

			car.Drive(30);
			Console.WriteLine($"Starting. Fuel {car.PercentFuelRemaining}%");

			car.Drive(50);
			Console.WriteLine($"Starting. Fuel {car.PercentFuelRemaining}%");
		}
	}
}