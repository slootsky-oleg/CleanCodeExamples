namespace ObjectsAndStructures.Test.Answers.Auction.OOP
{
	public class Bid
	{
		//public Bidder Bidder { get; }
		public Money Amount { get; }

		public Bid(Money amount)
		{
			Amount = amount;
		}
	}
}