using System;

namespace ObjectsAndStructures.Test.Answers.Auction.OOP.Exceptions
{
	public class ClosingAuctionException : Exception
	{
		public ClosingAuctionException(string message)
			: base(message)
		{
		}
	}
}