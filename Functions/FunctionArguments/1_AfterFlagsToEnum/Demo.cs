using System;

namespace Functions.FunctionArguments._1_AfterFlagsToEnum
{
	public class Demo
	{
		public void RunDemo()
		{
			var movieService = new MovieService();

			var tomorrow = DateTime.Now.AddDays(1);

			var expirationDate = movieService.GetMovieExpirationDate(LicensingModel.TwoDays, tomorrow);
			var price = movieService.GetMoviePrice(LicensingModel.LifeLong, CustomerStatus.Advanced, tomorrow);
		}
	}
}