using System;

namespace Functions.FunctionArguments._3_AfterSwitchToPolymorphism
{
	public class TwoDaysMovie : BaseMovie
	{
		private readonly decimal priceBeforeDiscount;
		public override DateTime ExpirationDate { get; }

		public TwoDaysMovie(DateTime purchased)
			: base(purchased)
		{
			priceBeforeDiscount = 4;

			ExpirationDate = Purchased.AddDays(2);
		}

		public override decimal CalculatePrice(CustomerStatus status)
		{
			var discount = 1 - GetDiscount(status);

			return priceBeforeDiscount * discount;
		}
	}
}