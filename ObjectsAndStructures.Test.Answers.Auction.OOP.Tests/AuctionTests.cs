using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;
using ObjectsAndStructures.Test.Answers.Auction.OOP;
using ObjectsAndStructures.Test.Answers.Auction.OOP.Exceptions;

namespace Tests
{
	public class AuctionTests
	{
		[Test]
		public void NewAuction_ShouldBeActive()
		{
			var auction = CreateAuction(1);

			auction.IsActive.Should().BeTrue();
		}

		[Test]
		public void NewAuction_BidsShouldBeEmpty()
		{
			var auction = CreateAuction(1);

			auction.Bids.Should().BeEmpty();
		}

		[Test]
		public void PlaceBid_WhenBidLessThanMinBid_ThrowError()
		{
			var auction = CreateAuction(10);
			var bid = new Bid(Money.From(5));

			Action act = () => { auction.PlaceBid(bid); };

			act.Should().ThrowExactly<PlacingBidException>();
		}

		[Test]
		public void PlaceBid_WhenBidLessThanHighestBid_ThrowError()
		{
			var auction = CreateAuction(1);

			var highestBid = new Bid(Money.From(50));
			auction.PlaceBid(highestBid);

			var bid = new Bid(Money.From(30));
			Action act = () => { auction.PlaceBid(bid); };

			act.Should().ThrowExactly<PlacingBidException>();
		}

		[Test]
		public void PlaceBid_WhenBidLargerThanMinBid_ShouldUpdateBids()
		{
			var auction = CreateAuction(10);

			var bid = new Bid(Money.From(50));
			auction.PlaceBid(bid);


			auction.HighestBid.Should().Be(bid);
			auction.Bids.Count.Should().Be(1);
			auction.Bids.Any(x => x == bid).Should().BeTrue();
		}

		[Test]
		public void PlaceBid_WhenBidLargerThanHighestBid_ShouldUpdateBids()
		{
			var auction = CreateAuction(10);

			var bids = new List<Bid>
			{
				new Bid(Money.From(50)),
				new Bid(Money.From(70))
			};
			bids.ForEach(bid => auction.PlaceBid(bid));

			auction.HighestBid.Should().Be(bids[1]);
			auction.Bids.Should().BeEquivalentTo(bids, options => options.WithStrictOrdering());
		}

		[Test]
		public void PlaceBid_WhenNotActive_ThrowError()
		{
			var auction = CreateAuction(1);
			auction.Close();

			var bid = new Bid(Money.From(5));
			Action act = () => { auction.PlaceBid(bid); };

			act.Should().ThrowExactly<PlacingBidException>();
		}

		[Test]
		public void Close_WhenIsActive_ShouldSetIsActiveToFalse()
		{
			var auction = CreateAuction(1);

			auction.Close();

			auction.IsActive.Should().BeFalse();
		}

		[Test]
		public void Close_WhenNotActive_ThrowError()
		{
			var auction = CreateAuction(1);
			auction.Close();

			Action act = () => { auction.Close(); };

			act.Should().ThrowExactly<ClosingAuctionException>();
		}

		[Test]
		public void WinningBid_WhenIsClosedAndHasWinner_ReturnHighestBid()
		{
			var auction = CreateAuction(1);

			var bid = new Bid(Money.From(70));
			auction.PlaceBid(bid);


			auction.Close();

			auction.WinningBid.Should().Be(bid);
		}

		[Test]
		public void WinningBid_WhenIsActive_ThrowError()
		{
			var auction = CreateAuction(1);

			Func<Bid> act = () => auction.WinningBid;

			act.Should().ThrowExactly<AuctionWinnerNotDeterminedException>();
		}

		[Test]
		public void WinningBid_WhenIsClosedAndHasNoWinner_ReturnNull()
		{
			var auction = CreateAuction(1);

			auction.Close();

			auction.WinningBid.Should().BeNull();
		}

		private static Auction CreateAuction(double minAmount)
		{
			var money = Money.From(minAmount);
			return new Auction(money);
		}
	}
}