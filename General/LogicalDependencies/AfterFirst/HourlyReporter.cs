using System;
using System.Collections.Generic;

namespace General.LogicalDependencies.AfterFirst
{
	public class HourlyReporter
	{
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

				//PageSize to formatter.MaxPageSize
				//Consider: move pagination logic to the Formatter
				if (page.Count == formatter.MaxPageSize)
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
			throw new NotImplementedException();
		}
	}
}