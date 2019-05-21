using System;

namespace Functions.FunctionArguments._3_AfterSwitchToPolymorphism
{
	public interface IMovie
	{
		DateTime Purchased { get; }
		DateTime ExpirationDate { get; }
		decimal CalculatePrice(CustomerStatus status);
	}
}