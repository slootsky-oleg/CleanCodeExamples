using System;

namespace ObjectsAndDataStructures.DataAndObjectAntiSymmetry.OO.Values
{
	public class FuelVolume
	{
		private readonly double value;

		private FuelVolume(double value)
		{
			if (value < 0)
				throw new ArgumentException($"Invalid volume {value}");

			this.value = value;
		}

		public static FuelVolume From(double value)
		{
			return new FuelVolume(value);
		}


		public static implicit operator double(FuelVolume me)
		{
			return me.value;
		}

		public static FuelVolume operator - (FuelVolume me, FuelVolume other)
		{
			var newValue  = me.value - other.value;
			return new FuelVolume(newValue);
		}
	}
}