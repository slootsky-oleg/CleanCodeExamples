using System;

namespace Functions.FunctionArguments._3_AfterSwitchToPolymorphism.Demo
{
	public class MovieFactory
	{
		public IPurchasedMovie Create(Customer customer, LicensingModel licensingModel, DateTime purchased)
		{
			switch (licensingModel)
			{
				case LicensingModel.TwoDays:
					return new TwoDaysPurchasedMovie(customer, purchased);
				case LicensingModel.LifeLong:
					return new LifeLongPurchasedMovie(customer, purchased);
				default:
					throw new ArgumentOutOfRangeException(nameof(licensingModel), licensingModel, "Unknown licensing model");
			}
		}
	}
}