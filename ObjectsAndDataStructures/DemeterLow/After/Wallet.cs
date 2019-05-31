namespace ObjectsAndDataStructures.DemeterLow.After
{
	public class Wallet
	{
		public double Value { get; private set; }

		public Wallet(double initialAmount)
		{
			Value = initialAmount;
		}

		public void AddMoney(double amount)
		{
			Value += amount;
		}
 
		public void SubMoney(double amount)
		{
			Value -= amount;
		}
	}

	public class Customer
	{
		public string FirstName { get; }

		public string LastName { get; }

		private readonly Wallet wallet;

		public Customer(string firstName, string lastName, double walletAmmount
		{
			FirstName = firstName;
			LastName = lastName;
			wallet = new Wallet(20.0d); // amount set to 20 for example
		}

		public double PayAmount(double amountToPay)
		{
			if (wallet.Value >= amountToPay)
			{
				wallet.SubMoney(amountToPay);
				return amountToPay;
			}

			return 0;
		}
	}
 
	public class Paperboy
	{
		public void SellPaper(Customer customer)
		{
			var payment = 2.0d;
			var amountPaid = customer.PayAmount(payment);
			if (amountPaid != payment)
			{
				// come back later
			}
		}
	}}