﻿using System;

namespace ObjectsAndDataStructures.DemeterLawAndTellDontAsk.After
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
			catch (NotEnoughMoneyException e)
			{
				// come back later
				// log
			}
		}
	}
}