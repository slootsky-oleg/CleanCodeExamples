using System;

namespace ObjectsAndStructures.Test.Answers.Auction.OOP
{
	public class Money
	{
		private readonly double value;

		private Money(double value)
		{
			if (value < 0)
				throw new ArgumentException($"Invalid value {value}");

			this.value = value;
		}

		public static Money From(double value)
		{
			return new Money(value);
		}


		public static implicit operator double(Money me)
		{
			return me.value;
		}

		public static Money operator -(Money me, Money other)
		{
			var newValue = me.value - other.value;
			return new Money(newValue);
		}

		public static Money operator +(Money me, Money other)
		{
			var newValue  = me.value + other.value;
			return new Money(newValue);
		}
	}
}