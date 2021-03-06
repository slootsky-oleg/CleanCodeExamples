﻿namespace ObjectsAndDataStructures.DemeterLawAndTellDontAsk.After
{
	public class Customer
	{
		private readonly Wallet wallet;

		public string FirstName { get; }
		public string LastName { get; }

		public Customer(string firstName, string lastName, Money money)
		{
			FirstName = firstName;
			LastName = lastName;
			wallet = new Wallet(money);
		}

		public void Pay(Money amount)
		{
			wallet.Sub(amount);
		}
	}
}