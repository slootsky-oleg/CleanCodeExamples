using System.Collections.Generic;
using System.Linq;
using ObjectsAndStructures.Test.Answers.Auction.OOP.Exceptions;

namespace ObjectsAndStructures.Test.Answers.Auction.OOP
{
	public class Auction
	{
		private readonly Money minBidAmount;
		private readonly IList<Bid> bids;

		public bool IsActive { get; private set; }
		public Bid HighestBid { get; private set; }
		public IReadOnlyList<Bid> Bids => bids.ToList();

		public Bid WinningBid
		{
			get
			{
				if (IsActive)
					throw new AuctionWinnerNotDeterminedException();

				return HighestBid;
			}
		}


		public Auction(Money minBidAmount)
		{
			this.minBidAmount = minBidAmount;

			this.bids = new List<Bid>();
			this.IsActive = true;
		}


		public void PlaceBid(Bid bid)
		{
			if (!IsActive)
				throw new PlacingBidException(bid, "Auction is closed.");

			var minAllowedAmount = HighestBid?.Amount ?? minBidAmount;
			if (bid.Amount <= minAllowedAmount)
				throw new PlacingBidException(bid, minAllowedAmount);

			HighestBid = bid;
			bids.Add(bid);
		}

		public void Close()
		{
			if (!IsActive)
				throw new ClosingAuctionException("Auction is already closed.");

			IsActive = false;
		}
	}
}