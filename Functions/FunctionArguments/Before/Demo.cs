using System;

namespace Functions.FunctionArguments.Before
{
	public class Demo
	{
		public void RunDemo()
		{
			var movieService = new MovieService();

			//From DB
			var purchased = DateTime.Now.AddDays(1);

			var expirationDate = movieService.GetMovieExpirationDate(true, purchased);
			var price = movieService.GetMoviePrice(false, true, purchased);
		}
	}
}