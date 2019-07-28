using System;
using General.FeatureEnvy.Common;

namespace General.FeatureEnvy.After
{
	public class HourlyEmployee
	{
		private Salary salary;

		public Money CalculateWeeklyPay(Week week)
		{
			Money hourlyRate = salary.HourlyRate;
			double hoursWorked = GetWorkingReport(week).Hours;
			double weeklyPay = hourlyRate * hoursWorked;

			return Money.From(weeklyPay);
		}

		private WorkingReport GetWorkingReport(Week week)
		{
			throw new NotImplementedException();
		}
	}
}