using System;

namespace Functions.FunctionArguments._1_AfterFlagsToEnum
{
	public class MovieService
	{
		public DateTime GetMovieExpirationDate(LicensingModel licensingModel, DateTime purchased)
		{
			switch (licensingModel)
			{
				case LicensingModel.TwoDays:
					return purchased.AddDays(2);

				case LicensingModel.LifeLong:
					return DateTime.MaxValue;

				default:
					throw new ArgumentOutOfRangeException();
			}
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