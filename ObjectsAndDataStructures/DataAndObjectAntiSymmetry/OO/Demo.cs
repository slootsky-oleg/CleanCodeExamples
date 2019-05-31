using System;
using ObjectsAndDataStructures.DataAndObjectAntiSymmetry.OO.Values;

namespace ObjectsAndDataStructures.DataAndObjectAntiSymmetry.OO
{
	public class Demo
	{
		public void RunDemo()
		{
			var vehicle = InitVehicle();
			vehicle.Drive(30);
			vehicle.Drive(50);

			//Impossible to overfill due to the Vehicle hidden logic
			vehicle.FillTank(FuelVolume.From(15));
		}


		private IVehicle InitVehicle()
		{
			var tankCapacity = FuelVolume.From(40);
			var remainingFuel = FuelVolume.From(40);

			return new Car(tankCapacity, remainingFuel);
		}
	}
}