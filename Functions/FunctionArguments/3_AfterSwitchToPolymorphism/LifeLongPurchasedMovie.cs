using System;

namespace Functions.FunctionArguments._3_AfterSwitchToPolymorphism
{
	public class LifeLongPurchasedMovie : BasePurchasedMovie
	{
		private readonly decimal priceBeforeDiscount;
		public override DateTime ExpirationDate { get; }

		public LifeLongPurchasedMovie(Customer customer, DateTime purchased)
			: base(customer, purchased)
		{
			priceBeforeDiscount = 8;

			ExpirationDate = DateTime.MaxValue;
		}

		public override decimal CalculatePrice()
		{
			return CalculatePriceWithDiscount(priceBeforeDiscount);
		}
	}
}