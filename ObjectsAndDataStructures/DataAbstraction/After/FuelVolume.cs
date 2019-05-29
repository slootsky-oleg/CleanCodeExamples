using System;

namespace ObjectsAndDataStructures.DataAbstraction.After
{
	public class FuelVolume
	{
		private double Value { get; }

		private FuelVolume(double value)
		{
			if (value < 0)
				throw new ArgumentException($"Invalid volume {value}");

			Value = value;
		}

		public static FuelVolume From(double value)
		{
			return new FuelVolume(value);
		}


		public static implicit operator double(FuelVolume me)
		{
			return me.Value;
		}

		public static FuelVolume operator - (FuelVolume me, FuelVolume other)
		{
			var newValue  = me.Value - other.Value;
			return new FuelVolume(newValue);
		}
	}
}