using System;

namespace Functions.FunctionArguments._3_AfterSwitchToPolymorphism
{
	public abstract class BaseMovie : IMovie
	{
		public DateTime Purchased { get; }
		public abstract DateTime ExpirationDate { get; }

		protected BaseMovie(DateTime purchased)
		{
			Purchased = purchased;
		}

		public abstract decimal CalculatePrice(CustomerStatus status);

		protected virtual decimal GetDiscount(CustomerStatus status)
		{
			var hasDiscount = status == CustomerStatus.Advanced
			                  && ExpirationDate >= DateTime.UtcNow;

			return hasDiscount ? 0.25m : 0m;
		}
	}
}