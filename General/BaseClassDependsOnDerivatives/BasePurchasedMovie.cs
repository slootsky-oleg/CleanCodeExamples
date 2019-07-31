using System;
using System.Linq.Expressions;

namespace General.BaseClassDependsOnDerivatives
{
	public abstract class BasePurchasedMovie
	{
		public DateTime Purchased { get;}

		public DateTime GetExpirationDate()
		{
			switch (this)
			{
				case LifeLongPurchasedMovie lifeLongPurchasedMovie:
					return DateTime.MaxValue;
				case TwoDaysPurchasedMovie twoDaysPurchasedMovie:
					return Purchased.AddDays(2);
				default:
					throw new InvalidOperationException($"Unknown movie type {this.GetType().Name}");
			}
		}

		public decimal GetPrice()
		{
			switch (this)
			{
				case LifeLongPurchasedMovie lifeLongPurchasedMovie:
					return 8;
				case TwoDaysPurchasedMovie twoDaysPurchasedMovie:
					return 4;
				default:
					throw new InvalidOperationException($"Unknown movie type {this.GetType().Name}");
			}
		}
	}
}