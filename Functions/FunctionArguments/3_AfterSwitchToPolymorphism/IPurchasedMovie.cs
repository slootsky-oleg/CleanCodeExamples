using System;

namespace Functions.FunctionArguments._3_AfterSwitchToPolymorphism
{
	public interface IPurchasedMovie
	{
		Customer Customer { get; }
		DateTime Purchased { get; }
		DateTime ExpirationDate { get; }
		decimal CalculatePrice();
	}
}