using System;

namespace Functions.FunctionArguments._2_AfterMoveToNatureOwner
{
	public class Demo
	{
		public void RunDemo()
		{
			var customer = new Customer(CustomerStatus.Advanced);

			var movie = new PurchasedMovie(customer, LicensingModel.TwoDays, DateTime.Now);
			var expirationDate = movie.GetExpirationDate();
			var price = movie.GetPrice();
		}
	}
}