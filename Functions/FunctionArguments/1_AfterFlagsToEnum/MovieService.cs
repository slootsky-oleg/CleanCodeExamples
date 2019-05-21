using System;

namespace Functions.FunctionArguments._1_AfterFlagsToEnum
{
	public class MovieService
	{
		public DateTime GetMovieExpirationDate(LicensingModel licensingModel, DateTime purchased)
		{
			DateTime result;

			switch (licensingModel)
			{
				case LicensingModel.TwoDays:
					result = purchased.AddDays(2);
					break;

				case LicensingModel.LifeLong:
					result = DateTime.MaxValue;
					break;

				default:
					throw new ArgumentOutOfRangeException();
			}

			return result;
		}

		public decimal GetMoviePrice(LicensingModel licensingModel, CustomerStatus status, DateTime expirationDate)
		{
			decimal price;
			switch (licensingModel)
			{
				case LicensingModel.TwoDays:
					price = 4;
					break;

				case LicensingModel.LifeLong:
					price = 8;
					break;

				default:
					throw new ArgumentOutOfRangeException();
			}

			if (
				status == CustomerStatus.Advanced
				&& expirationDate >= DateTime.UtcNow)
			{
				price = price * 0.75m;
			}

			return price;
		}
	}
}