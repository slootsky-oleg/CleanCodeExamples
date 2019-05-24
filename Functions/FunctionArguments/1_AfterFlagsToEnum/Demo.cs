using System;

namespace Functions.FunctionArguments._1_AfterFlagsToEnum
{
	public class Demo
	{
		public void RunDemo()
		{
			var movieService = new MovieService();

			var purchased = DateTime.Now.AddDays(1);

			var expirationDate = movieService.GetMovieExpirationDate(LicensingModel.TwoDays, purchased);
			var price = movieService.GetMoviePrice(LicensingModel.LifeLong, CustomerStatus.Advanced, purchased);
		}
	}
}