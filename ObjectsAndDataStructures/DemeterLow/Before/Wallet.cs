namespace ObjectsAndDataStructures.DemeterLow.Before
{
	public class Wallet
	{
		public double Value { get; set; }
 
		public void AddMoney(double amount)
		{
			Value += amount;
		}
 
		public void SubMoney(double amount)
		{
			Value -= amount;
		}
	}
}