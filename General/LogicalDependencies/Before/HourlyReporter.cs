using System;
using System.Collections.Generic;

namespace General.LogicalDependencies.Before
{
	public class HourlyReporter
	{
		//Misplaced responsibility
		private const int PageSize = 55;

		private readonly HourlyReportFormatter formatter;

		public HourlyReporter(HourlyReportFormatter formatter)
		{
			this.formatter = formatter;
		}

		public void GenerateReport(IEnumerable<HourlyEmployee> employees)
		{
			var page = new List<LineItem>();

			foreach (var employee in employees)
			{
				AddLineItemToPage(page, employee);

				if (page.Count == PageSize)
					PrintAndClearItemList(page);
			}

			if (page.Count > 0)
				PrintAndClearItemList(page);
		}

		private void PrintAndClearItemList(List<LineItem> page)
		{
			formatter.Format(page);
			page.Clear();
		}

		private void AddLineItemToPage(List<LineItem> page, HourlyEmployee employee)
		{
			var reportItem = new LineItem
			{
				Name = employee.Name,
				Pay = employee.CalculatePay()
			};

			page.Add(reportItem);
		}
	}
}