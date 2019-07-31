using System;

namespace General.BaseClassDependsOnDerivatives
{
	public interface IPurchasedMovie
	{
		DateTime ExpirationDate { get; }
		decimal Price { get; }
	}
}