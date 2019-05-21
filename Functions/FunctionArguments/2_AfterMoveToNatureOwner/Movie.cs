using System;

namespace Functions.FunctionArguments._2_AfterMoveToNatureOwner
{
	public class Movie
	{
		public LicensingModel LicensingModel { get; }
		public DateTime Purchased { get; }

		public Movie(LicensingModel licensingModel, DateTime purchased)
		{
			LicensingModel = licensingModel;
			Purchased = purchased;
		}

		public DateTime GetExpirationDate()
		{
			DateTime result;

			switch (LicensingModel)
			{
				case LicensingModel.TwoDays:
					result = Purchased.AddDays(2);
					break;

				case LicensingModel.LifeLong:
					result = DateTime.MaxValue;
					break;

				default:
					throw new ArgumentOutOfRangeException();
			}

			return result;
		}

		public decimal GetPrice(CustomerStatus status)
		{
			var expirationDate = GetExpirationDate();
			var hasDiscount = status == CustomerStatus.Advanced
			                  && expirationDate >= DateTime.UtcNow;

			decimal price;
			switch (LicensingModel)
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

			if (hasDiscount)
			{
				price = price * 0.75m;
			}

			return price;
		}
	}
}