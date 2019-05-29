using System;

namespace ObjectsAndDataStructures.DataAbstraction.After
{
	public class Tank
	{
		private FuelVolume remaining;

		public FuelVolume Capacity { get; }

		public double RemainingPercent => remaining / Capacity * 100;

		public Tank(FuelVolume capacity, FuelVolume remaining)
		{
			if (capacity < remaining)
				throw new InvalidOperationException($"Capacity {capacity} should be more than {remaining}");

			Capacity = capacity;
			this.remaining = remaining;
		}

		public void Consume(FuelVolume volume)
		{
			//Validation value < 0 is already implemented in the FuelVolume
			remaining = remaining - volume;
		}
	}
}