using System;

namespace ObjectsAndDataStructures.DataAndObjectAntiSymmetry.Procedural
{
	public class Demo
	{
		public void RunDemo()
		{
			var service = new DriveService();

			var vehicle = new Vehicle
			{
				TankCapacity = 40,
				RemainingFuel = 40
			};

			service.Drive(vehicle, 30);
			service.Drive(vehicle, 50);
			service.FillTank(vehicle,15);
		}
	}
}