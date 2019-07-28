using System;
using General.FeatureEnvy.Common;


namespace General.FeatureEnvy.But
{
	public class HourlyEmployeeReport
	{
		public string ReportWeeklyPay(HourlyEmployee employee, Week week)
		{
			var hoursWorked = employee.GetWorkingHours(week);
			var weeklyPay = employee.CalculateWeeklyPay(week);

			return
				$"Name: {employee.Name}, Hourly rate: {employee.HourlyRate}, hours worked: {hoursWorked}, pay: {weeklyPay}";
		}
	}
}