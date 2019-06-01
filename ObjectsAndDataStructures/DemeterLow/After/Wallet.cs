namespace ObjectsAndDataStructures.DemeterLow.After
{
	public class Wallet
	{
		public Money Value { get; private set; }

		public Wallet(Money initialAmount)
		{
			Value = initialAmount;
		}

		public bool Has(Money amount) => Value >= amount;

		public void Add(Money amount)
		{
			Value += amount;
		}
 
		public void Sub(Money amount)
		{
			Value -= amount;
		}
	}
}