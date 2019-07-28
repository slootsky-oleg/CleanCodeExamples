using System;
using General.FeatureEnvy.Common;

namespace General.FeatureEnvy.But
{
	public class HourlyEmployee
	{
		private Salary salary;

		public string Name { get; }
		public Money HourlyRate => salary.HourlyRate;

		public Money CalculateWeeklyPay(Week week)
		{
			Money hourlyRate = HourlyRate;
			double hoursWorked = GetWorkingHours(week);
			double weeklyPay = hourlyRate * hoursWorked;

			return Money.From(weeklyPay);
		}

		private WorkingReport GetWorkingReport(Week week)
		{
			throw new NotImplementedException();
		}

		public double GetWorkingHours(Week week)
		{
			return GetWorkingReport(week).Hours;
		}
	}
}