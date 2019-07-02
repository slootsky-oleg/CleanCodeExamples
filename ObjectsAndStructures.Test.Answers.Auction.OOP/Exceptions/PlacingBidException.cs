using System;

namespace ObjectsAndStructures.Test.Answers.Auction.OOP.Exceptions
{
	public class PlacingBidException : Exception
	{
		public Bid Bid { get; }

		public PlacingBidException(Bid bid, string message)
			: base(message)
		{
			Bid = bid;
		}

		public PlacingBidException(Bid bid, Money minAmount)
			: base($"Bid amount {bid.Amount} should be greater than {minAmount}.")
		{
			Bid = bid;
		}
	}
}