using System;
using System.Collections.Generic;

namespace General.LogicalDependencies.AfterSecond
{
	public class HourlyReporter
	{
		public void GenerateReport(IEnumerable<HourlyEmployee> employees)
		{
			var formatter = new HourlyReportFormatter();

			foreach (var employee in employees)
			{
				var reportItem = new LineItem
				{
					Name = employee.Name,
					Pay = employee.CalculatePay()
				};

				formatter.Add(reportItem);
			}

			formatter.Generate();
		}
	}
}