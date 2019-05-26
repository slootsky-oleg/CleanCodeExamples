using System;

namespace Functions.FunctionArguments._3_AfterSwitchToPolymorphism
{
	public class TwoDaysPurchasedMovie : BasePurchasedMovie
	{
		private readonly decimal priceBeforeDiscount;
		public override DateTime ExpirationDate { get; }

		public TwoDaysPurchasedMovie(Customer customer, DateTime purchased)
			: base(customer, purchased)
		{
			priceBeforeDiscount = 4;

			ExpirationDate = Purchased.AddDays(2);
		}

		public override decimal CalculatePrice()
		{
			return CalculatePriceWithDiscount(priceBeforeDiscount);
		}
	}
}