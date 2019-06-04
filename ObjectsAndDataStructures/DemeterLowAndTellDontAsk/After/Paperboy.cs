using System;

namespace ObjectsAndDataStructures.DemeterLowAndTellDontAsk.After
{
	public class Paperboy
	{
		public void SellPaper(Customer customer)
		{
			var payment = Money.From(2.0d);
			try
			{
				customer.Pay(payment);
			}
			catch (Exception e)
			{
				// come back later
			}
		}
	}
}