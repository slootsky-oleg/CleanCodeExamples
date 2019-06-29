using System;
using ObjectsAndDataStructures.DataAndObjectAntiSymmetry.OO.Values;

namespace ObjectsAndDataStructures.DataAndObjectAntiSymmetry.OO
{
	public class Demo
	{
		public void RunDemo()
		{
			var tankCapacity = FuelVolume.From(40);
			var remainingFuel = FuelVolume.From(40);
			IVehicle car = new Car(tankCapacity, remainingFuel);

			car.Drive(30);
			car.Drive(50);

			//Impossible to overfill due to the Vehicle hidden logic
			car.FillTank(FuelVolume.From(15));
		}
	}
}