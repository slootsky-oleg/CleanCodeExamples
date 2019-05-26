using System;

namespace Functions.FunctionArguments._3_AfterSwitchToPolymorphism
{
	public abstract class BasePurchasedMovie : IPurchasedMovie
	{
		private bool NotExpired => ExpirationDate >= DateTime.UtcNow;

		public Customer Customer { get; }
		public DateTime Purchased { get; }


		protected BasePurchasedMovie(Customer customer, DateTime purchased)
		{
			Customer = customer;
			Purchased = purchased;
		}


		public abstract DateTime ExpirationDate { get; }

		public abstract decimal CalculatePrice();


		protected decimal CalculatePriceWithDiscount(decimal basePrice)
		{
			var hasDiscount = Customer.IsAdvanced && NotExpired;

			return hasDiscount
				? basePrice * 0.75m
				: basePrice;
		}
	}
}