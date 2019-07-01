using System;

namespace ObjectsAndDataStructures.DataAndObjectAntiSymmetry.OO.Values
{
	public class Tank
	{
		private readonly FuelVolume capacity;
		private FuelVolume remaining;

		public double RemainingPercent =>
			remaining / capacity * 100;


		public Tank(FuelVolume capacity, FuelVolume remaining)
		{
			if (capacity < remaining)
				throw new InvalidOperationException($"Capacity {capacity} should be more than {remaining}");

			this.capacity = capacity;
			this.remaining = remaining;
		}

		public void Consume(FuelVolume volume)
		{
			//Validation value < 0 is already implemented in the FuelVolume
			remaining = remaining - volume;
		}

		public void Fill(FuelVolume volume)
		{
			var newVolume = remaining + volume;
			if (capacity < newVolume)
				throw new InvalidOperationException($"Not enough capacity");

			remaining = FuelVolume.From(newVolume);
		}
	}
}