namespace ObjectsAndDataStructures.DemeterLow.After
{
	public class Wallet
	{
		public Money Value { get; private set; }

		public Wallet(Money initialAmount)
		{
			Value = initialAmount;
		}

		public void Add(Money amount)
		{
			Value += amount;
		}
 
		public void Sub(Money amount)
		{
			if (!Has(amount))
				throw new NotEnoughMoneyException(amount);

			Value -= amount;
		}


		private bool Has(Money amount) => Value >= amount;
	}
}