using System.Collections.Generic;

namespace ObjectsAndStructures.Test.Answers.Auction.OOP
{
	public class AuctionController
	{
		public Auction Create(Money minAmount)
		{
			//Consider return AuctionDto for public API
			return new Auction(minAmount);
		}

		public Bid GetHighestBid(Auction auction)
		{
			//Consider return BidDto for public API
			return auction.HighestBid;
		}

		public IEnumerable<Bid> GetBids(Auction auction)
		{
			return auction.Bids;
		}

		public void PlaceBid(Auction auction, Bid bid)
		{
			auction.PlaceBid(bid);
		}

		public Bid Close(Auction auction)
		{
			auction.Close();

			return auction.WinningBid;
		}
	}
}