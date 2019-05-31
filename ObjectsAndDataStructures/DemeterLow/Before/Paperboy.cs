namespace ObjectsAndDataStructures.DemeterLow.Before
{
	public class Paperboy
	{
		public void SellPaper(Customer customer)
		{
			var payment = 2.0d;
			var wallet = customer.Wallet;

			//Also need to be checked
			//if (wallet != null)
			//if (wallet.Value > 0)
			//...

			if (wallet.Value >= payment)
			{
				wallet.SubMoney(payment);
			}
			else
			{
				// come back later
			}

			//Also possible
			//customer.Wallet = null;
		}
	}
}