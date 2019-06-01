using System;

namespace ObjectsAndDataStructures.DemeterLow.After
{
	public class NotEnoughMoneyException : Exception
	{
		public Money AmountToPay { get; }

		public NotEnoughMoneyException(Money amountToPay)
			: base($"Not enough money to pay {amountToPay}.")
		{
			AmountToPay = amountToPay;
		}
	}
}