using General.FeatureEnvy.Common;

namespace General.FeatureEnvy.Before
{
	public class HourlyPayCalculator
	{
		public Money CalculateWeeklyPay(HourlyEmployee employee, Week week)
		{
			Money hourlyRate = employee.Salary.HourlyRate;
			double hoursWorked = employee.GetWorkingReport(week).Hours;
			double weeklyPay = hourlyRate * hoursWorked;

			return Money.From(weeklyPay);
		}
	}
}