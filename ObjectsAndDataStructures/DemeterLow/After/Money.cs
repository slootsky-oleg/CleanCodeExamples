using System;

namespace ObjectsAndDataStructures.DemeterLow.After
{
	public class Money
	{
		private double Value { get; }

		private Money(double value)
		{
			if (value < 0)
				throw new ArgumentException($"Invalid value {value}");

			Value = value;
		}

		public static Money From(double value)
		{
			return new Money(value);
		}


		public static implicit operator double(Money me)
		{
			return me.Value;
		}

		public static Money operator - (Money me, Money other)
		{
			var newValue  = me.Value - other.Value;
			return new Money(newValue);
		}
		public static Money operator + (Money me, Money other)
		{
			var newValue  = me.Value + other.Value;
			return new Money(newValue);
		}
	}
}