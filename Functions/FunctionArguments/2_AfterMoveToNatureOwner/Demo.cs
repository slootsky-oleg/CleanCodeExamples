using System;

namespace Functions.FunctionArguments._2_AfterMoveToNatureOwner
{
	public class Demo
	{
		public void RunDemo()
		{
			var twoDaysMovie = new Movie(LicensingModel.TwoDays, DateTime.Now);
			var expirationDate = twoDaysMovie.GetExpirationDate();

			var lifeLongMovie = new Movie(LicensingModel.LifeLong, DateTime.Now);
			var price = lifeLongMovie.GetPrice(CustomerStatus.Advanced);
		}
	}
}