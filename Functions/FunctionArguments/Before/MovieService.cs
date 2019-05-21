using System;

namespace Functions.FunctionArguments.Before
{
	public class MovieService
	{
		public DateTime GetMovieExpirationDate(bool isTwoDaysMovie, DateTime purchased)
		{
			if (isTwoDaysMovie)
			{
				return purchased.AddDays(2);
			}
			else
			{
				// LifeLong movie
				return DateTime.MaxValue;
			}
		}

		public decimal GetMoviePrice(bool isTwoDaysMovie, bool isAdvancedCustomer, DateTime expirationDate)
		{
			decimal price;

			if (isTwoDaysMovie)
			{
				price = 4;
			}
			else
			{
				// LifeLong movie
				price = 8;
			}

			if (
				isAdvancedCustomer
				&& expirationDate >= DateTime.UtcNow)
			{
				price = price * 0.75m;
			}

			return price;
		}
	}
}