using System;

namespace Functions.FunctionArguments._2_AfterMoveToNatureOwner
{
	public class PurchasedMovie
	{
		public LicensingModel LicensingModel { get; }
		public DateTime Purchased { get; }
		public Customer Customer { get; }

		public PurchasedMovie(Customer customer, LicensingModel licensingModel, DateTime purchased)
		{
			Customer = customer;
			LicensingModel = licensingModel;
			Purchased = purchased;
		}

		public DateTime GetExpirationDate()
		{
			switch (LicensingModel)
			{
				case LicensingModel.TwoDays:
					return Purchased.AddDays(2);

				case LicensingModel.LifeLong:
					return DateTime.MaxValue;

				default:
					throw new ArgumentOutOfRangeException();
			}
		}

		public decimal GetPrice()
		{
			var expirationDate = GetExpirationDate();

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

			var hasDiscount = Customer.Status == CustomerStatus.Advanced
			                  && expirationDate >= DateTime.UtcNow;

			if (hasDiscount)
			{
				price = price * 0.75m;
			}

			return price;
		}
	}
}