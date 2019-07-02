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


		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((Money) obj);
		}

		public override int GetHashCode()
		{
			return value.GetHashCode();
		}

		public static bool operator ==(Money left, Money right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(Money left, Money right)
		{
			return !Equals(left, right);
		}

		public static implicit operator double(Money me)
		{
			return me.value;
		}


		//public static bool operator <(Money first, Money second)
		//{
		//	return first < second;
		//}

		//public static bool operator >(Money first, Money second)
		//{
		//	return first > second;
		//}

		public static Money operator -(Money me, Money other)
		{
			var newValue = me.value - other.value;
			return new Money(newValue);
		}

		public static Money operator +(Money me, Money other)
		{
			var newValue = me.value + other.value;
			return new Money(newValue);
		}

		private bool Equals(Money other)
		{
			return value.Equals(other.value);
		}
	}
}