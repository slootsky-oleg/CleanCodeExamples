using System;

namespace ObjectsAndStructures.Test.Answers.Auction.OOP
{
	public class Demo
	{
		public void Run()
		{
			var minBidAmount = Money.From(100);

			var auction = new Auction(minBidAmount);

			var bid1 = new Bid(Money.From(150));
			auction.PlaceBid(bid1);

			var bid2 = new Bid(Money.From(140));
			auction.PlaceBid(bid2);

			auction.Close();

			var bid3 = new Bid(Money.From(540));
			//Exception - auction is closed
			auction.PlaceBid(bid3);

			var lastBid = auction.WinningBid;
			if (lastBid is null)
			{
				Console.WriteLine($"No winner is determined.");
			}
			else
			{
				Console.WriteLine($"The winning bid is {lastBid.Amount}.");
			}
		}
	}
}