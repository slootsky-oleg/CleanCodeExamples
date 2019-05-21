using System;

namespace Functions.FunctionArguments._3_AfterSwitchToPolymorphism
{
	public class LifeLongMovie : BaseMovie
	{
		private readonly decimal priceBeforeDiscount;
		public override DateTime ExpirationDate { get; }

		public LifeLongMovie(DateTime purchased)
			: base(purchased)
		{
			priceBeforeDiscount = 8;

			ExpirationDate = DateTime.MaxValue;
		}

		public override decimal CalculatePrice(CustomerStatus status)
		{
			var discount = 1 - GetDiscount(status);

			return priceBeforeDiscount * discount;
		}
	}
}