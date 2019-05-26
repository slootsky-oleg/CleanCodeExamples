using System;

namespace Functions.FunctionArguments._3_AfterSwitchToPolymorphism.Demo
{
	public class Demo
	{
		public void RunDemo()
		{
			var movieFactory = new MovieFactory();

			var customer = new Customer(CustomerStatus.Advanced);
			var twoDaysMovie = movieFactory.Create(customer, LicensingModel.TwoDays, DateTime.Now);
			var expirationDate = twoDaysMovie.ExpirationDate;

			var lifeLongMovie = movieFactory.Create(customer, LicensingModel.LifeLong, DateTime.Now);
			var price = lifeLongMovie.CalculatePrice();
		}
	}
}