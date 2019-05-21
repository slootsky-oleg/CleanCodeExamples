using System;

namespace Functions.FunctionArguments._3_AfterSwitchToPolymorphism.Demo
{
	public class Demo
	{
		public void RunDemo()
		{
			var movieFactory = new MovieFactory();

			var twoDaysMovie = movieFactory.Create(LicensingModel.TwoDays, DateTime.Now);
			var expirationDate = twoDaysMovie.ExpirationDate;

			var lifeLongMovie = movieFactory.Create(LicensingModel.LifeLong, DateTime.Now);
			var price = lifeLongMovie.CalculatePrice(CustomerStatus.Advanced);
		}
	}
}