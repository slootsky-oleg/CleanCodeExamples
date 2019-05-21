using System;

namespace Functions.FunctionArguments._3_AfterSwitchToPolymorphism.Demo
{
	public class MovieFactory
	{
		public IMovie Create(LicensingModel licensingModel, DateTime purchased)
		{
			switch (licensingModel)
			{
				case LicensingModel.TwoDays:
					return new TwoDaysMovie(purchased);
				case LicensingModel.LifeLong:
					return new LifeLongMovie(purchased);
				default:
					throw new ArgumentOutOfRangeException(nameof(licensingModel), licensingModel, "Unknown licensing model");
			}
		}
	}
}