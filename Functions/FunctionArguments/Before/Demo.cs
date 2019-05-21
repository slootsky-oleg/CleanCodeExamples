using System;

namespace Functions.FunctionArguments.Before
{
	public class Demo
	{
		public void RunDemo()
		{
			var movieService = new MovieService();

			var tomorrow = DateTime.Now.AddDays(1);

			var expirationDate = movieService.GetMovieExpirationDate(true, tomorrow);
			var price = movieService.GetMoviePrice(false, true, tomorrow);
		}
	}
}