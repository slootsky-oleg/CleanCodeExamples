namespace General.BaseClassDependsOnDerivatives
{
	public class Customer
	{
		public CustomerStatus Status { get; }

		public bool IsAdvanced =>
			Status == CustomerStatus.Advanced;

		public Customer(CustomerStatus status)
		{
			Status = status;
		}
	}
}